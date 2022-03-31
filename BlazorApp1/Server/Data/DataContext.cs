namespace BlazorApp1.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {




        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<xlnuser>().HasData(
                  new xlnuser
                  {
                      Id = 1,
                      Name = "Ismail",
                      CompanyName = " Bakes ",
                      Email = "ismail@gmail.com",
                      Address = "Thone Drive S91QR",
                      UserName = "IsmailBakes",
                      Password = "1234",


                      PhoneNumber = "0770128013"



                  },

             new xlnuser
             {
                 Id = 2,
                 Name = "Ahmed",
                 CompanyName = " Ahemds Foods ",
                 Email = "ahmed@gmail.com",
                 Address = "Highgate S43ASD",
                 UserName = "AhmedFoods",
                 Password = "1234",

                 PhoneNumber = "072304713201"


             },
             new xlnuser
             {
                 Id = 3,
                 Name = "John KLSD",
                 CompanyName = " Sandwhich mani ",
                 Email = "john@gmail.com",
                 Address = "Hasfield Drive S32QR",
                 UserName = "JohnK",
                 Password = "1234",

                 PhoneNumber = "07237030812"



             });
            modelBuilder.Entity<Fault>().HasData(
            new Fault
            {
                FaultId = 1,
                Status = "Done",
                Notes = "NA",
                FaultAgainst = "Wifi",
                DivertRequired = true,
                DivertPhone = "x",
                AffectingWhat = "x",
                IncidentType = "x",
                IncidentDetails = "x",
                IsIntermittent = false,
                IntermittentDetails = "x",
                DiagnosticsResults = "x",
                AcceptsWarning = false


            },
            new Fault
            {
                FaultId = 2,
                Status = "not Done",
                Notes = "NA",
                FaultAgainst = "Wifi",
                DivertRequired = true,
                DivertPhone = "x",
                AffectingWhat = "x",
                IncidentType = "x",
                IncidentDetails = "x",
                IsIntermittent = false,
                IntermittentDetails = "x",
                DiagnosticsResults = "x",
                AcceptsWarning = false
            },

            new Fault
            {
                FaultId = 3,
                Status = "not Done",
                Notes = "NA",
                FaultAgainst = "Wifi",
                DivertRequired = true,
                DivertPhone = "x",
                AffectingWhat = "x",
                IncidentType = "x",
                IncidentDetails = "x",
                IsIntermittent = false,
                IntermittentDetails = "x",
                DiagnosticsResults = "x",
                AcceptsWarning = false
            }
 );
        }
        public DbSet<xlnuser> customers { get; set;}
   public DbSet<Fault> errors { get; set;}

    }
}
