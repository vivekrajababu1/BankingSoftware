using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivekBank.Entitie
{
    public class ICustomer
    {
        /// <summary>
        /// Represents interface of cudtomer entity
        /// </summary>
        Guid CustomerID { get; set; }
        long CustomerCode { get; set; }
        string CustomerName { get; set; }
        string Address { get; set; }  
        string Landmark { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Country { get; set; }
        string Mobile{ get; set; }
    }
}
