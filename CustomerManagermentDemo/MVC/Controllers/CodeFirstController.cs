using MVC.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CodeFirstController : Controller
    {
        private readonly ICustomerTypeRepository _customerTypeRepository;
        private readonly ICustomerRepository _customerRepository;

        public CodeFirstController(ICustomerTypeRepository customerTypeRepository, ICustomerRepository customerRepository)
        {
            this._customerTypeRepository = customerTypeRepository;
            this._customerRepository = customerRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var result = this._customerRepository.Get();
           ViewBag.Styles = this._customerTypeRepository.Get();
            return View(result);
        }

        

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            var Id = collection["Id"] == null ? Guid.Empty : Guid.Parse(collection["Id"]);
            if (Id == Guid.Empty)
            {
                var name = collection["Name"];
                var phoneNumber = collection["PhoneNumber"];
                var address = collection["Address"];
                var type = Guid.Parse(collection["Type"]);

                var Customer = new Customer()
                {
                    Name = name,
                    PhoneNumber = phoneNumber,
                    Address = address,
                    Type_Id= type
                };
                this._customerRepository.InsertOrUpdate(Customer);
            }
            else
            {

                var name = collection["name"];
                var phoneNumber = collection["phoneNumber"];
                var address = collection["address"];
                var type = Guid.Parse(collection["type"]);


                var Customer = new Customer()
                {
                    Id = Id,
                    Name = name,
                    PhoneNumber = phoneNumber,
                    Address = address,
                    Type_Id = type
                };
                this._customerRepository.InsertOrUpdate(Customer);
            };
            return Redirect("/CodeFirst/Index");
        }


        [HttpPost]
        public ActionResult Delete(string Id, string submit)
        {
            if (Id != null)
            {
                this._customerRepository.Delete(Guid.Parse(Id), submit);
            }
            return Redirect("/CodeFirst");
        }
    }
}