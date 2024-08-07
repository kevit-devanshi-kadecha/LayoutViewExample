using ServiceContracts;

namespace Services
{
    public class CitiesService : ICitiesService , IDisposable
    {
        private List<string> _cities;

        public CitiesService()
        {
            _cities = new List<string>() {
            "London",
            "Paris",
            "New York",
            };

            // to open DB connection 
        }
        public List<string> GetCities()
        {
            return _cities;
        }
        public void Dispose()
        {
            // To Close DB connection 
        }
    }
}
