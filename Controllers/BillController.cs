using InBodycheck.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InBodycheck.Controllers
{
    public class BillController : Controller
    {
        private static IList<BillModel> bills = new List<BillModel>()
        {
            new BillModel(){ ReceiptID =1, Name = "WIzyta  u lekarza",Description= "Godzina 17:00", Done=false}
        };
        // GET: BillController
        public ActionResult Index()
        {
            return View(bills);
        }

        // GET: BillController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BillController/Create
        public ActionResult Create()
        {
            return View(new BillModel());
        }

        // POST: BillController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BillModel billModel)
        {
            billModel.ReceiptID = bills.Count + 1;
            bills.Add(billModel);

                return RedirectToAction(nameof(Index));
        }

        // GET: BillController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BillController/Edit/5
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

        // GET: BillController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BillController/Delete/5
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
