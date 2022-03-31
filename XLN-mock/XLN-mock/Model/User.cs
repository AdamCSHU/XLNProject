using System;
using System.ComponentModel.DataAnnotations;

namespace XLN_mock.Model
{
    public class User
    {
        public User() { }
        public User(int ID, string pass,string cName, string name, string email, string phone)
        {
            AccountNumber=ID.ToString();
            Password = pass;
            CompanyName=cName;
            ContactName=name;
            ContactEmail=email;
            ContactPhone=phone;
        }
        public void addProduct(List<string[]> product)
        {
            Products = product;
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
        [Required(ErrorMessage = "Account Number is Required")]
        public string AccountNumber { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactEmail { get; set; }

        public string ContactPhone { get; set; }

        public List<string[]> Products { get; set; }


        public List<FaultForm> Faults { get; set; }
    }
}
