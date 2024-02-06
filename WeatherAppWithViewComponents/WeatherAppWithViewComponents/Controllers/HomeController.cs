using Microsoft.AspNetCore.Mvc;
using WeatherAppWithViewComponents.Models;

namespace WeatherAppWithViewComponents.Controllers {
	public class HomeController : Controller {
		[Route("/")]
		public IActionResult Index() {
			List<CityWeather> cityWeatherList = new List<CityWeather>() {
				new CityWeather() { CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 8:00"),  TemperatureFahrenheit = 33},
				new CityWeather() { CityUniqueCode = "NYC", CityName = "New York", DateAndTime = Convert.ToDateTime("2030-01-01 3:00"),  TemperatureFahrenheit = 60},
				new CityWeather() { CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00"),  TemperatureFahrenheit = 82}
			};
			ViewBag.Title = "Weather";
			return View(cityWeatherList);
		}

		[Route("weather/{cityCode?}")]
		public IActionResult CityWeather(string? cityCode) {
			List<CityWeather> cityWeatherList = new List<CityWeather>() {
				new CityWeather() { CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 8:00"),  TemperatureFahrenheit = 33},
				new CityWeather() { CityUniqueCode = "NYC", CityName = "New York", DateAndTime = Convert.ToDateTime("2030-01-01 3:00"),  TemperatureFahrenheit = 60},
				new CityWeather() { CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00"),  TemperatureFahrenheit = 82}
			};
			CityWeather? city = cityWeatherList.Where(temp => temp.CityUniqueCode == cityCode).FirstOrDefault();
			if (city != null) {
				ViewBag.Title = $"{city.CityName} city weather";
			}
			return View(city);
		}
	}
}
