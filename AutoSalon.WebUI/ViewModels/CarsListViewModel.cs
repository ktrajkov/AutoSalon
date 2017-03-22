namespace AutoSalon.WebUI.ViewModels
{
    using AutoSalon.Domain.Entities;
    using System.Collections.Generic;

    public class CarsListViewModel
    {
        public IEnumerable<Car> Cars { get; set; }

        public string SearchedDescription { get; set; }
    }
}