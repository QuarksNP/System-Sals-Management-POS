using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace itlapr.Web.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: EmployeesController
        public ActionResult Index()
        {
            List<Models.EmployeesModel> employess = new List<Models.EmployeesModel>()
            {
                new Models.EmployeesModel()
                {
                    firstName = "Alberto", lastName = "Guzman", birthDate= new DateTime(11/27/2003), city= "Santo Domingo", country="Domican Republic", hireDate= new DateTime(02/10/2023), phone= "849-367-7774", position= "Supervisor", postalCode= 10100, region= "Sureste"
                },

                 new Models.EmployeesModel()
                {
                    firstName = "Alberto", lastName = "Guzman", birthDate= new DateTime(11/27/2003), city= "Santo Domingo", country="Domican Republic", hireDate= new DateTime(02/10/2023), phone= "849-367-7774", position= "Supervisor", postalCode= 10100, region= "Sureste"
                },

                 new Models.EmployeesModel()
                {
                    firstName = "Alberto", lastName = "Guzman", birthDate= new DateTime(11/27/2003), city= "Santo Domingo", country="Domican Republic", hireDate= new DateTime(02/10/2023), phone= "849-367-7774", position= "Supervisor", postalCode= 10100, region= "Sureste"
                },

                 new Models.EmployeesModel()
                {
                    firstName = "Alberto", lastName = "Guzman", birthDate= new DateTime(11/27/2003), city= "Santo Domingo", country="Domican Republic", hireDate= new DateTime(02/10/2023), phone= "849-367-7774", position= "Supervisor", postalCode= 10100, region= "Sureste"
                },

                 new Models.EmployeesModel()
                { 
                    firstName = "Alberto", lastName = "Guzman", birthDate= new DateTime(11/27/2003), city= "Santo Domingo", country="Domican Republic", hireDate= new DateTime(02/10/2023), phone= "849-367-7774", position= "Supervisor", postalCode= 10100, region= "Sureste"
                }
            };

            return View(employess);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
