using InBodycheck.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InBodycheck.Controllers
{
    public class BillController : Controller
    {
        private static IList<BillModel> bills = new List<BillModel>(){
            new BillModel(){ReceiptID = 1, Name = "rachunek",Description = "Do schudnięcia 17,8kg",Done = false,Fat = 17,Date=DateTime.Now},
             new BillModel(){ReceiptID = 2, Name = "rachunek2",Description = "Do schudnięcia 18kg",Done = false,Fat = 18,Date=DateTime.Now}
        };
        // GET: Bill
        public ActionResult Index()
        {
            return View(bills.Where(x=> !x.Done));
          }

        // GET: Bill/Details/5
        public ActionResult Details(int id)
        {
            return View(bills.FirstOrDefault(x=> x.ReceiptID == id));
        }

        // GET: Bill/Create
        public ActionResult Create()
        {
            return View(new BillModel());
        }

        // POST: Bill/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BillModel billModel)
        {
            billModel.ReceiptID = bills.Count + 1;
            bills.Add(billModel);

                return RedirectToAction(nameof(Index));
        }

        // GET: Bill/Edit/5
        public ActionResult Edit(int id)
        {
            return View(bills.FirstOrDefault(x=> x.ReceiptID == id));
        }

        // POST: Bill/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BillModel billModel)
        {
            BillModel bill = bills.FirstOrDefault(x=> x.ReceiptID == id);
            bill.Name = billModel.Name;
            bill.Description = billModel.Description;
                return RedirectToAction(nameof(Index));
        }

        // GET: Bill/Delete/5
        public ActionResult Delete(int id)
        {
            return View(bills.FirstOrDefault(x =>x.ReceiptID == id));
        }

        // POST: Bill/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, BillModel billModel)
        {
            BillModel bill = bills.FirstOrDefault(x => x.ReceiptID == id);
            bills.Remove(bill);
                return RedirectToAction(nameof(Index));
        }
        // GET: Task/Done/5
        public ActionResult Done(int id)
        {
            BillModel bill = bills.FirstOrDefault(x => x.ReceiptID == id);
            bill.Done = true;
            return RedirectToAction(nameof(Index));
        }
    }
}
