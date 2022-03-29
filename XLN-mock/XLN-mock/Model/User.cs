using System;
using System.ComponentModel.DataAnnotations;

namespace XLN_mock.Model
{
    public class User
    {
        public int AccountNumber { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactEmail { get; set; }

        public string ContactPhone { get; set; }

        public List<string> CLIs { get; set; }

        public List<FaultForm> Faults { get; set; }
    }
}
