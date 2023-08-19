using System;
using VivekBank.Entitie;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivekBank.Entitie
{
    /// <summary>
    /// Represents customer of the bank
    /// </summary>
    public class Customer:ICustomer
    {
        //field
        private Guid _customerID;
        private string _customerCode;
        private string _customernNme;
        private string _address;
        private string _landmark;
        private string _city;
        private string _country;
        private string _mobile;

        //properties
        public Guid CustomerID { get => _customerID; set => _customerID = value; }
        public string CustomerCode { get => _customerCode; set => _customerCode = value; }
        public string CustomernNme { get => _customernNme; set => _customernNme = value; }
        public string Address { get => _address; set => _address = value; }
        public string Landmark { get => _landmark; set => _landmark = value; }
        public string City { get => _city; set => _city = value; }
        public string Country { get => _country; set => _country = value; }
        public string Mobile { get => _mobile; set => _mobile = value; }
    }
}
