﻿using System;

namespace HandmadeServer.ByTheCakeApplication.ViewModels.Account
{
    public class ProfileViewModel
    {
        public string Username { get; set; }

        public DateTime RegistrationDate { get; set; }

        public int TotalOrders { get; set; }
    }
}
