using InBodycheck.Models;

namespace InBodycheck.Repositories
{
    public class BillRepository : IBillRepository
    {
        private readonly BIllMangerContext _context;
        public BillRepository(BIllMangerContext context)
        {
            _context = context;
        }
        public void Add(BillModel bill)
        {
           _context.Bills.Add(bill);
           _context.SaveChanges();
        }

        public void Delete(int billId)
        {
           var result = _context.Bills.SingleOrDefault(x => x.ReceiptID== billId);
            if (result != null)
            {
                _context.Bills.Remove(result);
                _context.SaveChanges();
            }
        }

        public BillModel Get(int billId)
            => _context.Bills.SingleOrDefault(x => x.ReceiptID == billId);

        public IQueryable<BillModel> GetAllActive()
            => _context.Bills.Where(x => !x.Done);

        public void Update(int billId, BillModel bill)
        {
            var result = _context.Bills.SingleOrDefault(x=> x.ReceiptID == billId);
            if (result != null)
            {
                result.Name= bill.Name;
                result.Description= bill.Description;
                result.Done = bill.Done;
                _context.SaveChanges();
            }
        }
    }
}
