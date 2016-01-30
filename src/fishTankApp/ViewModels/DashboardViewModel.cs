using System.ComponentModel.DataAnnotations;

namespace fishTankApp.ViewModels
{
    public class DashboardViewModel
    {
        public SensorTileViewModel WaterTemperatureTitle { get; set; }

        public SensorTileViewModel FishMotionTitle { get; set; }

        public SensorTileViewModel WaterOpacityTitle { get; set; }

        public SensorTileViewModel LightIntensityTitle { get; set; }

        [Display(Name = "Please enter the food amount: ")]
        public int FoodAmount { get; set; }

        [Display(Name = "Last feeding was at")]
        public string LastFed { get; set; }
    }
}
