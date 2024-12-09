
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
    public static class SeedingHost
    {
        public static async Task<IdentityResult> SeedHosts(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels 
            List<AddUserModel> Hosts = new List<AddUserModel>();

            Hosts.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "jacobs@yahoo.com",
                    UserName = "jacobs@yahoo.com",
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    MI = "L",
                    ZipCode = "77003",
                    PhoneNumber = "8176663948",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "4564 Elm St.",
                    Birthday = new DateTime(1978, 1, 29),
                    Role = "Host",
                    IsActive = aStatus.Active
                },
                Password = "tj2245",
                RoleName = "Host"
            });

            Hosts.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "rice@yahoo.com",
                    UserName = "rice@yahoo.com",
                    FirstName = "Eryn",
                    LastName = "Rice",
                    MI = "M",
                    ZipCode = "75261",
                    PhoneNumber = "2148545987",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "3405 Rio Grande",
                    Birthday = new DateTime(2003, 6, 11),
                    Role = "Host",
                    IsActive = aStatus.Active
                },
                Password = "ricearoni",
                RoleName = "Host"
            });

            Hosts.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "ingram@gmail.com",
                    UserName = "ingram@gmail.com",
                    FirstName = "John",
                    LastName = "Ingram",
                    MI = "R",
                    ZipCode = "78705",
                    PhoneNumber = "5127049017",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "6548 La Posada Ct.",
                    Birthday = new DateTime(1980, 6, 25),
                    Role = "Host",
                    IsActive = aStatus.Active
                },
                Password = "ingram68",
                RoleName = "Host"
            });

            Hosts.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "martinez@aol.com",
                    UserName = "martinez@aol.com",
                    FirstName = "Paul",
                    LastName = "Martinez",
                    MI = "G",
                    ZipCode = "78239",
                    PhoneNumber = "2105859369",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "8295 Sunset Blvd.",
                    Birthday = new DateTime(1969, 6, 25),
                    Role = "Host",
                    IsActive = aStatus.Active
                },
                Password = "party1",
                RoleName = "Host"
            });

            Hosts.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "tanner@utexas.edu",
                    UserName = "tanner@utexas.edu",
                    FirstName = "Jared",
                    LastName = "Tanner",
                    MI = "F",
                    ZipCode = "78761",
                    PhoneNumber = "5129527803",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "4347 Almstead",
                    Birthday = new DateTime(1979, 6, 2),
                    Role = "Host",
                    IsActive = aStatus.Active
                },
                Password = "sandman",
                RoleName = "Host"
            });

            Hosts.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "chung@yahoo.com",
                    UserName = "chung@yahoo.com",
                    FirstName = "Lauren",
                    LastName = "Chung",
                    MI = "R",
                    ZipCode = "78268",
                    PhoneNumber = "2107053952",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "234 RR 12",
                    Birthday = new DateTime(1976, 3, 24),
                    Role = "Host",
                    IsActive = aStatus.Active
                },
                Password = "listen",
                RoleName = "Host"
            });

            Hosts.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "loter@yahoo.com",
                    UserName = "loter@yahoo.com",
                    FirstName = "Wandavison",
                    LastName = "Loter",
                    MI = "T",
                    ZipCode = "78732",
                    PhoneNumber = "5124650249",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "3453 RR 3235",
                    Birthday = new DateTime(1966, 9, 23),
                    Role = "Host",
                    IsActive = aStatus.Active
                },
                Password = "pottery",
                RoleName = "Host"
            });

            Hosts.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "morales@aol.com",
                    UserName = "morales@aol.com",
                    FirstName = "Heather",
                    LastName = "Morales",
                    MI = "R",
                    ZipCode = "77031",
                    PhoneNumber = "8177529019",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "4501 RR 140",
                    Birthday = new DateTime(1971, 1, 16),
                    Role = "Host",
                    IsActive = aStatus.Active
                },
                Password = "heckin",
                RoleName = "Host"
            });

            Hosts.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "rankin@yahoo.com",
                    UserName = "rankin@yahoo.com",
                    FirstName = "Martin",
                    LastName = "Rankin",
                    MI = "P",
                    ZipCode = "78703",
                    PhoneNumber = "5122997370",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "340 Second St",
                    Birthday = new DateTime(1961, 5, 16),
                    Role = "Host",
                    IsActive = aStatus.Active
                },
                Password = "rankmark",
                RoleName = "Host"
            });

            Hosts.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    Email = "gonzalez@aol.com",
                    UserName = "gonzalez@aol.com",
                    FirstName = "Garth",
                    LastName = "Gonzalez",
                    MI = "R",
                    ZipCode = "75260",
                    PhoneNumber = "2142415970",
                    State = StateList.AL,
                    City = "",
                    StreetAddress = "103 Manor Rd",
                    Birthday = new DateTime(1993, 12, 10),
                    Role = "Host",
                    IsActive = aStatus.Active
                },
                Password = "gg2017",
                RoleName = "Host"
            });

            //Create a flag so we will know which record is causing problems 
            String strHostEmail = "Begin";
            //create an identity result 
            IdentityResult result = new IdentityResult();
            //call the method to seed the user 
            try
            {
                //loop through each of the host in the list 
                foreach (AddUserModel hostToAdd in Hosts)
                {
                    //set the flag to the current title to help with debugging 
                    strHostEmail = hostToAdd.User.Email;
                    result = await Utilities.AddUser.AddUserWithRoleAsync(hostToAdd, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: "
                    + strHostEmail, ex);
            }
            return result;
        }
    }
}
