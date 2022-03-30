using System;
using System.ComponentModel.DataAnnotations;

namespace XLN_mock.Model
{
    public class User
    {
        public User() { }
        public User(int ID, string cName, string name, string email, string phone)
        {
            AccountNumber=ID;
            CompanyName=cName;
            ContactName=name;
            ContactEmail=email;
            ContactPhone=phone;
        }
        public void addCLIs(List<string> clis)
        {
            CLIs = clis;
        }
        public void addFault(FaultForm form)
        {
            if (Faults == null) { Faults = new List<FaultForm>(); }
            Faults.Add(form);
        }
        public void delete(string against)
        {
            if (Faults != null)
            {
                for(int x=0; x<Faults.Count; x++)
                {
                    if (Faults[x].FaultAgainst.Equals(against))
                    {
                        Faults.RemoveAt(x);
                    }
                }
            }
        }
        public int AccountNumber { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactEmail { get; set; }

        public string ContactPhone { get; set; }

        public List<string> CLIs { get; set; }

        public List<FaultForm> Faults { get; set; }
    }
}
