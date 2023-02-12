using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace itlapr.Web.Controllers
{
    public class SalesController : Controller
    {
        // GET: SalesController
        public ActionResult Index()
        {
            List<Models.SalesModel> sales = new List<Models.SalesModel>()
            {
                new Models.SalesModel()
                {
                    orderid= 1003, custid=1006, empid=1009, orderdate="08-02-2022", requireddate="08-02-2022", shippeddate="08-02-2022", shipperid =1001, freight=100, shipname="Maria", shipadress="La Caleta", shipcity="Boca Chica", shipregion="Sureste", shipostalcode="11500", shipconuntry="Republica Dominicana"
                },
                new Models.SalesModel()
                {
                    orderid= 1004, custid=1008, empid=1012, orderdate="09-02-2022", requireddate="09-02-2022", shippeddate="09-02-2022", shipperid =1002, freight=50, shipname="Carmen", shipadress="24 de Abril", shipcity="Los Alcarrizos", shipregion="Sureste", shipostalcode="11803", shipconuntry="Republica Dominicana"
                },
                new Models.SalesModel()
                {
                    orderid= 1005, custid=1005, empid=1008, orderdate="10-02-2022", requireddate="10-02-2022", shippeddate="10-02-2022", shipperid =1004, freight=200, shipname="Rosa", shipadress="Arroyo Mina", shipcity="Pedro Brand", shipregion="Sureste", shipostalcode="11200", shipconuntry="Republica Dominicana"
                },
                new Models.SalesModel()
                {
                    orderid= 1006, custid=1007, empid=1010, orderdate="11-02-2022", requireddate="11-02-2022", shippeddate="11-02-2022", shipperid =1008, freight=150, shipname="Janiel", shipadress="La Ciénaga", shipcity="Santo Domingo Oeste", shipregion="Sureste", shipostalcode="10804", shipconuntry="Republica Dominicana"
                },
            };
            return View(sales);
        }

        // GET: SalesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SalesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalesController/Create
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

        // GET: SalesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SalesController/Edit/5
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

        // GET: SalesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SalesController/Delete/5
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