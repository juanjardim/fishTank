﻿using fishTankApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fishTankApp.Services
{
    public interface IViewModelService
    {
        DashboardViewModel GetDashboardViewModel();
    }
}
