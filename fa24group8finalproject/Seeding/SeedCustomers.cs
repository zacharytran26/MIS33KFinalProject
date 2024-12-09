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

    public static class SeedingCustomers

    {

        public static async Task<IdentityResult> SeedCustomers(UserManager<AppUser> userManager, AppDbContext context)

        {

            List<AddUserModel> Customers = new List<AddUserModel>();


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "cbaker@freezing.co.uk",

                    UserName = "cbaker@freezing.co.uk",

                    FirstName = "Christopher",

                    MI = "L",

                    LastName = "Baker",

                    StreetAddress = "1245 Lake America Blvd.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78733",

                    PhoneNumber = "5125595133",

                    Birthday = new DateTime(1968, 11, 28),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "hellothere",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "mb@puppy.com",

                    UserName = "mb@puppy.com",

                    FirstName = "Michelle",

                    MI = "Q",

                    LastName = "Bradicus",

                    StreetAddress = "1300 Small Pine Lane",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78261",

                    PhoneNumber = "2102702860",

                    Birthday = new DateTime(1988, 2, 7),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "555533",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "fd@puppy.com",

                    UserName = "fd@puppy.com",

                    FirstName = "Franco",

                    MI = "V",

                    LastName = "Broccoli",

                    StreetAddress = "62 Cookie Rd",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "77019",

                    PhoneNumber = "8175683686",

                    Birthday = new DateTime(1999, 11, 7),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "666645",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "wendy@puppy.com",

                    UserName = "wendy@puppy.com",

                    FirstName = "Wendy",

                    MI = "L",

                    LastName = "Charile",

                    StreetAddress = "202 Bellmoth Hall",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78713",

                    PhoneNumber = "5125967209",

                    Birthday = new DateTime(1992, 10, 27),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "Kansas",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "limchou@puppy.com",

                    UserName = "limchou@puppy.com",

                    FirstName = "Lim",

                    MI = "Q",

                    LastName = "Chou",

                    StreetAddress = "1600 Barbara Lane",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78266",

                    PhoneNumber = "2107748586",

                    Birthday = new DateTime(1961, 11, 11),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "Rockwall",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "444444.Dave@aool.com",

                    UserName = "444444.Dave@aool.com",

                    FirstName = "Shan",

                    MI = "D",

                    LastName = "Dave",

                    StreetAddress = "234 Puppy Circle",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "75208",

                    PhoneNumber = "2142667242",

                    Birthday = new DateTime(1972, 12, 19),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "444444",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "louann@puppy.com",

                    UserName = "louann@puppy.com",

                    FirstName = "Lou Ann",

                    MI = "K",

                    LastName = "Feeley",

                    StreetAddress = "700 S 9th StreetAddress W",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "77010",

                    PhoneNumber = "8172580736",

                    Birthday = new DateTime(1958, 8, 1),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "longhorns",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "tfreeley@puppy.com",

                    UserName = "tfreeley@puppy.com",

                    FirstName = "Tesa",

                    MI = "P",

                    LastName = "Freeley",

                    StreetAddress = "4334 Meanview Ave.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "77009",

                    PhoneNumber = "8173279674",

                    Birthday = new DateTime(2001, 7, 12),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "puppies",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "mgar@puppy.com",

                    UserName = "mgar@puppy.com",

                    FirstName = "Margaret",

                    MI = "L",

                    LastName = "Garcia",

                    StreetAddress = "594 Puppyview",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "77003",

                    PhoneNumber = "8176617531",

                    Birthday = new DateTime(1956, 11, 17),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "horses",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "chaley@thug.com",

                    UserName = "chaley@thug.com",

                    FirstName = "Charles",

                    MI = "E",

                    LastName = "Harley",

                    StreetAddress = "One Ranger Pkwy",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "75261",

                    PhoneNumber = "2148499570",

                    Birthday = new DateTime(1998, 5, 29),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "mycats",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "wjhearniii@umch.edu",

                    UserName = "wjhearniii@umch.edu",

                    FirstName = "John",

                    MI = "B",

                    LastName = "Hearn",

                    StreetAddress = "4445 South First",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "75237",

                    PhoneNumber = "2148989608",

                    Birthday = new DateTime(1983, 12, 29),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "posicles",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "hicks43@puppy.com",

                    UserName = "hicks43@puppy.com",

                    FirstName = "Mark",

                    MI = "J",

                    LastName = "Hicks",

                    StreetAddress = "32 NE Mark Ln., Ste 910",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78239",

                    PhoneNumber = "2105812952",

                    Birthday = new DateTime(1989, 12, 16),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "guac45",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "bradsingram@mall.utexas.edu",

                    UserName = "bradsingram@mall.utexas.edu",

                    FirstName = "Brad",

                    MI = "S",

                    LastName = "Ingram",

                    StreetAddress = "6548 La Chess St.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78736",

                    PhoneNumber = "5124702808",

                    Birthday = new DateTime(1958, 9, 18),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "father",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "father.Ingram@aool.com",

                    UserName = "father.Ingram@aool.com",

                    FirstName = "Todd",

                    MI = "L",

                    LastName = "Jacobs",

                    StreetAddress = "4564 Palm St.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78731",

                    PhoneNumber = "5124677352",

                    Birthday = new DateTime(1975, 12, 9),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "555897",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "victoria@puppy.com",

                    UserName = "victoria@puppy.com",

                    FirstName = "Victoria",

                    MI = "M",

                    LastName = "Lawrence",

                    StreetAddress = "6639 Butterfly Ln.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78761",

                    PhoneNumber = "5129481386",

                    Birthday = new DateTime(1981, 5, 29),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "something",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "lineback@flush.net",

                    UserName = "lineback@flush.net",

                    FirstName = "Brad",

                    MI = "W",

                    LastName = "Lineback",

                    StreetAddress = "1300 Pirateland St",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78293",

                    PhoneNumber = "2102473963",

                    Birthday = new DateTime(1973, 5, 19),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "treelover",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "elowe@netscrape.net",

                    UserName = "elowe@netscrape.net",

                    FirstName = "Evan",

                    MI = "S",

                    LastName = "Lowe",

                    StreetAddress = "3201 Pineapple Drive",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78279",

                    PhoneNumber = "2105368614",

                    Birthday = new DateTime(1993, 6, 7),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "headear",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "luce_chuck@puppy.com",

                    UserName = "luce_chuck@puppy.com",

                    FirstName = "Chuck",

                    MI = "B",

                    LastName = "Luce",

                    StreetAddress = "2345 Silent Clouds",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78268",

                    PhoneNumber = "2107007535",

                    Birthday = new DateTime(1995, 6, 11),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "gooseyloosey",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "mackcloud@pimpdaddy.com",

                    UserName = "mackcloud@pimpdaddy.com",

                    FirstName = "Jennifer",

                    MI = "D",

                    LastName = "MacLeod",

                    StreetAddress = "2504 Far East Blvd.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78731",

                    PhoneNumber = "5124772125",

                    Birthday = new DateTime(1965, 10, 11),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "rainyday",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "liz@puppy.com",

                    UserName = "liz@puppy.com",

                    FirstName = "Elizabeth",

                    MI = "P",

                    LastName = "Markham",

                    StreetAddress = "7861 Chevy Mace Rd",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78732",

                    PhoneNumber = "5124603832",

                    Birthday = new DateTime(1989, 6, 18),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "ember22",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "mclarence@puppy.com",

                    UserName = "mclarence@puppy.com",

                    FirstName = "Clarence",

                    MI = "A",

                    LastName = "Martin",

                    StreetAddress = "87 Alcedo St.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "77045",

                    PhoneNumber = "8174979188",

                    Birthday = new DateTime(1984, 4, 28),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "lamemartin",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "lamemartin.Martin@aool.com",

                    UserName = "lamemartin.Martin@aool.com",

                    FirstName = "Gregory",

                    MI = "R",

                    LastName = "Martinez",

                    StreetAddress = "8295 Moon Blvd.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "77030",

                    PhoneNumber = "8178770705",

                    Birthday = new DateTime(1981, 12, 27),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "gregory",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "cmiller@mapster.com",

                    UserName = "cmiller@mapster.com",

                    FirstName = "Charles",

                    MI = "R",

                    LastName = "Miller",

                    StreetAddress = "8962 Side St.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "77031",

                    PhoneNumber = "8177482602",

                    Birthday = new DateTime(1987, 5, 5),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "mucky44",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "nelson.Kelly@puppy.com",

                    UserName = "nelson.Kelly@puppy.com",

                    FirstName = "Kelly",

                    MI = "T",

                    LastName = "Nelson",

                    StreetAddress = "2601 Green River",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78703",

                    PhoneNumber = "5122950953",

                    Birthday = new DateTime(1969, 8, 3),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "Tree34",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "jojoe@puppy.com",

                    UserName = "jojoe@puppy.com",

                    FirstName = "Joe",

                    MI = "C",

                    LastName = "Nguyen",

                    StreetAddress = "1249 4th NW St.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "75238",

                    PhoneNumber = "2143149884",

                    Birthday = new DateTime(1956, 2, 6),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "jvb485bg",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "orielly@foxnets.com",

                    UserName = "orielly@foxnets.com",

                    FirstName = "Bill",

                    MI = "T",

                    LastName = "O'Reilly",

                    StreetAddress = "8800 Gringo Drive",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78260",

                    PhoneNumber = "2103474912",

                    Birthday = new DateTime(1989, 3, 14),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "Bobbygirl",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "or@puppy.com",

                    UserName = "or@puppy.com",

                    FirstName = "Anka",

                    MI = "L",

                    LastName = "Radkovich",

                    StreetAddress = "1300 Freaky",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "75260",

                    PhoneNumber = "2142369553",

                    Birthday = new DateTime(1952, 10, 26),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "radioactive",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "megrhodes@freezing.co.uk",

                    UserName = "megrhodes@freezing.co.uk",

                    FirstName = "Megan",

                    MI = "C",

                    LastName = "Rhodes",

                    StreetAddress = "4587 Rightfield Rd.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78707",

                    PhoneNumber = "5123768733",

                    Birthday = new DateTime(1958, 3, 18),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "gopigs",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "erynrice@puppy.com",

                    UserName = "erynrice@puppy.com",

                    FirstName = "Eryn",

                    MI = "M",

                    LastName = "Rice",

                    StreetAddress = "3405 Rio Small",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78705",

                    PhoneNumber = "5123900644",

                    Birthday = new DateTime(2000, 11, 2),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "iloveme",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "jorge@hootmail.com",

                    UserName = "jorge@hootmail.com",

                    FirstName = "Jorge",

                    MI = "",

                    LastName = "Rodriguez",

                    StreetAddress = "6788 Cotten StreetAddress",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "77057",

                    PhoneNumber = "8178928361",

                    Birthday = new DateTime(1979, 1, 1),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "565656",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "ra@aoo.com",

                    UserName = "ra@aoo.com",

                    FirstName = "Allen",

                    MI = "B",

                    LastName = "Rogers",

                    StreetAddress = "4965 Rabbit Hill",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78732",

                    PhoneNumber = "5128776930",

                    Birthday = new DateTime(2000, 3, 12),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "treeman",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "o_st-jean@home.com",

                    UserName = "o_st-jean@home.com",

                    FirstName = "Olivier",

                    MI = "M",

                    LastName = "Saint-Jean",

                    StreetAddress = "255 Slap Dr.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78292",

                    PhoneNumber = "2104169665",

                    Birthday = new DateTime(1997, 5, 1),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "55htrq",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "ss34@puppy.com",

                    UserName = "ss34@puppy.com",

                    FirstName = "Sarah",

                    MI = "J",

                    LastName = "Saunders",

                    StreetAddress = "332 Fish C",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78705",

                    PhoneNumber = "5123521797",

                    Birthday = new DateTime(1994, 5, 31),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "leaves",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "willsheff@email.com",

                    UserName = "willsheff@email.com",

                    FirstName = "William",

                    MI = "T",

                    LastName = "Sewell",

                    StreetAddress = "2365 34st St.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78709",

                    PhoneNumber = "5124534071",

                    Birthday = new DateTime(1951, 12, 10),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "borbj44",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "sheff44@puppy.com",

                    UserName = "sheff44@puppy.com",

                    FirstName = "Martin",

                    MI = "J",

                    LastName = "Sheffield",

                    StreetAddress = "3886 Road A",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78705",

                    PhoneNumber = "5125503154",

                    Birthday = new DateTime(1993, 7, 2),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "ldiul485",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "johnsmith187@puppy.com",

                    UserName = "johnsmith187@puppy.com",

                    FirstName = "John",

                    MI = "A",

                    LastName = "Smith",

                    StreetAddress = "23 Known Forge Dr.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78280",

                    PhoneNumber = "2108345875",

                    Birthday = new DateTime(1985, 6, 13),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "kribv75",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "jeff@puppy.com",

                    UserName = "jeff@puppy.com",

                    FirstName = "Jeffrey",

                    MI = "T",

                    LastName = "Stark",

                    StreetAddress = "337 40th St.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78705",

                    PhoneNumber = "5127002600",

                    Birthday = new DateTime(1974, 5, 2),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "jeffery",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "dustroud@mail.com",

                    UserName = "dustroud@mail.com",

                    FirstName = "Dustin",

                    MI = "P",

                    LastName = "Stroud",

                    StreetAddress = "1212 Henrietta Rd",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "75221",

                    PhoneNumber = "2142370654",

                    Birthday = new DateTime(1974, 7, 14),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "klavjkb48",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "eric_stuart@puppy.com",

                    UserName = "eric_stuart@puppy.com",

                    FirstName = "Eric",

                    MI = "D",

                    LastName = "Stuart",

                    StreetAddress = "5576 Big Ring",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78746",

                    PhoneNumber = "5128202322",

                    Birthday = new DateTime(1968, 6, 17),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "vkb451",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "peterstump@hootmail.com",

                    UserName = "peterstump@hootmail.com",

                    FirstName = "Peter",

                    MI = "L",

                    LastName = "Stump",

                    StreetAddress = "1300 Kellen Square",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "77018",

                    PhoneNumber = "8174584890",

                    Birthday = new DateTime(2001, 7, 23),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "kdsiu4",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "tanner@puppy.com",

                    UserName = "tanner@puppy.com",

                    FirstName = "Jeremy",

                    MI = "S",

                    LastName = "Tanner",

                    StreetAddress = "4347 Palmstead",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "77044",

                    PhoneNumber = "8174614916",

                    Birthday = new DateTime(1973, 12, 28),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "klrfbj45",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "taylordjay@puppy.com",

                    UserName = "taylordjay@puppy.com",

                    FirstName = "Allison",

                    MI = "R",

                    LastName = "Taylor",

                    StreetAddress = "467 Nueces St.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78705",

                    PhoneNumber = "5124772439",

                    Birthday = new DateTime(1999, 9, 30),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "lraggrhb854",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "lraggrhb854.Taylor@aool.com",

                    UserName = "lraggrhb854.Taylor@aool.com",

                    FirstName = "Rachel",

                    MI = "K",

                    LastName = "Taylor",

                    StreetAddress = "345 Shortview Dr.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78705",

                    PhoneNumber = "5124536618",

                    Birthday = new DateTime(1956, 2, 24),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "alsuib95",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "tee_frank@hootmail.com",

                    UserName = "tee_frank@hootmail.com",

                    FirstName = "Frank",

                    MI = "J",

                    LastName = "Tee",

                    StreetAddress = "5590 Big Dr.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "77004",

                    PhoneNumber = "8178789530",

                    Birthday = new DateTime(1964, 11, 11),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "kd1734",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "tuck33@puppy.com",

                    UserName = "tuck33@puppy.com",

                    FirstName = "Clent",

                    MI = "J",

                    LastName = "Tucker",

                    StreetAddress = "3132 Main St.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "75315",

                    PhoneNumber = "2148495141",

                    Birthday = new DateTime(1990, 6, 25),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "kjdb983",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "avelasco@puppy.com",

                    UserName = "avelasco@puppy.com",

                    FirstName = "Allen",

                    MI = "G",

                    LastName = "Velasco",

                    StreetAddress = "634 W. 4th",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "75207",

                    PhoneNumber = "2144009625",

                    Birthday = new DateTime(1966, 12, 13),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "odrb02",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "westj@pioneer.net",

                    UserName = "westj@pioneer.net",

                    FirstName = "Jake",

                    MI = "T",

                    LastName = "West",

                    StreetAddress = "RR 3244",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "75323",

                    PhoneNumber = "2148499231",

                    Birthday = new DateTime(1968, 2, 6),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "kndl847",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "louielouie@puppy.com",

                    UserName = "louielouie@puppy.com",

                    FirstName = "Louis",

                    MI = "L",

                    LastName = "Winthorpe",

                    StreetAddress = "2500 Madre Blvd",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78746",

                    PhoneNumber = "2145674085",

                    Birthday = new DateTime(1961, 7, 23),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "lb2394",

                RoleName = "Customer"

            });


            Customers.Add(new AddUserModel()

            {

                User = new AppUser()

                {

                    Email = "rwood@voyager.net",

                    UserName = "rwood@voyager.net",

                    FirstName = "Reagan",

                    MI = "B",

                    LastName = "Wood",

                    StreetAddress = "447 Westlake Dr.",

                    State = StateList.TX,

                    City = " ",

                    ZipCode = "78746",

                    PhoneNumber = "5124569229",

                    Birthday = new DateTime(1988, 10, 24),

                    Role = "Customer",

                    IsActive = aStatus.Active

                },

                Password = "drai494",

                RoleName = "Customer"

            });


            IdentityResult result = new IdentityResult();

            try

            {

                foreach (AddUserModel customerToAdd in Customers)

                {

                    result = await Utilities.AddUser.AddUserWithRoleAsync(customerToAdd, userManager, context);

                }

            }

            catch (Exception ex)

            {

                throw new Exception("There was a problem adding customers", ex);

            }

            return result;

        }

    }

}

