using BlazorApp1.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<Fault> faults = new List<Fault>
        {

            new Fault {
                Id = 1, Status="Done", Notes="NA" ,FaultAgainst="Wifi", DivertRequired = true,
                DivertPhone = "x",  AffectingWhat = "x",  IncidentType = "x",  IncidentDetails = "x",
                 IsIntermittent = false,  IntermittentDetails = "x",  DiagnosticsResults = "x",  AcceptsWarning = false


            },
            new Fault { Id = 2, Status="not Done", Notes="NA", FaultAgainst="Wifi", DivertRequired = true,
                DivertPhone = "x",  AffectingWhat = "x",  IncidentType = "x",  IncidentDetails = "x",
                 IsIntermittent = false,  IntermittentDetails = "x",  DiagnosticsResults = "x",  AcceptsWarning = false},
           
            new Fault { Id = 3, Status="not Done", Notes="NA", FaultAgainst="Wifi", DivertRequired = true,
                DivertPhone = "x",  AffectingWhat = "x",  IncidentType = "x",  IncidentDetails = "x",
                 IsIntermittent = false,  IntermittentDetails = "x",  DiagnosticsResults = "x",  AcceptsWarning = false },
 
    };

        public static List<xlnuser> users = new List<xlnuser>
        {
            new xlnuser { Id = 1, Name = "Ismail" ,
                        CompanyName = " Bakes ",
                       Email = "ismail@gmail.com",
                       Address =  "Thone Drive S91QR",
                       UserName =  "IsmailBakes",
                       Password =  "1234",
                       Fault = faults [0],
                         
                       PhoneNumber = "0770128013"
                

            
            },

             new xlnuser { Id = 2, Name = "Ahmed" ,
                  CompanyName = " Ahemds Foods ",
                       Email = "ahmed@gmail.com",
                       Address =  "Highgate S43ASD",
                       UserName =  "AhmedFoods",
                       Password =  "1234",
                        Fault = faults [1],
                       PhoneNumber = "072304713201"


            },
             new xlnuser { Id = 3, Name = "John KLSD" ,
                 CompanyName = " Sandwhich mani ",
                       Email = "john@gmail.com",
                       Address =  "Hasfield Drive S32QR",
                       UserName =  "JohnK",
                       Password =  "1234",
                       Fault = faults [2],
                       PhoneNumber = "07237030812"
                 


            },
        };

        [HttpGet]

        public async Task<ActionResult<List<xlnuser>>> GetUsers()
        {
            return Ok(users);

        }

        [HttpGet("faults")]

        public async Task<ActionResult<List<Fault>>> GetFaults()
        {
            return Ok(faults);

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
