using fishTankApp.ViewModels;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fishTankApp.Services
{
    public class ViewModelService : IViewModelService
    {
        private ISensorDataService sensorDataService;
        private IUrlHelper urlHelper;

        public ViewModelService(ISensorDataService sensorDataService, 
            IUrlHelper urlHelper)
        {
            this.sensorDataService = sensorDataService;
            this.urlHelper = urlHelper;
        }

        public DashboardViewModel GetDashboardViewModel()
        {
            return new DashboardViewModel
            {
                WaterTemperatureTitle = new SensorTileViewModel
                {
                    Title = "Water temperature",
                    Value = sensorDataService.GetWaterTemperatureFahrenheit().Value,
                    ColorCssClass = "panel-primary",
                    IconCssClass = "fa-sliders",
                    Url = urlHelper.Action("GetWaterTemperatureChart", "History")
                },

                FishMotionTitle = new SensorTileViewModel
                {
                    Title = "Fish motion",
                    Value = sensorDataService.GetFishMotionPercentage().Value,
                    ColorCssClass = "panel-green",
                    IconCssClass = "fa-car",
                    Url = urlHelper.Action("GetFishMotionChart", "History")
                },

                WaterOpacityTitle = new SensorTileViewModel
                {
                    Title = "Water opacity",
                    Value = sensorDataService.GetWaterOpacityPercentage().Value,
                    ColorCssClass = "panel-yellow",
                    IconCssClass = "fa-adjust",
                    Url = urlHelper.Action("GetWaterOpacityChart", "History")
                },

                LightIntensityTitle = new SensorTileViewModel
                {
                    Title = "Light intensity",
                    Value = sensorDataService.GetLightIntesityLumens().Value,
                    ColorCssClass = "panel-red",
                    IconCssClass = "fa-lightbuld-o",
                    Url = urlHelper.Action("GetLightIntensityLumensChart", "History")
                }


            };
        }
    }
}
 