namespace SpecificLibraryAdapter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string JsonData = "Randon Json data";
            AnalyticsLibrary adaptee = new AnalyticsLibrary();
            DataFormatAdapter adapter = new DataFormatAdapter(adaptee);
            adapter.DisplayGraph(JsonData);
        }
    }
}
