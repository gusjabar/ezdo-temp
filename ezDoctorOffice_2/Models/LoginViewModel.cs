using System;
using System.ComponentModel.DataAnnotations;

namespace ezDoctorOffice_2.Models
{
    public class LoginViewModel
    {
        public LoginViewModel()
        { }
        [Required]
        public string UserName
        {
            get;
            set;
        }
        [Required]
        public string Password
        {
            get;
            set;
        }
    
    }
}
