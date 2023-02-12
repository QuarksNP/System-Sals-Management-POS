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
                    employerId=20212138, firstName = "Alberto", lastName = "Guzman", birthDate= DateTime.Now.ToString("27-11-2003"), city= "Santo Domingo", country="Domican Republic", hireDate= DateTime.Now.ToString("02-10-2023"), phone= "849-367-7774", position= "Supervisor", postalCode= 10100, region= "Sureste"
                },

                 new Models.EmployeesModel()
                {
                    employerId=20220397, firstName = "Roberto", lastName = "Isaac", birthDate= DateTime.Now.ToString("15-01-2003"), city= "Santiago", country="Domican Republic", hireDate= DateTime.Now.ToString("23-05-2023"), phone= "829-234-2424", position= "Manager", postalCode= 51000, region= "Cibao"
                },

                 new Models.EmployeesModel()
                {
                    employerId=20220113, firstName = "Misael", lastName = "Naranjo", birthDate= DateTime.Now.ToString("03-07-2003"), city= "Monte Cristi", country="Domican Republic", hireDate= DateTime.Now.ToString("16-07-2023"), phone= "849-887-8662", position= "Asistent", postalCode= 10100, region= "Noreste"
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
