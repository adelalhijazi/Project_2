﻿using System.ComponentModel.DataAnnotations;

namespace Education.Areas.Admin.ViewModels
{
    public class Signin
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
