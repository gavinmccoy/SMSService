using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSService.Models
{
    public class SMSTextMessage
    {
        // ID property for Entity Framework integration
        public int Id { get; set; }

        // Area Code property for area code of contact with validation
        [Display(Name = "Area Code")]
        [Required(ErrorMessage = "You must enter a valid area code e.g. 085")]
        [RegularExpression("^08[3-9]$", ErrorMessage = "Please enter a valid 3 digit area code")]
        public string AreaCode { get; set; }

        // Phone Number property for phone number of contact with validation
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "You must enter a valid phone number e.g. 1234567")]
        [RegularExpression("^[0-9][0-9][0-9][0-9][0-9][0-9][0-9]$", ErrorMessage = "Please enter a valid 7 digit phone number")]
        public string PhoneNumber { get; set; }

        // Text Content property for text content of message with validation
        [Display(Name = "Message")]
        [Required(ErrorMessage = "You have to write something!")]
        [StringLength(140, MinimumLength = 1, ErrorMessage = "There must be between 1 and 140 characters in your message.")]
        public string TextContent { get; set; }
    }
}