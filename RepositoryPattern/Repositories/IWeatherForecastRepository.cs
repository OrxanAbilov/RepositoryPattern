namespace RepositoryPattern.Repositories
{
    public interface IWeatherForecastRepository
    {
        public IEnumerable<WeatherForecast> Get();
    }
}
