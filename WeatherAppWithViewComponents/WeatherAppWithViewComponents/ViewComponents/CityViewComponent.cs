using Microsoft.AspNetCore.Mvc;
using WeatherAppWithViewComponents.Models;

namespace WeatherAppWithViewComponents.ViewComponents {
    public class CityViewComponent : ViewComponent {
        public async Task<IViewComponentResult> InvokeAsync(CityWeather city) {
            return View(city);
        }
    }
}
