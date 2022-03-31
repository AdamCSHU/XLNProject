using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public  class xlnuser
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string CompanyName { get; set; } = string.Empty;
         
        public Fault? Fault { get; set; }

       // public int FaultId { get; set; }

        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

       
    }

}
