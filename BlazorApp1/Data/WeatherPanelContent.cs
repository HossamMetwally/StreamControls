using BlazorApp1.Data.IData;
using Microsoft.AspNetCore.Components;
using static BlazorApp1.Pages.WeatherAPI;

namespace BlazorApp1.Data
{
    public class WeatherPanelContent: IPanelContent
    {
        private WeatherResponse weatherData;

        public WeatherPanelContent(WeatherResponse data)
        {
            weatherData = data;
        }

        public RenderFragment RenderContent() => builder =>
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "weather-panel");
            // Add more elements and attributes to render the weather data
            builder.CloseElement();
        };
    }
}
