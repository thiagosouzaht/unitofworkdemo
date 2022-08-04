using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkRestApi.Domain.Entities
{
    public class Bill
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public string FullBillDisplay { get; set; }
    }
}
