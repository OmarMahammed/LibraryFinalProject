﻿using System.ComponentModel.DataAnnotations;

namespace LibraryFinalProject.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="UserName is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}