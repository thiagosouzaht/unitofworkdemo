using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkRestApi.Domain.Entities;

namespace UnitOfWorkRestApi.Domain.Repositories
{
    public interface IBillRepository
    {
        Task InsertBill(Bill bill);
        Task UpdateBill(Bill bll);
        Task DeleteBill(Bill bill);
        Task<List<Bill>> GetAllBills();
        Task<Bill> GetBillById(int id);
    }
}
