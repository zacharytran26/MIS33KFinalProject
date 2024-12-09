

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fa24group8finalproject.DAL;
using fa24group8finalproject.Models;
using fa24group8finalproject.Utilities;
using Microsoft.AspNetCore.Identity;

namespace fa24group8finalproject.Seeding
{
    public static class SeedingAdmin
    {
        public static async Task<IdentityResult> SeedAdmins(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels 
            List<AddUserModel> Admins = new List<AddUserModel>();

            Admins.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "taylor@bevobnb.com",
                    UserName = "taylor@bevobnb.com",
                    FirstName = "Albert",
                    LastName = "Taylor",
                    MI = "F",
                    ZipCode = "75237",
                    PhoneNumber = "2149036025",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "467 Nueces St.",
                    Birthday = new DateTime(1954, 8, 14),
                    Role = "Admin",
                    IsActive = aStatus.Active
                },
                Password = "TRY563",
                RoleName = "Admin"
            });

            Admins.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "sheffield@bevobnb.com",
                    UserName = "sheffield@bevobnb.com",
                    FirstName = "Molly",
                    LastName = "Sheffield",
                    MI = "R",
                    ZipCode = "78736",
                    PhoneNumber = "5124749225",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "3886 Avenue A",
                    Birthday = new DateTime(1986, 8, 27),
                    Role = "Admin",
                    IsActive = aStatus.Active
                },
                Password = "longsnores",
                RoleName = "Admin"
            });

            Admins.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "macleod@bevobnb.com",
                    UserName = "macleod@bevobnb.com",
                    FirstName = "Jenny",
                    LastName = "MacLeod",
                    MI = "I",
                    ZipCode = "78731",
                    PhoneNumber = "5124723769",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "2504 Far West Blvd.",
                    Birthday = new DateTime(1984, 12, 5),
                    Role = "Admin",
                    IsActive = aStatus.Active
                },
                Password = "kittys",
                RoleName = "Admin"
            });

            Admins.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "rhodes@bevobnb.com",
                    UserName = "rhodes@bevobnb.com",
                    FirstName = "Michelle",
                    LastName = "Rhodes",
                    MI = "N",
                    ZipCode = "78293",
                    PhoneNumber = "2102520380",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "4587 Enfield Rd.",
                    Birthday = new DateTime(1972, 7, 2),
                    Role = "Admin",
                    IsActive = aStatus.Active
                },
                Password = "puppies",
                RoleName = "Admin"
            });

            Admins.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "stuart@bevobnb.com",
                    UserName = "stuart@bevobnb.com",
                    FirstName = "Evan",
                    LastName = "Stuart",
                    MI = "Q",
                    ZipCode = "78279",
                    PhoneNumber = "2105415031",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "5576 Toro Ring",
                    Birthday = new DateTime(1984, 4, 17),
                    Role = "Admin",
                    IsActive = aStatus.Active
                },
                Password = "coolboi",
                RoleName = "Admin"
            });

            Admins.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "swanson@bevobnb.com",
                    UserName = "swanson@bevobnb.com",
                    FirstName = "Ron",
                    LastName = "Swanson",
                    MI = "P",
                    ZipCode = "78731",
                    PhoneNumber = "5124818542",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "245 River Rd",
                    Birthday = new DateTime(1991, 7, 25),
                    Role = "Admin",
                    IsActive = aStatus.Active
                },
                Password = "swanbong",
                RoleName = "Admin"
            });

            Admins.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "white@bevobnb.com",
                    UserName = "white@bevobnb.com",
                    FirstName = "Jabriel",
                    LastName = "White",
                    MI = "M",
                    ZipCode = "77045",
                    PhoneNumber = "8175025605",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "12 Valley View",
                    Birthday = new DateTime(1986, 3, 17),
                    Role = "Admin",
                    IsActive = aStatus.Active
                },
                Password = "456789",
                RoleName = "Admin"
            });

            Admins.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "montgomery@bevobnb.com",
                    UserName = "montgomery@bevobnb.com",
                    FirstName = "Washington",
                    LastName = "Montgomery",
                    MI = "X",
                    ZipCode = "77030",
                    PhoneNumber = "8178817122",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "210 Blanco Dr",
                    Birthday = new DateTime(1961, 5, 4),
                    Role = "Admin",
                    IsActive = aStatus.Active
                },
                Password = "python4",
                RoleName = "Admin"
            });

            Admins.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "walker@bevobnb.com",
                    UserName = "walker@bevobnb.com",
                    FirstName = "Lisa",
                    LastName = "Walker",
                    MI = "O",
                    ZipCode = "75238",
                    PhoneNumber = "2143196301",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "9 Bison Circle",
                    Birthday = new DateTime(2003, 4, 18),
                    Role = "Admin",
                    IsActive = aStatus.Active
                },
                Password = "walkameter",
                RoleName = "Admin"
            });

            Admins.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "chang@bevobnb.com",
                    UserName = "chang@bevobnb.com",
                    FirstName = "Gregory",
                    LastName = "Chang",
                    MI = "J",
                    ZipCode = "78260",
                    PhoneNumber = "2103521329",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "9003 Joshua St",
                    Birthday = new DateTime(1958, 4, 26),
                    Role = "Admin",
                    IsActive = aStatus.Active
                },
                Password = "pupgang",
                RoleName = "Admin"
            });

            Admins.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "derek@bevobnb.com",
                    UserName = "derek@bevobnb.com",
                    FirstName = "Derek",
                    LastName = "Dreibrodt",
                    MI = "X",
                    ZipCode = "78705",
                    PhoneNumber = "5125556789",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "4 Privet Dr",
                    Birthday = new DateTime(2001, 1, 1),
                    Role = "Admin",
                    IsActive = aStatus.Active
                },
                Password = "2cool4u",
                RoleName = "Admin"
            });

            Admins.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "rester@bevobnb.com",
                    UserName = "rester@bevobnb.com",
                    FirstName = "Amy",
                    LastName = "Rester",
                    MI = "K",
                    ZipCode = "78705",
                    PhoneNumber = "2103521329",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "2110 Speedway",
                    Birthday = new DateTime(2000, 1, 1),
                    Role = "Admin",
                    IsActive = aStatus.Active
                },
                Password = "KIzGreat",
                RoleName = "Admin"
            });

            //Create a flag so we will know which record is causing problems 
            String strAdminEmail = "Begin";
            //create an identity result 
            IdentityResult result = new IdentityResult();
            //call the method to seed the user 
            try
            {
                //loop through each of the admins in the list 
                foreach (AddUserModel adminToAdd in Admins)
                {
                    //set the flag to the current title to help with debugging 
                    strAdminEmail = adminToAdd.User.Email;
                    result = await Utilities.AddUser.AddUserWithRoleAsync(adminToAdd, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: "
                    + strAdminEmail, ex);
            }
            return result;
        }
    }
}
