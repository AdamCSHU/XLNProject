using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class Fault
    {
        [Key]
        public int FaultId { get; set; }

        public string Status { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        public string FaultAgainst { get; set; } = string.Empty;
        public bool DivertRequired { get; set; }
        public string DivertPhone { get; set; } = string.Empty;
        public string AffectingWhat { get; set; } = string.Empty;
        public string IncidentType { get; set; } = string.Empty;
        public string IncidentDetails { get; set; } = string.Empty;
        public bool IsIntermittent { get; set; }
        public string IntermittentDetails { get; set; } = string.Empty;

        public string DiagnosticsResults { get; set; } = string.Empty;

        public bool AcceptsWarning { get; set; }


      



    }
}
