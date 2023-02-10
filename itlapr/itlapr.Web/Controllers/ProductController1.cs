using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace itlapr.Web.Controllers
{
    public class ProductController1 : Controller
    {
        // GET: ProductController1
        public ActionResult Index()
        {
            List<Models.ProductModel> products = new List<Models.ProductModel>()
            {
                new Models.ProductModel()
                {
                   productId= 0001, categoryId= 1000, discontinued= 0, productName= "Red Sangria", supplierId= 101, unitPrice= 10.99
                },

                new Models.ProductModel()
                {
                   productId= 0002, categoryId= 1001, discontinued= 0, productName= "Margarita", supplierId= 102, unitPrice= 15.99
                },

                new Models.ProductModel()
                {
                   productId= 0003, categoryId= 1002, discontinued= 0, productName= "The bees knees", supplierId= 103, unitPrice= 13.99
                },

                new Models.ProductModel()
                {
                   productId= 0004, categoryId= 1003, discontinued= 0, productName= "Moscow Mule", supplierId= 104, unitPrice= 16.99
                },

                new Models.ProductModel()
                {
                   productId= 0005, categoryId= 1004, discontinued= 0, productName= "Rehia sunshine", supplierId= 105, unitPrice= 12.99
                },

                new Models.ProductModel()
                {
                   productId= 0006, categoryId= 1005, discontinued= 0, productName= "Pure vodka", supplierId= 106, unitPrice= 20.99
                },

                new Models.ProductModel()
                {
                   productId= 0007, categoryId= 1006, discontinued= 0, productName= "Gin Tonic", supplierId= 107, unitPrice= 15.99
                },

                new Models.ProductModel()
                {
                   productId= 0008, categoryId= 1007, discontinued= 0, productName= "Gibson", supplierId= 108, unitPrice= 16.99
                },

                new Models.ProductModel()
                {
                   productId= 0009, categoryId= 1009, discontinued= 0, productName= "Blue hawai", supplierId= 109, unitPrice= 17.99
                },

                 new Models.ProductModel()
                {
                   productId= 0010, categoryId= 1010, discontinued= 0, productName= "Ferroviario", supplierId= 110, unitPrice= 12.99
                },

                  new Models.ProductModel()
                {
                   productId= 0011, categoryId= 1011, discontinued= 0, productName= "Jager Smash", supplierId= 111, unitPrice= 14.99
                },

                   new Models.ProductModel()
                {
                   productId= 0012, categoryId= 1012, discontinued= 0, productName= "Negroni", supplierId= 112, unitPrice= 16.99
                },

                 new Models.ProductModel()
                {
                   productId= 0013, categoryId= 1013, discontinued= 0, productName= "Suffering Bastard", supplierId= 113, unitPrice= 12.99
                },

                  new Models.ProductModel()
                {
                   productId= 0014, categoryId= 1014, discontinued= 0, productName= "Mai Tai", supplierId= 114, unitPrice= 17.99
                },

                 new Models.ProductModel()
                {
                   productId= 0015, categoryId= 1015, discontinued= 0, productName= "Paper Plane", supplierId= 115, unitPrice= 14.99
                },

                 new Models.ProductModel()
                {
                   productId= 0016, categoryId= 1016, discontinued= 0, productName= "Lemon Drop", supplierId= 116, unitPrice= 18.99
                },

                 new Models.ProductModel()
                {
                   productId= 0017, categoryId= 1017, discontinued= 0, productName= "South Side", supplierId= 117, unitPrice= 11.99
                },

                 new Models.ProductModel()
                {
                   productId= 0018, categoryId= 1018, discontinued= 0, productName= "Aperol Spritz", supplierId= 118, unitPrice= 10.99
                }
            };

            return View(products);
        }

        // GET: ProductController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController1/Create
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

        // GET: ProductController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController1/Edit/5
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

        // GET: ProductController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController1/Delete/5
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
