using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorAsdrubal.Shared
{
    public class Person
    {
        public int Id { get; set; }


        public string Title { get; set; }

        [Required(ErrorMessage = "FirstName is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of Birth is Required")]
        public DateTime Birth { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage ="Email must be valid")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password is Required")]
        [MinLength(6, ErrorMessage = "Password is too short.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [MinLength(6, ErrorMessage = "Password is too short.")]
        [Compare(nameof(Password), ErrorMessage ="Password and Confirm Password must match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "AcepptTerms must be accepted")]
        public bool AcceptTerms { get; set; }


    }
}
