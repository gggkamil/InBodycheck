using InBodycheck.Models;
using InBodycheck.Repositories;

using Microsoft.AspNetCore.Mvc;

namespace InBodycheck.Controllers
{
    public class BillController : Controller
    {
        private readonly IBillRepository _billRepository;
        public BillController(IBillRepository billRepository)
        {
            _billRepository = billRepository;
        }

        // GET: Bill
        public ActionResult Index()
        {
            return View(_billRepository.GetAllActive());
          }

        // GET: Bill/Details/5
        public ActionResult Details(int id)
        {
            return View(_billRepository.Get(id));
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
            _billRepository.Add(billModel);

                return RedirectToAction(nameof(Index));
        }

        // GET: Bill/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_billRepository.Get(id));
        }

        // POST: Bill/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BillModel billModel)
        {
            _billRepository.Update(id, billModel);
                return RedirectToAction(nameof(Index));
        }

        // GET: Bill/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_billRepository.Get(id));
        }

        // POST: Bill/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, BillModel billModel)
        {
            _billRepository.Delete(id);
                return RedirectToAction(nameof(Index));
        }
        // GET: Task/Done/5
        public ActionResult Done(int id)
        {
            BillModel bill = _billRepository.Get(id);
            bill.Done = true;
            _billRepository.Update(id, bill);
            return RedirectToAction(nameof(Index));
        }
    }
}
