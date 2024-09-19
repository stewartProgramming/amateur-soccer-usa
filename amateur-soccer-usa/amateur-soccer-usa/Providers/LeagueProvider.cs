using AutoMapper;
using Azure.Storage.Blobs;
using Entities.Database;
using Entities.DTO.League;
using Entities.Methods;
using Entities.Parameters;
using Repository.League;
using Repository.Log;

namespace amateur_soccer_usa.Providers
{
    public class LeagueProvider(ILeagueRepository leagueRepo, IMapper mapper, ILogRepository logRepo, IConfiguration config) : ILeagueProvider
    {
        BlobServiceClient blobClient = new(config["ConnectionStrings:AzureBlobStorageConnection"]);

        public async Task<string> CreateAsync(LeagueCreateDTO createModel)
        {
            League newLeague = new()
            {
                Active = true,
                Name = createModel.Name,
                RegionId = createModel.Region,
                CountryId = createModel.Country,
                Tier = createModel.Tier,
                StartingYear = createModel.StartingYear,
                Logo = createModel.LogoUrl
            };
            await leagueRepo.CreateAndSaveAsync(newLeague);

            var test = blobClient.GetBlobContainers().ToList();

            Entities.Database.Log newLog = new()
            {
                Time = DateTime.Now,
                UserId = 1,
                Description = $"stewartprogramming@gmail.com created league {newLeague.Name}",
                Target = "League"
            };
            await logRepo.CreateAndSaveAsync(newLog);

            return $"League {newLeague.Name} successfully created!";
        }

        public async Task<string> DeleteAsync(int leagueId)
        {
            League? league = await leagueRepo.FindAsync(leagueId);
            if (league != null)
            {
                await leagueRepo.DeleteAndSaveAsync(league);

                Entities.Database.Log newLog = new()
                {
                    Time = DateTime.Now,
                    UserId = 1,
                    Description = $"stewartprogramming@gmail.com deleted league {league.Name}",
                    Target = "League"
                };
                await logRepo.CreateAndSaveAsync(newLog);

                return $"League successfully deleted!";
            }
            else
            {
                throw new Exception("Cannot delete league - it does not exist");
            }
        }

        public async Task<IEnumerable<LeagueDTO>> GetAsync(LeagueParameters parameters)
        {
            IEnumerable<League> leagues = await leagueRepo.GetAsync(parameters);

            return mapper.Map<IEnumerable<LeagueDTO>>(leagues);
        }

        public async Task UpdateAsync(LeagueUpdateDTO updateModel)
        {
            League? league = await leagueRepo
                .FindAsync(updateModel.LeagueId);
            if (league != null)
            {
                League? leagueCopy = league;
                mapper.Map(updateModel, league);

                IEnumerable<string> differences = LogMethods
                    .GetChanges(leagueCopy, league);

                foreach (var difference in differences)
                {
                    Entities.Database.Log newLog = new()
                    {
                        Time = DateTime.Now,
                        UserId = 1,
                        Description = $"stewartprogramming@gmail.com changed {difference}",
                        Target = "League"
                    };
                    await logRepo.CreateAndSaveAsync(newLog);
                }

                await leagueRepo.SaveAsync();
            }
        }
    }
}