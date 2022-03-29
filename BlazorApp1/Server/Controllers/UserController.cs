using BlazorApp1.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public static List<xlnuser> users = new List<xlnuser>
        {
            new xlnuser { Id = 1, Name = "Ismail" ,
                 CompanyName = " Bakes ",
                       Email = "ismail@gmail.com",
                       Address =  "Maplebeck Drive S91WH",
                       PhoneNumber = "0770128013"

            
            },

             new xlnuser { Id = 2, Name = "Ahmed" ,
                  CompanyName = " Ahemds Foods ",
                       Email = "ahmed@gmail.com",
                       Address =  "Highgate S91WL",
                       PhoneNumber = "072304713201"


            },
             new xlnuser { Id = 3, Name = "John KLSD" ,
                 CompanyName = " Sandwhich mani ",
                       Email = "john@gmail.com",
                       Address =  "Hasfield Drive S32QR",
                       PhoneNumber = "07237030812"



            },
        };

        [HttpGet]

        public async Task<ActionResult<List<xlnuser>>> GetUsers()
        {
            return Ok(users);

        }

        [HttpGet]
        [Route("{id}")]
       
        public async Task<ActionResult<xlnuser>> GetSingleUser(int id)
        {
            var user = users.FirstOrDefault(h => h.Id == id);
            if (user == null)
            {
                return NotFound("Sorry, no user here. ");
            }
            return Ok(user);
        }

    }
}
