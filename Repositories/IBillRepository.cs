using InBodycheck.Models;

namespace InBodycheck.Repositories
{
    public interface IBillRepository
    {
        BillModel Get(int billId);
        IQueryable<BillModel> GetAllActive();

        void Add(BillModel bill);
        void Update(int billId,BillModel bill);
        void Delete(int billId);
    }
}
