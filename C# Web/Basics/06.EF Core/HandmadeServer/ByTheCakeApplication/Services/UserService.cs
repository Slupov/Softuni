﻿using System;
using System.Linq;
using HandmadeServer.ByTheCakeApplication.Data;
using HandmadeServer.ByTheCakeApplication.Data.Models;
using HandmadeServer.ByTheCakeApplication.ViewModels.Account;

namespace HandmadeServer.ByTheCakeApplication.Services
{
    public class UserService : IUserService
    {
        public bool Create(string username, string password)
        {
            using (var db = new ByTheCakeDbContext())
            {
                if (db.Users.Any(u => u.Username == username))
                {
                    return false;
                }

                var user = new User
                {
                    Username = username,
                    Password = password,
                    RegistrationDate = DateTime.UtcNow
                };

                db.Add(user);
                db.SaveChanges();

                return true;
            }
        }

        public bool Find(string username, string password)
        {
            using (var db = new ByTheCakeDbContext())
            {
                return db
                    .Users
                    .Any(u => u.Username == username && u.Password == password);
            }
        }

        public ProfileViewModel Profile(string username)
        {
            using (var db = new ByTheCakeDbContext())
            {
                return db
                    .Users
                    .Where(u => u.Username == username)
                    .Select(u => new ProfileViewModel
                    {
                        Username = u.Username,
                        RegistrationDate = u.RegistrationDate,
                        TotalOrders = u.Orders.Count()
                    })
                    .FirstOrDefault();
            }
        }

        public int? GetUserId(string username)
        {
            using (var db = new ByTheCakeDbContext())
            {
                var id = db
                    .Users
                    .Where(u => u.Username == username)
                    .Select(u => u.Id)
                    .FirstOrDefault();

                return id != 0 ? (int?)id : null;
            }
        }
    }
}
