﻿using System;
using System.ComponentModel.DataAnnotations;

namespace XLN_mock.Model
{
    public class FaultForm
    {

        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public string ContactEmail { get; set; }


        [Required(ErrorMessage = "Contact Phone is Required")]
        [StringLength(11, MinimumLength = 10, ErrorMessage = "Is you number formatted correctly?")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]*$",
         ErrorMessage = "Characters are not allowed.")]
        public string ContactPhone { get; set; }
        public string MobilePhone { get; set; }
        [Required(ErrorMessage = "Engineer Notes are required")]
        public string EngineerNotes { get; set; }

        public bool DivertRequired { get; set; }
        
        [StringLength(11, MinimumLength = 10, ErrorMessage = "Is you number formatted correctly?")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]*$",
         ErrorMessage = "Characters are not allowed.")]
        public string DivertPhone { get; set; }
        /*---------------*/

        /* Indicent Details */
        [Required(ErrorMessage = "Select what is being affected")]
        public string AffectingWhat { get; set; }

        public string IncidentType { get; set; } = "0";
        

        [Required(ErrorMessage ="Provide Incident Details")]
        public string IncidentDetails { get; set; }
        public bool IsIntermittent { get; set; }

        public string IntermittentDetails { get; set; }
        [Required(ErrorMessage ="You must run diagnostics")]
        public string DiagnosticResults { get; set; }

        //*/
        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Must accept warning")]
        public bool AcceptsWarning { get; set; }


    }
}
