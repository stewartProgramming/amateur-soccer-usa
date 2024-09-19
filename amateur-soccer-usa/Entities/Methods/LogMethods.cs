using ObjectsComparer;

namespace Entities.Methods
{
    public class LogMethods
    {
        public static List<string> GetChanges<T>(T oldEntity, T newEntity) where T : class
        {
            List<string> changesList = [];

            new ObjectsComparer.Comparer<T>()
                .Compare(oldEntity, newEntity, out IEnumerable<Difference> differences);
            foreach (Difference difference in differences)
            {
                string description = difference.MemberPath + ": from " + difference.Value1 + " to " + difference.Value2;
                changesList.Add(description);
            }

            return changesList;
        }
    }
}
