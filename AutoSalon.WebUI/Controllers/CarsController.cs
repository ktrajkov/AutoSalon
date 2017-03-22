namespace AutoSalon.WebUI.Controllers
{
    using Domain.Abstract;
    using Domain.Entities;
    using ViewModels;
    using System;
    using System.Linq;
    using System.Web.Mvc;

    public class CarsController : Controller
    {
        public CarsController(IRepository<Car> carRepository)
        {
            this.CarRepository = carRepository;
        }

        public ActionResult Index()
        {
            var carsFilterViewModel = new CarsFilterViewModel
            {
                Impororters = CarRepository.All().Select(x => x.Importer)
            };
            return View(carsFilterViewModel);
        }

        public ActionResult List(CarsFilterViewModel filter)
        {
            if (ModelState.IsValid)
            {
                var carsListViewModel = new CarsListViewModel
                {
                    Cars = CarRepository.All()
                        .Where(x => (String.IsNullOrEmpty(filter.Importer) || x.Importer == filter.Importer) &&
                            (String.IsNullOrEmpty(filter.Description) || x.Description.Contains(filter.Description)))
                        .OrderBy(x => x.YearOfManufacture),
                    SearchedDescription = filter.Description
                };
                return View(carsListViewModel);
            }
            else
            {
                filter.Impororters = CarRepository.All().Select(x => x.Importer);
                return View("Index", filter);
            }
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Car car)
        {
            if (ModelState.IsValid)
            {
                CarRepository.Add(car);
                CarRepository.SaveChanges();
                return RedirectToAction("List");
            }
            return View(car);
        }

        private IRepository<Car> CarRepository { get; set; }
    }
}