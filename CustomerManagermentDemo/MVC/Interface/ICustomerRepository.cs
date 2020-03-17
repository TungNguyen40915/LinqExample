using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Interface
{
    public interface ICustomerRepository
    {
        List<Customer> Get();
        Customer InsertOrUpdate(Customer customer);
        int Delete(Guid id, string Type);
    }
}
