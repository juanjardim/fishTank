
using System.Collections.Generic;
using fishTankApp.Models;
using fishTankApp.Services;
using Microsoft.AspNet.Mvc;

namespace fishTankApp.Controllers.Api
{
    public class HistoryDataController : Controller
    {
        private readonly ISensorDataService _sensorDataService;

        public HistoryDataController(ISensorDataService sensorDataService)
        {
            this._sensorDataService = sensorDataService;
        }

        public IEnumerable<IntHistoryModel> GetWaterTemperatureHistory()
        {
            return _sensorDataService.GetWaterTemperatureHistory();
        }

        public IEnumerable<IntHistoryModel> GetFishMotionPercentageHistory()
        {
            return _sensorDataService.GetFishMotionPercentageHistory();
        }

        public IEnumerable<IntHistoryModel> GetWaterOpacityPercentageHistory()
        {
            return _sensorDataService.GetWaterOpacityPercentageHistory();
        }

        public IEnumerable<IntHistoryModel> GetLightIntensityLumensHistory()
        {
            return _sensorDataService.GetLightIntensityLumensHistory();
        }

    }
}
