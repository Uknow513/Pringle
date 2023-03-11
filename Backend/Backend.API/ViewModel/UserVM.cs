﻿using Backend.Data.Entities;

namespace Backend.API.ViewModel
{
    public class SignUpVM
    {
        public string? UserEmail { get; set; }

        public string? Password { get; set;}
    }

    public class LoginVM
    {
        public string? UserEmail { get; set;}
        public string? Password { get; set;}
    }

    public partial class ChangePasswordVM
    {
        public string ? UserEmail { get; set; }

        public string ? OldPassword { get; set;}
        
        public string? NewPassword { get; set;}
    }
}
