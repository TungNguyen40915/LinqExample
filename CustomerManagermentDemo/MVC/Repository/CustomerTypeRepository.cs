using MVC;
using MVC.Interface;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Repository
{
    public class CustomerTypeRepository : ICustomerTypeRepository
    {
        public List<CustomerType> Get()
        {
            try
            {
                using (CustomerDbDataContext context = new CustomerDbDataContext())
                {

                    var result = from u in context.CustomerTypes select u;
                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
