using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using fa24group8finalproject.Models;
using fa24group8finalproject.DAL;
using fa24group8finalproject.Utilities;

namespace fa24group8finalproject.Seeding
{
    public static class SeedUsers
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {
            if (userManager == null || context == null)
                throw new ArgumentNullException("Dependencies are not initialized.");

            List<AddUserModel> allUsers = new List<AddUserModel>
            {
                new AddUserModel
                {
                    User = new AppUser
                    {
                        UserName = "admin@example.com",
                        Email = "admin@example.com",
                        PhoneNumber = "(512)555-1234",
                        FirstName = "Admin",
                        MI = "A",
                        LastName = "Admin",
                        StreetAddress = "Admin street",
                        City = "Admin city",
                        State = StateList.TX,
                        ZipCode = "12345",
                        IsActive = aStatus.Active,
                        Role = "Admin"
                    },
                    Password = "Abc123!",
                    RoleName = "Admin"
                },
                new AddUserModel
                {
                    User = new AppUser
                    {
                        UserName = "bevo@example.com",
                        Email = "bevo@example.com",
                        PhoneNumber = "(512)555-5555",
                        FirstName = "Bevo",
                        MI = "B",
                        LastName = "Longhorn",
                        StreetAddress = "Bevo street",
                        City = "Bevo city",
                        State = StateList.TX,
                        ZipCode = "12345",
                        Role = "Customer",
                        IsActive = aStatus.Active
                    },
                    Password = "Password123!",
                    RoleName = "Customer"
                },
                new AddUserModel
                {
                    User = new AppUser
                    {
                        UserName = "host@example.com",
                        Email = "host@example.com",
                        PhoneNumber = "(512)555-1234",
                        FirstName = "Host",
                        MI = "H",
                        LastName = "Host",
                        StreetAddress = "Host street",
                        City = "Host city",
                        State = StateList.TX,
                        ZipCode = "12345",
                        IsActive = aStatus.Active,
                        Role = "Host"
                    },
                    Password = "Abc123!",
                    RoleName = "Host"
                }
            };

            string errorFlag = "Start";
            IdentityResult result = null;

            try
            {
                foreach (AddUserModel userModel in allUsers)
                {
                    errorFlag = userModel.User.Email;
                    result = await Utilities.AddUser.AddUserWithRoleAsync(userModel, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding user with email {errorFlag}", ex);
            }

            return result ?? IdentityResult.Failed();
        }
    }
}
