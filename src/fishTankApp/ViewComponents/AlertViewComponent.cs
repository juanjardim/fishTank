
using System.Collections.Generic;
using fishTankApp.Options;
using fishTankApp.Services;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;

namespace fishTankApp.ViewComponents
{
    public class AlertViewComponent : ViewComponent
    {
        private readonly ISensorDataService _sensorDataService;
        private readonly ThresholdOptions _thresholdOptions;

        public AlertViewComponent(ISensorDataService sensorDataService,
            IOptions<ThresholdOptions> thresholdOptions)
        {
            _sensorDataService = sensorDataService;
            _thresholdOptions = thresholdOptions.Value;
        }

        public IViewComponentResult Invoke()
        {
            var viewModel = new List<string>();

            if (_sensorDataService.GetFishMotionPercentage().Value > _thresholdOptions.FishMotionMax)
                viewModel.Add("Too much fish activity");
            if (_sensorDataService.GetFishMotionPercentage().Value < _thresholdOptions.FishMotionMin)
                viewModel.Add("Looks like we have some dead fish");

            if (_sensorDataService.GetLightIntesityLumens().Value > _thresholdOptions.LightIntensityMax)
                viewModel.Add("Bright light, bright light");
            if (_sensorDataService.GetLightIntesityLumens().Value < _thresholdOptions.LightIntensityMin)
                viewModel.Add("It's dark out here");

            if (_sensorDataService.GetWaterOpacityPercentage().Value > _thresholdOptions.WaterOpacityMax)
                viewModel.Add("The fish can't see you");
            if (_sensorDataService.GetWaterOpacityPercentage().Value < _thresholdOptions.WaterOpacityMin)
                viewModel.Add("The water is too clean");


            if (_sensorDataService.GetWaterTemperatureFahrenheit().Value > _thresholdOptions.WaterTemperatureMax)
                viewModel.Add("Water too hot!");
            if (_sensorDataService.GetWaterTemperatureFahrenheit().Value < _thresholdOptions.WaterTemperatureMin)
                viewModel.Add("Water too cold!");

            return View(viewModel);
        }
    }
}
