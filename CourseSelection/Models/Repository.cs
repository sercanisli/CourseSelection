namespace CourseSelection.Models
{
    public static class Repository
    {
        private static List<Candidante> applications = new();
        public static IEnumerable<Candidante> Applications => applications;
        public static void Add(Candidante candidante)
        {
            applications.Add(candidante);
        }
    }
}
