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
     public class CustomerRepository : ICustomerRepository
    {
        public int Delete(Guid id, string deleteType)
        {
            try
            {
                using (CustomerDbDataContext context = new CustomerDbDataContext())
                {
                    switch (deleteType)
                    {
                        case "PermDelete":
                            var x = (from y in context.Customers
                                     where y.Id == id
                                     select y).FirstOrDefault();
                            context.Customers.DeleteOnSubmit(x);                        
                            break;
                        case "TempDelete":
                            Customer deleteCustomer = context.Customers.Single(customer => customer.Id == id);
                            deleteCustomer.isDeleted = true;        
                            break;
                    }
                    context.SubmitChanges();
                    return 1;
                    
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public List<Customer> Get()
        {
            try
            {
                using (CustomerDbDataContext context = new CustomerDbDataContext())
                {
                    DataLoadOptions dlo = new DataLoadOptions();
                    dlo.LoadWith<Customer>(c => c.CustomerType);
                    context.LoadOptions = dlo;

                    var result = from u in context.Customers
                                 where u.isDeleted == false
                                 select u;

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public Customer InsertOrUpdate(Customer customer)
        {
            try
            {
                using (CustomerDbDataContext context = new CustomerDbDataContext())
                {
                    var result = context.Customers.FirstOrDefault(x => x.Id == customer.Id);
                    if (result == null)
                    {
                        customer.Id = Guid.NewGuid();
                        //customer.name = customer.name;
                        //customer.phoneNumber = customer.phoneNumber;
                        //customer.address = customer.address;
                        customer.CustomerType = context.CustomerTypes.FirstOrDefault(y => y.Id == customer.Type_Id);
                        context.Customers.InsertOnSubmit(customer);
                    }
                    else
                    {
                        Customer editCustomer = context.Customers.Single(x => x.Id == customer.Id);

                        editCustomer.Name = customer.Name;
                        editCustomer.PhoneNumber = customer.PhoneNumber;
                        editCustomer.Address = customer.Address;
                        editCustomer.CustomerType = context.CustomerTypes.FirstOrDefault(y => y.Id == customer.Type_Id);


                    }
                    context.SubmitChanges();
                    //return result;
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
