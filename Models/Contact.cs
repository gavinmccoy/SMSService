using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMSService.Models
{
    
    public class Contact
    {
        // default constructor
        public Contact() { }

        // ID property for Entity Framework integration
        public int ContactId { get; set; }

        // Validation for CRUD use

        // First Name property for first name of contact with validation
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You must enter a first name.")]
        [StringLength(20)]
        public string FirstName { get; set; }

        // Second Name property for second name of contact with validation
        [Display(Name = "Second Name")]
        [Required(ErrorMessage = "You must enter a second name.")]
        [StringLength(20)]
        public string SecondName { get; set; }

        // Area Code property for area code of contact with validation
        [Display(Name = "Area Code")]
        [Required(ErrorMessage = "You must enter a valid area code e.g. 085")]
        [RegularExpression("^08[3-9]$", ErrorMessage = "Please enter a valid 3 digit area code")]
        public string AreaCode { get; set; }

        // Phone Number property for phone number of contact with validation
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "You must enter a valid phone number e.g. 1234567")]
        // [Range(0000001, 9999999, ErrorMessage = "Must be a valid phone number.")]
        [RegularExpression("^[0-9][0-9][0-9][0-9][0-9][0-9][0-9]$", ErrorMessage = "Please enter a valid 7 digit phone number")]
        public string PhoneNumber { get; set; }

        // parameterized constructor
        public Contact(string FirstName, string SecondName, string AreaCode, string PhoneNumber)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.AreaCode = AreaCode;
            this.PhoneNumber = PhoneNumber;
        }

        
    }
}