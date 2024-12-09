
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fa24group8finalproject.DAL;
using fa24group8finalproject.Models;

namespace fa24group8finalproject.Seeding
{
    public static class SeedingProperties
    {
        public static async Task SeedProperties(AppDbContext context)
        {
            if (context.Properties.Any())
            {
                Console.WriteLine("Properties already exist in the database. Seeding skipped.");
                return;
            }

            List<Property> Properties = new List<Property>();

            // Add Property p3001
            Property p3001 = new Property()
            {
                PropertyNumber = 3001,
                ZipCode = "72227",
                State = StateList.PA,
                StreetAddress = "8714 Mann Plaza",
                AptNum = null,
                City = "Lisaside",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 171.57m,
                PricePerWeekday = 152.68m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 8.88m,
                NumberOfBeds = 5,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3001.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3001);

            // Add Property p3002
            Property p3002 = new Property()
            {
                PropertyNumber = 3002,
                ZipCode = "05565",
                State = StateList.FL,
                StreetAddress = "96593 White View Apt. 094",
                AptNum = null,
                City = "Jonesberg",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 148.15m,
                PricePerWeekday = 120.81m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 8.02m,
                NumberOfBeds = 7,
                NumberOfBaths = 8,
                NumberOfGuestsAllowed = 8,
                Status = pStatus.Active
            };
            p3002.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3002);

            // Add Property p3003
            Property p3003 = new Property()
            {
                PropertyNumber = 3003,
                ZipCode = "80819",
                State = StateList.MD,
                StreetAddress = "848 Melissa Springs Suite 947",
                AptNum = null,
                City = "Kellerstad",
                HostEmail = "rankin@yahoo.com",
                PricePerWeekend = 132.99m,
                PricePerWeekday = 127.96m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 13.37m,
                NumberOfBeds = 5,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 8,
                Status = pStatus.notActive
            };
            p3003.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3003);

            // Add Property p3004
            Property p3004 = new Property()
            {
                PropertyNumber = 3004,
                ZipCode = "79428",
                State = StateList.ND,
                StreetAddress = "30413 Norton Isle Suite 012",
                AptNum = null,
                City = "North Lisa",
                HostEmail = "rankin@yahoo.com",
                PricePerWeekend = 185.35m,
                PricePerWeekday = 80.2m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 5.57m,
                NumberOfBeds = 1,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 14,
                Status = pStatus.Active
            };
            p3004.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3004);

            // Add Property p3005
            Property p3005 = new Property()
            {
                PropertyNumber = 3005,
                ZipCode = "63315",
                State = StateList.DE,
                StreetAddress = "39916 Mitchell Crescent",
                AptNum = null,
                City = "New Andrewburgh",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 100.37m,
                PricePerWeekday = 170.25m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 18.64m,
                NumberOfBeds = 2,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 12,
                Status = pStatus.Active
            };
            p3005.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3005);

            // Add Property p3006
            Property p3006 = new Property()
            {
                PropertyNumber = 3006,
                ZipCode = "24135",
                State = StateList.NE,
                StreetAddress = "086 Mary Cliff",
                AptNum = null,
                City = "North Deborah",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 162.6m,
                PricePerWeekday = 220.24m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 10.83m,
                NumberOfBeds = 7,
                NumberOfBaths = 9,
                NumberOfGuestsAllowed = 2,
                Status = pStatus.Active
            };
            p3006.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3006);

            // Add Property p3007
            Property p3007 = new Property()
            {
                PropertyNumber = 3007,
                ZipCode = "58475",
                State = StateList.PA,
                StreetAddress = "91634 Strong Mountains Apt. 302",
                AptNum = null,
                City = "West Alyssa",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 204.87m,
                PricePerWeekday = 213.37m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 25.04m,
                NumberOfBeds = 1,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3007.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3007);

            // Add Property p3008
            Property p3008 = new Property()
            {
                PropertyNumber = 3008,
                ZipCode = "10865",
                State = StateList.WA,
                StreetAddress = "6984 Price Shoals",
                AptNum = null,
                City = "Erictown",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 140.89m,
                PricePerWeekday = 159.69m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 27.13m,
                NumberOfBeds = 2,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 8,
                Status = pStatus.Active
            };
            p3008.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3008);

            // Add Property p3009
            Property p3009 = new Property()
            {
                PropertyNumber = 3009,
                ZipCode = "51359",
                State = StateList.ME,
                StreetAddress = "423 Bell Heights",
                AptNum = null,
                City = "Brittanyberg",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 295.39m,
                PricePerWeekday = 200.73m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 14.91m,
                NumberOfBeds = 3,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 4,
                Status = pStatus.Active
            };
            p3009.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3009);

            // Add Property p3010
            Property p3010 = new Property()
            {
                PropertyNumber = 3010,
                ZipCode = "87296",
                State = StateList.WI,
                StreetAddress = "93523 Dana Lane",
                AptNum = null,
                City = "Johnsonshire",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 110.8m,
                PricePerWeekday = 170.39m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 8.67m,
                NumberOfBeds = 6,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.Active
            };
            p3010.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3010);

            // Add Property p3011
            Property p3011 = new Property()
            {
                PropertyNumber = 3011,
                ZipCode = "7035",
                State = StateList.NH,
                StreetAddress = "1427 Odonnell Rapids",
                AptNum = null,
                City = "North Troyport",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 126.29m,
                PricePerWeekday = 217.15m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 26.48m,
                NumberOfBeds = 3,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 14,
                Status = pStatus.Active
            };
            p3011.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3011);

            // Add Property p3012
            Property p3012 = new Property()
            {
                PropertyNumber = 3012,
                ZipCode = "37198",
                State = StateList.ME,
                StreetAddress = "81206 Stewart Forest Apt. 089",
                AptNum = null,
                City = "East Davidborough",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 293.26m,
                PricePerWeekday = 205.21m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 28.74m,
                NumberOfBeds = 3,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 8,
                Status = pStatus.Active
            };
            p3012.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3012);

            // Add Property p3013
            Property p3013 = new Property()
            {
                PropertyNumber = 3013,
                ZipCode = "85034",
                State = StateList.SD,
                StreetAddress = "76104 Marsh Crescent",
                AptNum = null,
                City = "Dennishaven",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 126.99m,
                PricePerWeekday = 123.13m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 18.73m,
                NumberOfBeds = 7,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 4,
                Status = pStatus.Active
            };
            p3013.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3013);

            // Add Property p3014
            Property p3014 = new Property()
            {
                PropertyNumber = 3014,
                ZipCode = "60619",
                State = StateList.SD,
                StreetAddress = "0003 Grant Lakes",
                AptNum = null,
                City = "Port Karafort",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 188.81m,
                PricePerWeekday = 89.19m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 11.98m,
                NumberOfBeds = 3,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 14,
                Status = pStatus.notActive
            };
            p3014.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3014);

            // Add Property p3015
            Property p3015 = new Property()
            {
                PropertyNumber = 3015,
                ZipCode = "21978",
                State = StateList.KY,
                StreetAddress = "236 Smith Drive Suite 555",
                AptNum = null,
                City = "West Kimberlyton",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 132.96m,
                PricePerWeekday = 198.3m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 13.96m,
                NumberOfBeds = 1,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 11,
                Status = pStatus.Active
            };
            p3015.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3015);

            // Add Property p3016
            Property p3016 = new Property()
            {
                PropertyNumber = 3016,
                ZipCode = "14742",
                State = StateList.MT,
                StreetAddress = "6824 Timothy Garden Apt. 428",
                AptNum = null,
                City = "West Richardmouth",
                HostEmail = "rankin@yahoo.com",
                PricePerWeekend = 297.31m,
                PricePerWeekday = 181.5m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 10.09m,
                NumberOfBeds = 6,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 10,
                Status = pStatus.Active
            };
            p3016.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3016);

            // Add Property p3017
            Property p3017 = new Property()
            {
                PropertyNumber = 3017,
                ZipCode = "11894",
                State = StateList.SC,
                StreetAddress = "5517 Holly Meadow Apt. 452",
                AptNum = null,
                City = "Lake Anne",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 139.22m,
                PricePerWeekday = 134.09m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 9.75m,
                NumberOfBeds = 1,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3017.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3017);

            // Add Property p3018
            Property p3018 = new Property()
            {
                PropertyNumber = 3018,
                ZipCode = "28976",
                State = StateList.TX,
                StreetAddress = "30601 Hawkins Highway",
                AptNum = null,
                City = "Morashire",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 160.61m,
                PricePerWeekday = 187.65m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 7.5m,
                NumberOfBeds = 6,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3018.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3018);

            // Add Property p3019
            Property p3019 = new Property()
            {
                PropertyNumber = 3019,
                ZipCode = "28798",
                State = StateList.AZ,
                StreetAddress = "49263 Wilson View Apt. 873",
                AptNum = null,
                City = "South Raymondborough",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 133.25m,
                PricePerWeekday = 206.95m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 14.04m,
                NumberOfBeds = 1,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 5,
                Status = pStatus.Active
            };
            p3019.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3019);

            // Add Property p3020
            Property p3020 = new Property()
            {
                PropertyNumber = 3020,
                ZipCode = "68819",
                State = StateList.NE,
                StreetAddress = "76582 Vanessa Oval",
                AptNum = null,
                City = "New Richard",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 242.89m,
                PricePerWeekday = 99.54m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 6.61m,
                NumberOfBeds = 5,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 12,
                Status = pStatus.Active
            };
            p3020.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3020);

            // Add Property p3021
            Property p3021 = new Property()
            {
                PropertyNumber = 3021,
                ZipCode = "50177",
                State = StateList.FL,
                StreetAddress = "7389 Alec Squares Suite 508",
                AptNum = null,
                City = "Port Jonathan",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 165.32m,
                PricePerWeekday = 112.62m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 24.26m,
                NumberOfBeds = 7,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 12,
                Status = pStatus.Active
            };
            p3021.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3021);

            // Add Property p3022
            Property p3022 = new Property()
            {
                PropertyNumber = 3022,
                ZipCode = "66355",
                State = StateList.NC,
                StreetAddress = "18013 Billy Bridge Suite 522",
                AptNum = null,
                City = "Schmitthaven",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 119.02m,
                PricePerWeekday = 199.21m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 11.63m,
                NumberOfBeds = 3,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 2,
                Status = pStatus.Active
            };
            p3022.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3022);

            // Add Property p3023
            Property p3023 = new Property()
            {
                PropertyNumber = 3023,
                ZipCode = "51431",
                State = StateList.NJ,
                StreetAddress = "891 Bullock Ford",
                AptNum = null,
                City = "Amandachester",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 244.93m,
                PricePerWeekday = 179.05m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 21.78m,
                NumberOfBeds = 5,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 11,
                Status = pStatus.Active
            };
            p3023.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3023);

            // Add Property p3024
            Property p3024 = new Property()
            {
                PropertyNumber = 3024,
                ZipCode = "50853",
                State = StateList.MT,
                StreetAddress = "02489 Cook Park",
                AptNum = null,
                City = "Sherriport",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 227.35m,
                PricePerWeekday = 207.24m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 5.5m,
                NumberOfBeds = 4,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 6,
                Status = pStatus.Active
            };
            p3024.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3024);

            // Add Property p3025
            Property p3025 = new Property()
            {
                PropertyNumber = 3025,
                ZipCode = "20341",
                State = StateList.UT,
                StreetAddress = "23450 Timothy Divide",
                AptNum = null,
                City = "Wuland",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 278.36m,
                PricePerWeekday = 116.01m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 24.73m,
                NumberOfBeds = 3,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 11,
                Status = pStatus.Active
            };
            p3025.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3025);

            // Add Property p3026
            Property p3026 = new Property()
            {
                PropertyNumber = 3026,
                ZipCode = "85565",
                State = StateList.OH,
                StreetAddress = "0976 Williams Mountains Apt. 009",
                AptNum = null,
                City = "Lake Mario",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 293.42m,
                PricePerWeekday = 225.14m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 10.42m,
                NumberOfBeds = 6,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 7,
                Status = pStatus.Active
            };
            p3026.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3026);

            // Add Property p3027
            Property p3027 = new Property()
            {
                PropertyNumber = 3027,
                ZipCode = "51884",
                State = StateList.WY,
                StreetAddress = "1097 Santos Springs Suite 264",
                AptNum = null,
                City = "New Michelleborough",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 126.45m,
                PricePerWeekday = 70.24m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 18.69m,
                NumberOfBeds = 2,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 4,
                Status = pStatus.Active
            };
            p3027.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3027);

            // Add Property p3028
            Property p3028 = new Property()
            {
                PropertyNumber = 3028,
                ZipCode = "66353",
                State = StateList.SC,
                StreetAddress = "5100 Scott Burg",
                AptNum = null,
                City = "East Clayton",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 224.07m,
                PricePerWeekday = 186.38m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 28.24m,
                NumberOfBeds = 4,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.Active
            };
            p3028.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3028);

            // Add Property p3029
            Property p3029 = new Property()
            {
                PropertyNumber = 3029,
                ZipCode = "57004",
                State = StateList.NV,
                StreetAddress = "412 Snow Manors Apt. 161",
                AptNum = null,
                City = "South Kimtown",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 120.93m,
                PricePerWeekday = 112.47m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 23.28m,
                NumberOfBeds = 5,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3029.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3029);

            // Add Property p3030
            Property p3030 = new Property()
            {
                PropertyNumber = 3030,
                ZipCode = "48447",
                State = StateList.IN,
                StreetAddress = "5415 David Square",
                AptNum = null,
                City = "West Michaeltown",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 100.02m,
                PricePerWeekday = 214.81m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 17.78m,
                NumberOfBeds = 7,
                NumberOfBaths = 9,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3030.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3030);

            // Add Property p3031
            Property p3031 = new Property()
            {
                PropertyNumber = 3031,
                ZipCode = "62982",
                State = StateList.DE,
                StreetAddress = "03104 Norris Rapids",
                AptNum = null,
                City = "Port Donald",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 161.6m,
                PricePerWeekday = 159.87m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 10.34m,
                NumberOfBeds = 1,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 11,
                Status = pStatus.Active
            };
            p3031.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3031);

            // Add Property p3032
            Property p3032 = new Property()
            {
                PropertyNumber = 3032,
                ZipCode = "16915",
                State = StateList.FL,
                StreetAddress = "03557 Phillips Wells Suite 291",
                AptNum = null,
                City = "New Beverlyburgh",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 203.6m,
                PricePerWeekday = 70.55m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 5.09m,
                NumberOfBeds = 7,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 4,
                Status = pStatus.Active
            };
            p3032.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3032);

            // Add Property p3033
            Property p3033 = new Property()
            {
                PropertyNumber = 3033,
                ZipCode = "39742",
                State = StateList.MT,
                StreetAddress = "332 Watson Shore Apt. 290",
                AptNum = null,
                City = "Millerland",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 299.34m,
                PricePerWeekday = 176.37m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 17.38m,
                NumberOfBeds = 3,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 2,
                Status = pStatus.Active
            };
            p3033.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3033);

            // Add Property p3034
            Property p3034 = new Property()
            {
                PropertyNumber = 3034,
                ZipCode = "54060",
                State = StateList.MS,
                StreetAddress = "645 John Roads",
                AptNum = null,
                City = "Danahaven",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 229.98m,
                PricePerWeekday = 172.83m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 23.55m,
                NumberOfBeds = 7,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 14,
                Status = pStatus.Active
            };
            p3034.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3034);

            // Add Property p3035
            Property p3035 = new Property()
            {
                PropertyNumber = 3035,
                ZipCode = "55774",
                State = StateList.HI,
                StreetAddress = "3547 Stephanie Underpass Apt. 418",
                AptNum = null,
                City = "Port Jacqueline",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 143.71m,
                PricePerWeekday = 177.08m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 19.21m,
                NumberOfBeds = 1,
                NumberOfBaths = 1,
                NumberOfGuestsAllowed = 5,
                Status = pStatus.Active
            };
            p3035.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3035);

            // Add Property p3036
            Property p3036 = new Property()
            {
                PropertyNumber = 3036,
                ZipCode = "59363",
                State = StateList.UT,
                StreetAddress = "5825 Welch Corners",
                AptNum = null,
                City = "Fischerport",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 113.86m,
                PricePerWeekday = 76.66m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 27.87m,
                NumberOfBeds = 3,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 10,
                Status = pStatus.Active
            };
            p3036.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3036);

            // Add Property p3037
            Property p3037 = new Property()
            {
                PropertyNumber = 3037,
                ZipCode = "71770",
                State = StateList.IN,
                StreetAddress = "41489 Roger Terrace",
                AptNum = null,
                City = "Davisfort",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 299.09m,
                PricePerWeekday = 177.37m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 23.78m,
                NumberOfBeds = 6,
                NumberOfBaths = 8,
                NumberOfGuestsAllowed = 6,
                Status = pStatus.Active
            };
            p3037.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3037);

            // Add Property p3038
            Property p3038 = new Property()
            {
                PropertyNumber = 3038,
                ZipCode = "05147",
                State = StateList.CO,
                StreetAddress = "014 Aaron Locks Suite 714",
                AptNum = null,
                City = "Justinborough",
                HostEmail = "rankin@yahoo.com",
                PricePerWeekend = 158.42m,
                PricePerWeekday = 104.05m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 5.36m,
                NumberOfBeds = 2,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 5,
                Status = pStatus.Active
            };
            p3038.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3038);

            // Add Property p3039
            Property p3039 = new Property()
            {
                PropertyNumber = 3039,
                ZipCode = "28062",
                State = StateList.SC,
                StreetAddress = "8518 Pamela Track Apt. 164",
                AptNum = null,
                City = "Aprilshire",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 210.59m,
                PricePerWeekday = 199.37m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 8.83m,
                NumberOfBeds = 3,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3039.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3039);

            // Add Property p3040
            Property p3040 = new Property()
            {
                PropertyNumber = 3040,
                ZipCode = "88090",
                State = StateList.OH,
                StreetAddress = "864 Ramos Port Apt. 211",
                AptNum = null,
                City = "Moralesmouth",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 153.69m,
                PricePerWeekday = 94.48m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 16.85m,
                NumberOfBeds = 3,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3040.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3040);

            // Add Property p3041
            Property p3041 = new Property()
            {
                PropertyNumber = 3041,
                ZipCode = "28775",
                State = StateList.RI,
                StreetAddress = "637 Neal Island Suite 074",
                AptNum = null,
                City = "Lake Tyler",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 196.14m,
                PricePerWeekday = 88.82m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 6.97m,
                NumberOfBeds = 3,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 14,
                Status = pStatus.Active
            };
            p3041.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3041);

            // Add Property p3042
            Property p3042 = new Property()
            {
                PropertyNumber = 3042,
                ZipCode = "75585",
                State = StateList.WV,
                StreetAddress = "0811 Smith Canyon Apt. 904",
                AptNum = null,
                City = "Jessicabury",
                HostEmail = "rankin@yahoo.com",
                PricePerWeekend = 123.22m,
                PricePerWeekday = 119.58m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 18.45m,
                NumberOfBeds = 3,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 2,
                Status = pStatus.Active
            };
            p3042.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3042);

            // Add Property p3043
            Property p3043 = new Property()
            {
                PropertyNumber = 3043,
                ZipCode = "17438",
                State = StateList.MD,
                StreetAddress = "7562 Fisher Spur",
                AptNum = null,
                City = "Hernandezberg",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 283.77m,
                PricePerWeekday = 218.87m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 19.07m,
                NumberOfBeds = 1,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 2,
                Status = pStatus.Active
            };
            p3043.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3043);

            // Add Property p3044
            Property p3044 = new Property()
            {
                PropertyNumber = 3044,
                ZipCode = "7027",
                State = StateList.VT,
                StreetAddress = "5667 Blair Underpass",
                AptNum = null,
                City = "South Shelby",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 239.76m,
                PricePerWeekday = 76.19m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 11.37m,
                NumberOfBeds = 2,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 13,
                Status = pStatus.Active
            };
            p3044.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3044);

            // Add Property p3045
            Property p3045 = new Property()
            {
                PropertyNumber = 3045,
                ZipCode = "1008",
                State = StateList.MI,
                StreetAddress = "6708 Carpenter Overpass Suite 735",
                AptNum = null,
                City = "Bobbyton",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 229.04m,
                PricePerWeekday = 161.17m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 25.01m,
                NumberOfBeds = 7,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 7,
                Status = pStatus.Active
            };
            p3045.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3045);

            // Add Property p3046
            Property p3046 = new Property()
            {
                PropertyNumber = 3046,
                ZipCode = "60236",
                State = StateList.ND,
                StreetAddress = "16396 Shawn Junction",
                AptNum = null,
                City = "New Nicolemouth",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 220.69m,
                PricePerWeekday = 106.06m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 11.82m,
                NumberOfBeds = 4,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 6,
                Status = pStatus.Active
            };
            p3046.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3046);

            // Add Property p3047
            Property p3047 = new Property()
            {
                PropertyNumber = 3047,
                ZipCode = "01707",
                State = StateList.CA,
                StreetAddress = "4486 Olson Well",
                AptNum = null,
                City = "North Kevin",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 138.96m,
                PricePerWeekday = 151.44m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 6.72m,
                NumberOfBeds = 7,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 10,
                Status = pStatus.Active
            };
            p3047.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3047);

            // Add Property p3048
            Property p3048 = new Property()
            {
                PropertyNumber = 3048,
                ZipCode = "33233",
                State = StateList.HI,
                StreetAddress = "67771 Christopher Courts Apt. 637",
                AptNum = null,
                City = "Port Ronaldfurt",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 134.28m,
                PricePerWeekday = 102.43m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 19.81m,
                NumberOfBeds = 5,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 2,
                Status = pStatus.Active
            };
            p3048.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3048);

            // Add Property p3049
            Property p3049 = new Property()
            {
                PropertyNumber = 3049,
                ZipCode = "79756",
                State = StateList.NY,
                StreetAddress = "5561 Bishop Turnpike",
                AptNum = null,
                City = "Lake Kenneth",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 259.87m,
                PricePerWeekday = 94.31m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 22.33m,
                NumberOfBeds = 5,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 11,
                Status = pStatus.Active
            };
            p3049.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3049);

            // Add Property p3050
            Property p3050 = new Property()
            {
                PropertyNumber = 3050,
                ZipCode = "36216",
                State = StateList.SD,
                StreetAddress = "3019 Gerald Mall Apt. 340",
                AptNum = null,
                City = "Trevinoville",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 263.32m,
                PricePerWeekday = 151.69m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 13.27m,
                NumberOfBeds = 5,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3050.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3050);

            // Add Property p3051
            Property p3051 = new Property()
            {
                PropertyNumber = 3051,
                ZipCode = "43477",
                State = StateList.NY,
                StreetAddress = "84331 Leonard Fort Suite 749",
                AptNum = null,
                City = "East Lisa",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 204.28m,
                PricePerWeekday = 204.04m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 11.07m,
                NumberOfBeds = 7,
                NumberOfBaths = 8,
                NumberOfGuestsAllowed = 10,
                Status = pStatus.Active
            };
            p3051.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3051);

            // Add Property p3052
            Property p3052 = new Property()
            {
                PropertyNumber = 3052,
                ZipCode = "17819",
                State = StateList.VA,
                StreetAddress = "62281 Kathy Tunnel",
                AptNum = null,
                City = "Hudsonborough",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 224.19m,
                PricePerWeekday = 165.51m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 24.26m,
                NumberOfBeds = 1,
                NumberOfBaths = 1,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3052.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3052);

            // Add Property p3053
            Property p3053 = new Property()
            {
                PropertyNumber = 3053,
                ZipCode = "97149",
                State = StateList.NM,
                StreetAddress = "9927 Christina Burg Suite 774",
                AptNum = null,
                City = "East Angelaburgh",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 121.74m,
                PricePerWeekday = 106.87m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 5.62m,
                NumberOfBeds = 7,
                NumberOfBaths = 9,
                NumberOfGuestsAllowed = 6,
                Status = pStatus.Active
            };
            p3053.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3053);

            // Add Property p3054
            Property p3054 = new Property()
            {
                PropertyNumber = 3054,
                ZipCode = "45480",
                State = StateList.IA,
                StreetAddress = "142 Warner View Suite 460",
                AptNum = null,
                City = "North Leslie",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 148.76m,
                PricePerWeekday = 212.32m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 20.2m,
                NumberOfBeds = 5,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3054.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3054);

            // Add Property p3055
            Property p3055 = new Property()
            {
                PropertyNumber = 3055,
                ZipCode = "03720",
                State = StateList.AR,
                StreetAddress = "5240 Berry Centers",
                AptNum = null,
                City = "West Andrew",
                HostEmail = "rankin@yahoo.com",
                PricePerWeekend = 111.01m,
                PricePerWeekday = 164.02m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 26.21m,
                NumberOfBeds = 7,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 12,
                Status = pStatus.notActive
            };
            p3055.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3055);

            // Add Property p3056
            Property p3056 = new Property()
            {
                PropertyNumber = 3056,
                ZipCode = "85576",
                State = StateList.HI,
                StreetAddress = "51056 Patricia Forge",
                AptNum = null,
                City = "Grahamstad",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 167.53m,
                PricePerWeekday = 117.45m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 24.75m,
                NumberOfBeds = 7,
                NumberOfBaths = 9,
                NumberOfGuestsAllowed = 10,
                Status = pStatus.Active
            };
            p3056.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3056);

            // Add Property p3057
            Property p3057 = new Property()
            {
                PropertyNumber = 3057,
                ZipCode = "92199",
                State = StateList.VA,
                StreetAddress = "0648 Malone Port Apt. 662",
                AptNum = null,
                City = "New Devonhaven",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 176.53m,
                PricePerWeekday = 209.47m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 5.83m,
                NumberOfBeds = 6,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 12,
                Status = pStatus.Active
            };
            p3057.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3057);

            // Add Property p3058
            Property p3058 = new Property()
            {
                PropertyNumber = 3058,
                ZipCode = "05261",
                State = StateList.SC,
                StreetAddress = "23028 Jennifer Meadow Apt. 972",
                AptNum = null,
                City = "West Matthewfurt",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 199.1m,
                PricePerWeekday = 153.04m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 18.62m,
                NumberOfBeds = 1,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 14,
                Status = pStatus.Active
            };
            p3058.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3058);

            // Add Property p3059
            Property p3059 = new Property()
            {
                PropertyNumber = 3059,
                ZipCode = "72649",
                State = StateList.LA,
                StreetAddress = "2738 Martin Terrace Suite 547",
                AptNum = null,
                City = "Smithhaven",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 199.22m,
                PricePerWeekday = 196.56m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 20.71m,
                NumberOfBeds = 1,
                NumberOfBaths = 1,
                NumberOfGuestsAllowed = 11,
                Status = pStatus.Active
            };
            p3059.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3059);

            // Add Property p3060
            Property p3060 = new Property()
            {
                PropertyNumber = 3060,
                ZipCode = "97488",
                State = StateList.KY,
                StreetAddress = "984 Stephen Stravenue",
                AptNum = null,
                City = "South Michaelton",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 178.29m,
                PricePerWeekday = 117.03m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 6.47m,
                NumberOfBeds = 4,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.Active
            };
            p3060.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3060);

            // Add Property p3061
            Property p3061 = new Property()
            {
                PropertyNumber = 3061,
                ZipCode = "42837",
                State = StateList.LA,
                StreetAddress = "98522 Mathis Viaduct Apt. 909",
                AptNum = null,
                City = "West Michael",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 252.79m,
                PricePerWeekday = 133.35m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 9.15m,
                NumberOfBeds = 4,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3061.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3061);

            // Add Property p3062
            Property p3062 = new Property()
            {
                PropertyNumber = 3062,
                ZipCode = "56059",
                State = StateList.OH,
                StreetAddress = "620 Ashley Mills Apt. 507",
                AptNum = null,
                City = "Julieborough",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 296.05m,
                PricePerWeekday = 171.15m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 18.26m,
                NumberOfBeds = 1,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3062.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3062);

            // Add Property p3063
            Property p3063 = new Property()
            {
                PropertyNumber = 3063,
                ZipCode = "02288",
                State = StateList.LA,
                StreetAddress = "212 Shelly Roads",
                AptNum = null,
                City = "Fischerview",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 163.88m,
                PricePerWeekday = 132.81m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 7.46m,
                NumberOfBeds = 5,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 10,
                Status = pStatus.Active
            };
            p3063.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3063);

            // Add Property p3064
            Property p3064 = new Property()
            {
                PropertyNumber = 3064,
                ZipCode = "50851",
                State = StateList.OK,
                StreetAddress = "8885 Lee Tunnel Suite 208",
                AptNum = null,
                City = "Port Donna",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 140.73m,
                PricePerWeekday = 228.84m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 17.13m,
                NumberOfBeds = 7,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 7,
                Status = pStatus.Active
            };
            p3064.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3064);

            // Add Property p3065
            Property p3065 = new Property()
            {
                PropertyNumber = 3065,
                ZipCode = "03009",
                State = StateList.NM,
                StreetAddress = "693 Michael Estate",
                AptNum = null,
                City = "Lake Michael",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 139.83m,
                PricePerWeekday = 155.03m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 21.05m,
                NumberOfBeds = 4,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 13,
                Status = pStatus.Active
            };
            p3065.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3065);

            // Add Property p3066
            Property p3066 = new Property()
            {
                PropertyNumber = 3066,
                ZipCode = "92905",
                State = StateList.NY,
                StreetAddress = "342 Miller Mission",
                AptNum = null,
                City = "Lake Jennifer",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 249.24m,
                PricePerWeekday = 128.41m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 6.63m,
                NumberOfBeds = 4,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3066.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3066);

            // Add Property p3067
            Property p3067 = new Property()
            {
                PropertyNumber = 3067,
                ZipCode = "65056",
                State = StateList.AK,
                StreetAddress = "71664 Kim Throughway",
                AptNum = null,
                City = "Chelsealand",
                HostEmail = "rankin@yahoo.com",
                PricePerWeekend = 286.53m,
                PricePerWeekday = 163.68m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 25.57m,
                NumberOfBeds = 6,
                NumberOfBaths = 8,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3067.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3067);

            // Add Property p3068
            Property p3068 = new Property()
            {
                PropertyNumber = 3068,
                ZipCode = "11181",
                State = StateList.AZ,
                StreetAddress = "66660 Gomez Port Apt. 945",
                AptNum = null,
                City = "South Thomashaven",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 137.17m,
                PricePerWeekday = 93.86m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 28.18m,
                NumberOfBeds = 4,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 2,
                Status = pStatus.Active
            };
            p3068.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3068);

            // Add Property p3069
            Property p3069 = new Property()
            {
                PropertyNumber = 3069,
                ZipCode = "53480",
                State = StateList.FL,
                StreetAddress = "0131 Williams Ville Apt. 562",
                AptNum = null,
                City = "Richardberg",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 120.61m,
                PricePerWeekday = 86.25m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 11.39m,
                NumberOfBeds = 6,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 13,
                Status = pStatus.Active
            };
            p3069.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3069);

            // Add Property p3070
            Property p3070 = new Property()
            {
                PropertyNumber = 3070,
                ZipCode = "11353",
                State = StateList.OR,
                StreetAddress = "22708 Madison Spurs",
                AptNum = null,
                City = "Herringstad",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 241.25m,
                PricePerWeekday = 182.46m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 18.29m,
                NumberOfBeds = 6,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 2,
                Status = pStatus.Active
            };
            p3070.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3070);

            // Add Property p3071
            Property p3071 = new Property()
            {
                PropertyNumber = 3071,
                ZipCode = "05560",
                State = StateList.FL,
                StreetAddress = "3454 Holmes Motorway",
                AptNum = null,
                City = "Port Rachel",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 123.04m,
                PricePerWeekday = 89.88m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 19.14m,
                NumberOfBeds = 3,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3071.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3071);

            // Add Property p3072
            Property p3072 = new Property()
            {
                PropertyNumber = 3072,
                ZipCode = "93500",
                State = StateList.GA,
                StreetAddress = "805 James Turnpike",
                AptNum = null,
                City = "Carrmouth",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 219.86m,
                PricePerWeekday = 81.55m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 13.38m,
                NumberOfBeds = 6,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 12,
                Status = pStatus.Active
            };
            p3072.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3072);

            // Add Property p3073
            Property p3073 = new Property()
            {
                PropertyNumber = 3073,
                ZipCode = "44515",
                State = StateList.NV,
                StreetAddress = "8081 Smith Trail",
                AptNum = null,
                City = "North Ronaldstad",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 196.09m,
                PricePerWeekday = 130.47m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 14.53m,
                NumberOfBeds = 7,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.Active
            };
            p3073.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3073);

            // Add Property p3074
            Property p3074 = new Property()
            {
                PropertyNumber = 3074,
                ZipCode = "07347",
                State = StateList.MS,
                StreetAddress = "125 Ian Crossroad Apt. 593",
                AptNum = null,
                City = "South Deannaport",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 136.82m,
                PricePerWeekday = 148.1m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 15.57m,
                NumberOfBeds = 2,
                NumberOfBaths = 1,
                NumberOfGuestsAllowed = 4,
                Status = pStatus.Active
            };
            p3074.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3074);

            // Add Property p3075
            Property p3075 = new Property()
            {
                PropertyNumber = 3075,
                ZipCode = "54532",
                State = StateList.NH,
                StreetAddress = "1607 Munoz River",
                AptNum = null,
                City = "Emilyshire",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 209.77m,
                PricePerWeekday = 147.55m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 27.65m,
                NumberOfBeds = 6,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.Active
            };
            p3075.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3075);

            // Add Property p3076
            Property p3076 = new Property()
            {
                PropertyNumber = 3076,
                ZipCode = "65516",
                State = StateList.UT,
                StreetAddress = "3615 David Keys Apt. 269",
                AptNum = null,
                City = "West Stephenside",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 126.47m,
                PricePerWeekday = 86.8m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 17.6m,
                NumberOfBeds = 2,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.Active
            };
            p3076.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3076);

            // Add Property p3077
            Property p3077 = new Property()
            {
                PropertyNumber = 3077,
                ZipCode = "20721",
                State = StateList.AZ,
                StreetAddress = "640 Mary Common",
                AptNum = null,
                City = "Michaelville",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 173.01m,
                PricePerWeekday = 121.75m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 12.53m,
                NumberOfBeds = 3,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 7,
                Status = pStatus.Active
            };
            p3077.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3077);

            // Add Property p3078
            Property p3078 = new Property()
            {
                PropertyNumber = 3078,
                ZipCode = "43567",
                State = StateList.LA,
                StreetAddress = "395 Timothy Road",
                AptNum = null,
                City = "Williamsbury",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 198.1m,
                PricePerWeekday = 160.23m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 10.82m,
                NumberOfBeds = 5,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 5,
                Status = pStatus.Active
            };
            p3078.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3078);

            // Add Property p3079
            Property p3079 = new Property()
            {
                PropertyNumber = 3079,
                ZipCode = "01239",
                State = StateList.OR,
                StreetAddress = "3267 Walter Dam",
                AptNum = null,
                City = "Cunninghamtown",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 127.7m,
                PricePerWeekday = 110.64m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 26.67m,
                NumberOfBeds = 1,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 7,
                Status = pStatus.Active
            };
            p3079.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3079);

            // Add Property p3080
            Property p3080 = new Property()
            {
                PropertyNumber = 3080,
                ZipCode = "3966",
                State = StateList.MS,
                StreetAddress = "00580 Brandon Creek",
                AptNum = null,
                City = "Port Eric",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 236.71m,
                PricePerWeekday = 227.6m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 20.22m,
                NumberOfBeds = 3,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 2,
                Status = pStatus.Active
            };
            p3080.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3080);

            // Add Property p3081
            Property p3081 = new Property()
            {
                PropertyNumber = 3081,
                ZipCode = "29996",
                State = StateList.MS,
                StreetAddress = "325 Amanda Cliffs Apt. 695",
                AptNum = null,
                City = "South Paulabury",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 135.59m,
                PricePerWeekday = 115.37m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 29.8m,
                NumberOfBeds = 6,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 13,
                Status = pStatus.Active
            };
            p3081.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3081);

            // Add Property p3082
            Property p3082 = new Property()
            {
                PropertyNumber = 3082,
                ZipCode = "93980",
                State = StateList.CT,
                StreetAddress = "40956 Amanda Walk Apt. 260",
                AptNum = null,
                City = "Simonfurt",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 271.49m,
                PricePerWeekday = 93.35m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 8.54m,
                NumberOfBeds = 4,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 5,
                Status = pStatus.Active
            };
            p3082.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3082);

            // Add Property p3083
            Property p3083 = new Property()
            {
                PropertyNumber = 3083,
                ZipCode = "23687",
                State = StateList.KS,
                StreetAddress = "25762 Gill Creek Suite 525",
                AptNum = null,
                City = "Mccoyton",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 247.15m,
                PricePerWeekday = 171.37m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 17.22m,
                NumberOfBeds = 1,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 5,
                Status = pStatus.Active
            };
            p3083.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3083);

            // Add Property p3084
            Property p3084 = new Property()
            {
                PropertyNumber = 3084,
                ZipCode = "04593",
                State = StateList.GA,
                StreetAddress = "6048 Johnson Loop Suite 635",
                AptNum = null,
                City = "East Daniel",
                HostEmail = "rankin@yahoo.com",
                PricePerWeekend = 299.6m,
                PricePerWeekday = 95.59m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 24.3m,
                NumberOfBeds = 1,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 8,
                Status = pStatus.Active
            };
            p3084.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3084);

            // Add Property p3085
            Property p3085 = new Property()
            {
                PropertyNumber = 3085,
                ZipCode = "96954",
                State = StateList.RI,
                StreetAddress = "1168 Gary Fords Apt. 308",
                AptNum = null,
                City = "Port Trevor",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 278.17m,
                PricePerWeekday = 194.84m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 5.88m,
                NumberOfBeds = 1,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 11,
                Status = pStatus.Active
            };
            p3085.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3085);

            // Add Property p3086
            Property p3086 = new Property()
            {
                PropertyNumber = 3086,
                ZipCode = "62271",
                State = StateList.MS,
                StreetAddress = "164 Matthew Parkway Suite 826",
                AptNum = null,
                City = "Jimmyfurt",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 100.08m,
                PricePerWeekday = 112.03m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 28.82m,
                NumberOfBeds = 6,
                NumberOfBaths = 8,
                NumberOfGuestsAllowed = 8,
                Status = pStatus.Active
            };
            p3086.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3086);

            // Add Property p3087
            Property p3087 = new Property()
            {
                PropertyNumber = 3087,
                ZipCode = "5222",
                State = StateList.CO,
                StreetAddress = "1220 Heidi Rue Apt. 998",
                AptNum = null,
                City = "West Haleyburgh",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 182.77m,
                PricePerWeekday = 127.97m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 13.02m,
                NumberOfBeds = 5,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3087.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3087);

            // Add Property p3088
            Property p3088 = new Property()
            {
                PropertyNumber = 3088,
                ZipCode = "22365",
                State = StateList.SD,
                StreetAddress = "751 Wood Square Suite 732",
                AptNum = null,
                City = "Port Melissaburgh",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 186.01m,
                PricePerWeekday = 120.07m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 26.71m,
                NumberOfBeds = 7,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 13,
                Status = pStatus.Active
            };
            p3088.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3088);

            // Add Property p3089
            Property p3089 = new Property()
            {
                PropertyNumber = 3089,
                ZipCode = "53609",
                State = StateList.OR,
                StreetAddress = "376 Smith Dale Suite 279",
                AptNum = null,
                City = "South Sarahland",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 122.31m,
                PricePerWeekday = 137.96m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 26.29m,
                NumberOfBeds = 2,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3089.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3089);

            // Add Property p3090
            Property p3090 = new Property()
            {
                PropertyNumber = 3090,
                ZipCode = "9478",
                State = StateList.CA,
                StreetAddress = "79148 Pierce Lock Suite 423",
                AptNum = null,
                City = "Erikberg",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 234.61m,
                PricePerWeekday = 226.57m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 16.41m,
                NumberOfBeds = 3,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 6,
                Status = pStatus.Active
            };
            p3090.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3090);

            // Add Property p3091
            Property p3091 = new Property()
            {
                PropertyNumber = 3091,
                ZipCode = "01425",
                State = StateList.ID,
                StreetAddress = "147 Lisa Hill Apt. 512",
                AptNum = null,
                City = "Port Elizabethshire",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 145.15m,
                PricePerWeekday = 95.73m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 9.93m,
                NumberOfBeds = 4,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 10,
                Status = pStatus.Active
            };
            p3091.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3091);

            // Add Property p3092
            Property p3092 = new Property()
            {
                PropertyNumber = 3092,
                ZipCode = "29941",
                State = StateList.KY,
                StreetAddress = "971 Hansen Well Suite 103",
                AptNum = null,
                City = "South Mary",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 145.72m,
                PricePerWeekday = 161.68m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 24.36m,
                NumberOfBeds = 6,
                NumberOfBaths = 8,
                NumberOfGuestsAllowed = 4,
                Status = pStatus.Active
            };
            p3092.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3092);

            // Add Property p3093
            Property p3093 = new Property()
            {
                PropertyNumber = 3093,
                ZipCode = "47577",
                State = StateList.WY,
                StreetAddress = "511 Berry Fork Suite 623",
                AptNum = null,
                City = "Sharonfort",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 260.18m,
                PricePerWeekday = 183.81m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 7.46m,
                NumberOfBeds = 4,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.notActive
            };
            p3093.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3093);

            // Add Property p3094
            Property p3094 = new Property()
            {
                PropertyNumber = 3094,
                ZipCode = "94134",
                State = StateList.WI,
                StreetAddress = "65873 Chen Knolls",
                AptNum = null,
                City = "Ramirezfurt",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 117.17m,
                PricePerWeekday = 215.38m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 24.31m,
                NumberOfBeds = 4,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 14,
                Status = pStatus.Active
            };
            p3094.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3094);

            // Add Property p3095
            Property p3095 = new Property()
            {
                PropertyNumber = 3095,
                ZipCode = "57039",
                State = StateList.IN,
                StreetAddress = "8799 Emma Parkway Suite 735",
                AptNum = null,
                City = "North Thomasfurt",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 242.21m,
                PricePerWeekday = 145.51m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 11.89m,
                NumberOfBeds = 3,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 11,
                Status = pStatus.Active
            };
            p3095.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3095);

            // Add Property p3096
            Property p3096 = new Property()
            {
                PropertyNumber = 3096,
                ZipCode = "23718",
                State = StateList.ND,
                StreetAddress = "30068 David View Apt. 173",
                AptNum = null,
                City = "New Peggychester",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 161.21m,
                PricePerWeekday = 142.76m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 20.92m,
                NumberOfBeds = 4,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 7,
                Status = pStatus.Active
            };
            p3096.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3096);

            // Add Property p3097
            Property p3097 = new Property()
            {
                PropertyNumber = 3097,
                ZipCode = "26932",
                State = StateList.MD,
                StreetAddress = "298 Johnathan Cove Apt. 402",
                AptNum = null,
                City = "South Jamie",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 176.37m,
                PricePerWeekday = 170.07m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 8.54m,
                NumberOfBeds = 6,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 13,
                Status = pStatus.Active
            };
            p3097.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3097);

            // Add Property p3098
            Property p3098 = new Property()
            {
                PropertyNumber = 3098,
                ZipCode = "74554",
                State = StateList.CO,
                StreetAddress = "171 Harrison Motorway",
                AptNum = null,
                City = "Davidview",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 234.81m,
                PricePerWeekday = 145.08m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 26.14m,
                NumberOfBeds = 6,
                NumberOfBaths = 8,
                NumberOfGuestsAllowed = 10,
                Status = pStatus.Active
            };
            p3098.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3098);

            // Add Property p3099
            Property p3099 = new Property()
            {
                PropertyNumber = 3099,
                ZipCode = "32097",
                State = StateList.NE,
                StreetAddress = "3576 Sergio Avenue",
                AptNum = null,
                City = "Benjaminmouth",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 260.62m,
                PricePerWeekday = 111.73m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 15.89m,
                NumberOfBeds = 1,
                NumberOfBaths = 1,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3099.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3099);

            // Add Property p3100
            Property p3100 = new Property()
            {
                PropertyNumber = 3100,
                ZipCode = "21519",
                State = StateList.RI,
                StreetAddress = "37457 Tanya Pike Apt. 348",
                AptNum = null,
                City = "North Ericton",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 214.62m,
                PricePerWeekday = 70.63m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 5.29m,
                NumberOfBeds = 2,
                NumberOfBaths = 1,
                NumberOfGuestsAllowed = 13,
                Status = pStatus.Active
            };
            p3100.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3100);

            // Add Property p3101
            Property p3101 = new Property()
            {
                PropertyNumber = 3101,
                ZipCode = "76875",
                State = StateList.PA,
                StreetAddress = "3673 Peter Turnpike Suite 835",
                AptNum = null,
                City = "New Sandra",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 172.79m,
                PricePerWeekday = 229.03m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 14.05m,
                NumberOfBeds = 4,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 6,
                Status = pStatus.Active
            };
            p3101.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3101);

            // Add Property p3102
            Property p3102 = new Property()
            {
                PropertyNumber = 3102,
                ZipCode = "80451",
                State = StateList.TX,
                StreetAddress = "939 Johnson Oval Suite 830",
                AptNum = null,
                City = "North Dennismouth",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 133.53m,
                PricePerWeekday = 169.34m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 18.06m,
                NumberOfBeds = 3,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 6,
                Status = pStatus.Active
            };
            p3102.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3102);

            // Add Property p3103
            Property p3103 = new Property()
            {
                PropertyNumber = 3103,
                ZipCode = "51726",
                State = StateList.NV,
                StreetAddress = "645 Jennings Estates",
                AptNum = null,
                City = "Angelastad",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 109.44m,
                PricePerWeekday = 155.52m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 8.28m,
                NumberOfBeds = 2,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 4,
                Status = pStatus.Active
            };
            p3103.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3103);

            // Add Property p3104
            Property p3104 = new Property()
            {
                PropertyNumber = 3104,
                ZipCode = "77240",
                State = StateList.MT,
                StreetAddress = "1231 Stephanie Lock Suite 835",
                AptNum = null,
                City = "North Richardland",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 182.33m,
                PricePerWeekday = 180.2m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 17.78m,
                NumberOfBeds = 5,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 5,
                Status = pStatus.Active
            };
            p3104.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3104);

            // Add Property p3105
            Property p3105 = new Property()
            {
                PropertyNumber = 3105,
                ZipCode = "98152",
                State = StateList.CO,
                StreetAddress = "302 Parker Plains Apt. 197",
                AptNum = null,
                City = "East Robertstad",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 212.7m,
                PricePerWeekday = 212.86m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 6.82m,
                NumberOfBeds = 3,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3105.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3105);

            // Add Property p3106
            Property p3106 = new Property()
            {
                PropertyNumber = 3106,
                ZipCode = "98277",
                State = StateList.MS,
                StreetAddress = "098 Hernandez Green",
                AptNum = null,
                City = "New Sergiobury",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 262.3m,
                PricePerWeekday = 188.71m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 21.88m,
                NumberOfBeds = 4,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 8,
                Status = pStatus.Active
            };
            p3106.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3106);

            // Add Property p3107
            Property p3107 = new Property()
            {
                PropertyNumber = 3107,
                ZipCode = "80082",
                State = StateList.NE,
                StreetAddress = "94102 Sims Port Suite 187",
                AptNum = null,
                City = "Florestown",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 128.05m,
                PricePerWeekday = 83.34m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 11.29m,
                NumberOfBeds = 4,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 8,
                Status = pStatus.Active
            };
            p3107.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3107);

            // Add Property p3108
            Property p3108 = new Property()
            {
                PropertyNumber = 3108,
                ZipCode = "71531",
                State = StateList.ND,
                StreetAddress = "01630 Baker Crescent",
                AptNum = null,
                City = "Kellyborough",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 125.27m,
                PricePerWeekday = 204.02m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 21.15m,
                NumberOfBeds = 1,
                NumberOfBaths = 1,
                NumberOfGuestsAllowed = 4,
                Status = pStatus.Active
            };
            p3108.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3108);

            // Add Property p3109
            Property p3109 = new Property()
            {
                PropertyNumber = 3109,
                ZipCode = "14157",
                State = StateList.OK,
                StreetAddress = "70452 Forbes Courts",
                AptNum = null,
                City = "Mosesland",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 172.1m,
                PricePerWeekday = 90.98m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 18.09m,
                NumberOfBeds = 4,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3109.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3109);

            // Add Property p3110
            Property p3110 = new Property()
            {
                PropertyNumber = 3110,
                ZipCode = "26899",
                State = StateList.MO,
                StreetAddress = "0835 Angela Station",
                AptNum = null,
                City = "East Heather",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 299.91m,
                PricePerWeekday = 158.64m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 23.09m,
                NumberOfBeds = 5,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3110.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3110);

            // Add Property p3111
            Property p3111 = new Property()
            {
                PropertyNumber = 3111,
                ZipCode = "42872",
                State = StateList.VT,
                StreetAddress = "2458 Jason Village Suite 248",
                AptNum = null,
                City = "North Donnamouth",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 189.3m,
                PricePerWeekday = 107.97m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 9.05m,
                NumberOfBeds = 2,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 4,
                Status = pStatus.Active
            };
            p3111.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3111);

            // Add Property p3112
            Property p3112 = new Property()
            {
                PropertyNumber = 3112,
                ZipCode = "78301",
                State = StateList.CO,
                StreetAddress = "1243 Grimes Corners",
                AptNum = null,
                City = "Shawchester",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 193.24m,
                PricePerWeekday = 214.14m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 26.1m,
                NumberOfBeds = 4,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 2,
                Status = pStatus.Active
            };
            p3112.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3112);

            // Add Property p3113
            Property p3113 = new Property()
            {
                PropertyNumber = 3113,
                ZipCode = "34523",
                State = StateList.DC,
                StreetAddress = "558 Williams Station",
                AptNum = null,
                City = "Port Pamela",
                HostEmail = "rankin@yahoo.com",
                PricePerWeekend = 192.46m,
                PricePerWeekday = 106.3m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 17.59m,
                NumberOfBeds = 6,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 4,
                Status = pStatus.Active
            };
            p3113.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3113);

            // Add Property p3114
            Property p3114 = new Property()
            {
                PropertyNumber = 3114,
                ZipCode = "63064",
                State = StateList.VT,
                StreetAddress = "4934 Lozano Place Suite 716",
                AptNum = null,
                City = "Gavinton",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 257.37m,
                PricePerWeekday = 116.99m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 5.63m,
                NumberOfBeds = 5,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 6,
                Status = pStatus.Active
            };
            p3114.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3114);

            // Add Property p3115
            Property p3115 = new Property()
            {
                PropertyNumber = 3115,
                ZipCode = "35700",
                State = StateList.LA,
                StreetAddress = "41227 Patricia Lake",
                AptNum = null,
                City = "Martinezbury",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 108.28m,
                PricePerWeekday = 203.03m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 11.35m,
                NumberOfBeds = 2,
                NumberOfBaths = 1,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.Active
            };
            p3115.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3115);

            // Add Property p3116
            Property p3116 = new Property()
            {
                PropertyNumber = 3116,
                ZipCode = "55206",
                State = StateList.VA,
                StreetAddress = "028 Harris Drive Apt. 422",
                AptNum = null,
                City = "Amyburgh",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 262.77m,
                PricePerWeekday = 163.3m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 13.74m,
                NumberOfBeds = 2,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 14,
                Status = pStatus.Active
            };
            p3116.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3116);

            // Add Property p3117
            Property p3117 = new Property()
            {
                PropertyNumber = 3117,
                ZipCode = "98240",
                State = StateList.IA,
                StreetAddress = "06268 Lewis Place Suite 121",
                AptNum = null,
                City = "Port Patriciatown",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 108.52m,
                PricePerWeekday = 156.25m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 23.66m,
                NumberOfBeds = 3,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 4,
                Status = pStatus.Active
            };
            p3117.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3117);

            // Add Property p3118
            Property p3118 = new Property()
            {
                PropertyNumber = 3118,
                ZipCode = "87205",
                State = StateList.WI,
                StreetAddress = "5641 Brenda Streets Apt. 008",
                AptNum = null,
                City = "Lake Seanmouth",
                HostEmail = "rankin@yahoo.com",
                PricePerWeekend = 153.42m,
                PricePerWeekday = 178.27m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 24.69m,
                NumberOfBeds = 5,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 12,
                Status = pStatus.Active
            };
            p3118.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3118);

            // Add Property p3119
            Property p3119 = new Property()
            {
                PropertyNumber = 3119,
                ZipCode = "58221",
                State = StateList.ME,
                StreetAddress = "92555 Shaw Spurs Suite 207",
                AptNum = null,
                City = "New Randy",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 184.92m,
                PricePerWeekday = 92.51m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 12.82m,
                NumberOfBeds = 7,
                NumberOfBaths = 8,
                NumberOfGuestsAllowed = 13,
                Status = pStatus.Active
            };
            p3119.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3119);

            // Add Property p3120
            Property p3120 = new Property()
            {
                PropertyNumber = 3120,
                ZipCode = "18885",
                State = StateList.NY,
                StreetAddress = "559 Foster Locks Suite 933",
                AptNum = null,
                City = "Robinsonhaven",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 225.85m,
                PricePerWeekday = 224.62m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 17.9m,
                NumberOfBeds = 6,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 6,
                Status = pStatus.Active
            };
            p3120.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3120);

            // Add Property p3121
            Property p3121 = new Property()
            {
                PropertyNumber = 3121,
                ZipCode = "00638",
                State = StateList.WY,
                StreetAddress = "4647 Kristine Fields Suite 710",
                AptNum = null,
                City = "New Dakota",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 174.02m,
                PricePerWeekday = 112.61m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 17.48m,
                NumberOfBeds = 1,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 10,
                Status = pStatus.Active
            };
            p3121.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3121);

            // Add Property p3122
            Property p3122 = new Property()
            {
                PropertyNumber = 3122,
                ZipCode = "31451",
                State = StateList.ME,
                StreetAddress = "92594 Emily Shoals",
                AptNum = null,
                City = "North Cathyburgh",
                HostEmail = "rankin@yahoo.com",
                PricePerWeekend = 119.06m,
                PricePerWeekday = 189.98m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 25.11m,
                NumberOfBeds = 6,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3122.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3122);

            // Add Property p3123
            Property p3123 = new Property()
            {
                PropertyNumber = 3123,
                ZipCode = "26297",
                State = StateList.MS,
                StreetAddress = "551 Casey Squares Apt. 209",
                AptNum = null,
                City = "Michaelborough",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 114.73m,
                PricePerWeekday = 72.03m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 18.38m,
                NumberOfBeds = 1,
                NumberOfBaths = 1,
                NumberOfGuestsAllowed = 6,
                Status = pStatus.Active
            };
            p3123.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3123);

            // Add Property p3124
            Property p3124 = new Property()
            {
                PropertyNumber = 3124,
                ZipCode = "04610",
                State = StateList.PA,
                StreetAddress = "2998 Willis Wall",
                AptNum = null,
                City = "North Brian",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 144.51m,
                PricePerWeekday = 216.21m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 10.81m,
                NumberOfBeds = 3,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.Active
            };
            p3124.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3124);

            // Add Property p3125
            Property p3125 = new Property()
            {
                PropertyNumber = 3125,
                ZipCode = "86618",
                State = StateList.MD,
                StreetAddress = "164 Schultz Road",
                AptNum = null,
                City = "Lake Bryan",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 233.9m,
                PricePerWeekday = 132.69m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 15.8m,
                NumberOfBeds = 5,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 13,
                Status = pStatus.Active
            };
            p3125.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3125);

            // Add Property p3126
            Property p3126 = new Property()
            {
                PropertyNumber = 3126,
                ZipCode = "80124",
                State = StateList.GA,
                StreetAddress = "9541 Brock Estate Apt. 848",
                AptNum = null,
                City = "Franklinchester",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 285.05m,
                PricePerWeekday = 220.97m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 20.98m,
                NumberOfBeds = 2,
                NumberOfBaths = 1,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3126.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3126);

            // Add Property p3127
            Property p3127 = new Property()
            {
                PropertyNumber = 3127,
                ZipCode = "63590",
                State = StateList.MS,
                StreetAddress = "588 Alan Rest",
                AptNum = null,
                City = "Port Stephanieville",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 180.86m,
                PricePerWeekday = 224.98m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 11.91m,
                NumberOfBeds = 6,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 12,
                Status = pStatus.Active
            };
            p3127.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3127);

            // Add Property p3128
            Property p3128 = new Property()
            {
                PropertyNumber = 3128,
                ZipCode = "53548",
                State = StateList.MT,
                StreetAddress = "216 Brandon Loop Apt. 096",
                AptNum = null,
                City = "New Jessica",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 239.97m,
                PricePerWeekday = 221.98m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 9.24m,
                NumberOfBeds = 5,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 12,
                Status = pStatus.Active
            };
            p3128.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3128);

            // Add Property p3129
            Property p3129 = new Property()
            {
                PropertyNumber = 3129,
                ZipCode = "35611",
                State = StateList.LA,
                StreetAddress = "782 Dawn Radial",
                AptNum = null,
                City = "Port Christopher",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 297.25m,
                PricePerWeekday = 76.56m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 20.42m,
                NumberOfBeds = 1,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3129.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3129);

            // Add Property p3130
            Property p3130 = new Property()
            {
                PropertyNumber = 3130,
                ZipCode = "42879",
                State = StateList.WA,
                StreetAddress = "008 Nancy Route Suite 228",
                AptNum = null,
                City = "North Stephanie",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 129.36m,
                PricePerWeekday = 128.71m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 23.76m,
                NumberOfBeds = 2,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.Active
            };
            p3130.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3130);

            // Add Property p3131
            Property p3131 = new Property()
            {
                PropertyNumber = 3131,
                ZipCode = "71569",
                State = StateList.MO,
                StreetAddress = "115 Jon Isle Suite 788",
                AptNum = null,
                City = "North Lesliefurt",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 210.63m,
                PricePerWeekday = 114.21m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 21.08m,
                NumberOfBeds = 1,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3131.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3131);

            // Add Property p3132
            Property p3132 = new Property()
            {
                PropertyNumber = 3132,
                ZipCode = "87566",
                State = StateList.DE,
                StreetAddress = "132 Poole Pass Suite 212",
                AptNum = null,
                City = "North Patrick",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 280.37m,
                PricePerWeekday = 146.82m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 26.78m,
                NumberOfBeds = 5,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 11,
                Status = pStatus.Active
            };
            p3132.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3132);

            // Add Property p3133
            Property p3133 = new Property()
            {
                PropertyNumber = 3133,
                ZipCode = "67652",
                State = StateList.WY,
                StreetAddress = "457 Vargas Island Suite 853",
                AptNum = null,
                City = "Lake Patrickstad",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 249.39m,
                PricePerWeekday = 134.72m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 19.19m,
                NumberOfBeds = 4,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3133.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3133);

            // Add Property p3134
            Property p3134 = new Property()
            {
                PropertyNumber = 3134,
                ZipCode = "45184",
                State = StateList.HI,
                StreetAddress = "1569 Amy Path",
                AptNum = null,
                City = "North Ashleyton",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 111.23m,
                PricePerWeekday = 111.6m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 13.48m,
                NumberOfBeds = 7,
                NumberOfBaths = 8,
                NumberOfGuestsAllowed = 7,
                Status = pStatus.Active
            };
            p3134.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3134);

            // Add Property p3135
            Property p3135 = new Property()
            {
                PropertyNumber = 3135,
                ZipCode = "04078",
                State = StateList.IL,
                StreetAddress = "0375 Sandra Trace Suite 826",
                AptNum = null,
                City = "Gailshire",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 168.47m,
                PricePerWeekday = 89.0m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 14.93m,
                NumberOfBeds = 5,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.Active
            };
            p3135.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3135);

            // Add Property p3136
            Property p3136 = new Property()
            {
                PropertyNumber = 3136,
                ZipCode = "50437",
                State = StateList.MN,
                StreetAddress = "759 Good Port",
                AptNum = null,
                City = "New Russell",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 208.35m,
                PricePerWeekday = 208.64m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 7.09m,
                NumberOfBeds = 5,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 6,
                Status = pStatus.Active
            };
            p3136.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3136);

            // Add Property p3137
            Property p3137 = new Property()
            {
                PropertyNumber = 3137,
                ZipCode = "34147",
                State = StateList.WV,
                StreetAddress = "3895 Allen Junction",
                AptNum = null,
                City = "West John",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 195.41m,
                PricePerWeekday = 172.51m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 21.53m,
                NumberOfBeds = 5,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.Active
            };
            p3137.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3137);

            // Add Property p3138
            Property p3138 = new Property()
            {
                PropertyNumber = 3138,
                ZipCode = "36340",
                State = StateList.MS,
                StreetAddress = "7329 Jacobs Station",
                AptNum = null,
                City = "New Tylerborough",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 146.12m,
                PricePerWeekday = 163.15m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 18.98m,
                NumberOfBeds = 1,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 8,
                Status = pStatus.Active
            };
            p3138.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3138);

            // Add Property p3139
            Property p3139 = new Property()
            {
                PropertyNumber = 3139,
                ZipCode = "88806",
                State = StateList.MD,
                StreetAddress = "5003 Cassandra Estates Suite 148",
                AptNum = null,
                City = "Haleychester",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 161.49m,
                PricePerWeekday = 81.5m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 16.41m,
                NumberOfBeds = 7,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3139.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3139);

            // Add Property p3140
            Property p3140 = new Property()
            {
                PropertyNumber = 3140,
                ZipCode = "76853",
                State = StateList.TN,
                StreetAddress = "10524 Parker Mall Suite 531",
                AptNum = null,
                City = "Port Courtneyhaven",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 120.73m,
                PricePerWeekday = 177.94m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 9.5m,
                NumberOfBeds = 5,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 13,
                Status = pStatus.Active
            };
            p3140.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Hotel");
            Properties.Add(p3140);

            // Add Property p3141
            Property p3141 = new Property()
            {
                PropertyNumber = 3141,
                ZipCode = "93533",
                State = StateList.MO,
                StreetAddress = "300 Madison Stream",
                AptNum = null,
                City = "Christophershire",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 187.08m,
                PricePerWeekday = 121.01m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 16.48m,
                NumberOfBeds = 3,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 6,
                Status = pStatus.Active
            };
            p3141.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3141);

            // Add Property p3142
            Property p3142 = new Property()
            {
                PropertyNumber = 3142,
                ZipCode = "96763",
                State = StateList.FL,
                StreetAddress = "4229 Derrick Wells",
                AptNum = null,
                City = "West Tyler",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 241.45m,
                PricePerWeekday = 199.68m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 25.94m,
                NumberOfBeds = 2,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 6,
                Status = pStatus.Active
            };
            p3142.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3142);

            // Add Property p3143
            Property p3143 = new Property()
            {
                PropertyNumber = 3143,
                ZipCode = "92174",
                State = StateList.VA,
                StreetAddress = "26239 Michael Shoals",
                AptNum = null,
                City = "Gregoryview",
                HostEmail = "morales@aol.com",
                PricePerWeekend = 111.91m,
                PricePerWeekday = 162.01m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 14.35m,
                NumberOfBeds = 1,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3143.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3143);

            // Add Property p3144
            Property p3144 = new Property()
            {
                PropertyNumber = 3144,
                ZipCode = "88294",
                State = StateList.IN,
                StreetAddress = "302 Joy Spring Apt. 622",
                AptNum = null,
                City = "Ryanhaven",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 163.73m,
                PricePerWeekday = 173.36m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 25.35m,
                NumberOfBeds = 1,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 12,
                Status = pStatus.Active
            };
            p3144.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3144);

            // Add Property p3145
            Property p3145 = new Property()
            {
                PropertyNumber = 3145,
                ZipCode = "23464",
                State = StateList.CA,
                StreetAddress = "734 Craig Overpass Suite 589",
                AptNum = null,
                City = "Jefferyside",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 287.28m,
                PricePerWeekday = 216.1m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 22.2m,
                NumberOfBeds = 1,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 8,
                Status = pStatus.Active
            };
            p3145.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3145);

            // Add Property p3146
            Property p3146 = new Property()
            {
                PropertyNumber = 3146,
                ZipCode = "35243",
                State = StateList.CA,
                StreetAddress = "272 Green Street",
                AptNum = null,
                City = "Port Lacey",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 247.34m,
                PricePerWeekday = 211.51m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 11.73m,
                NumberOfBeds = 4,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 7,
                Status = pStatus.Active
            };
            p3146.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3146);

            // Add Property p3147
            Property p3147 = new Property()
            {
                PropertyNumber = 3147,
                ZipCode = "61935",
                State = StateList.IL,
                StreetAddress = "8056 Dunn Trail Apt. 049",
                AptNum = null,
                City = "Blackshire",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 189.08m,
                PricePerWeekday = 111.4m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 19.58m,
                NumberOfBeds = 5,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 2,
                Status = pStatus.Active
            };
            p3147.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3147);

            // Add Property p3148
            Property p3148 = new Property()
            {
                PropertyNumber = 3148,
                ZipCode = "72324",
                State = StateList.CA,
                StreetAddress = "86187 Antonio Fort",
                AptNum = null,
                City = "North Carmen",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 109.87m,
                PricePerWeekday = 150.69m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 13.3m,
                NumberOfBeds = 7,
                NumberOfBaths = 9,
                NumberOfGuestsAllowed = 7,
                Status = pStatus.Active
            };
            p3148.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3148);

            // Add Property p3149
            Property p3149 = new Property()
            {
                PropertyNumber = 3149,
                ZipCode = "84393",
                State = StateList.NJ,
                StreetAddress = "71318 Cassandra Plaza",
                AptNum = null,
                City = "Burkeview",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 227.55m,
                PricePerWeekday = 184.21m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 19.52m,
                NumberOfBeds = 7,
                NumberOfBaths = 7,
                NumberOfGuestsAllowed = 10,
                Status = pStatus.Active
            };
            p3149.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3149);

            // Add Property p3150
            Property p3150 = new Property()
            {
                PropertyNumber = 3150,
                ZipCode = "62346",
                State = StateList.NH,
                StreetAddress = "5303 Lewis Springs",
                AptNum = null,
                City = "Port Adrian",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 207.51m,
                PricePerWeekday = 204.67m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 26.36m,
                NumberOfBeds = 2,
                NumberOfBaths = 1,
                NumberOfGuestsAllowed = 2,
                Status = pStatus.Active
            };
            p3150.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3150);

            // Add Property p3151
            Property p3151 = new Property()
            {
                PropertyNumber = 3151,
                ZipCode = "02837",
                State = StateList.IA,
                StreetAddress = "465 Wiley Corners Apt. 759",
                AptNum = null,
                City = "East Michellechester",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 213.84m,
                PricePerWeekday = 129.14m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 12.81m,
                NumberOfBeds = 6,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 11,
                Status = pStatus.Active
            };
            p3151.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3151);

            // Add Property p3152
            Property p3152 = new Property()
            {
                PropertyNumber = 3152,
                ZipCode = "68847",
                State = StateList.LA,
                StreetAddress = "521 Flores Stream",
                AptNum = null,
                City = "West Rebeccaborough",
                HostEmail = "rankin@yahoo.com",
                PricePerWeekend = 254.37m,
                PricePerWeekday = 77.06m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 6.03m,
                NumberOfBeds = 3,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.Active
            };
            p3152.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3152);

            // Add Property p3153
            Property p3153 = new Property()
            {
                PropertyNumber = 3153,
                ZipCode = "35218",
                State = StateList.NE,
                StreetAddress = "0271 Soto Drives Apt. 975",
                AptNum = null,
                City = "New Edgar",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 233.17m,
                PricePerWeekday = 179.91m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 11.04m,
                NumberOfBeds = 4,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3153.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3153);

            // Add Property p3154
            Property p3154 = new Property()
            {
                PropertyNumber = 3154,
                ZipCode = "32697",
                State = StateList.NM,
                StreetAddress = "27862 Kent Mountains",
                AptNum = null,
                City = "Lake Michaelville",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 153.38m,
                PricePerWeekday = 90.54m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 6.91m,
                NumberOfBeds = 6,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 14,
                Status = pStatus.Active
            };
            p3154.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3154);

            // Add Property p3155
            Property p3155 = new Property()
            {
                PropertyNumber = 3155,
                ZipCode = "95889",
                State = StateList.OR,
                StreetAddress = "917 Mclaughlin Glens",
                AptNum = null,
                City = "Martinville",
                HostEmail = "rankin@yahoo.com",
                PricePerWeekend = 226.89m,
                PricePerWeekday = 225.59m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 28.99m,
                NumberOfBeds = 7,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 2,
                Status = pStatus.Active
            };
            p3155.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3155);

            // Add Property p3156
            Property p3156 = new Property()
            {
                PropertyNumber = 3156,
                ZipCode = "82153",
                State = StateList.KY,
                StreetAddress = "3032 Michelle Drives",
                AptNum = null,
                City = "North Daniel",
                HostEmail = "rankin@yahoo.com",
                PricePerWeekend = 157.15m,
                PricePerWeekday = 203.25m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 15.68m,
                NumberOfBeds = 3,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 13,
                Status = pStatus.Active
            };
            p3156.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3156);

            // Add Property p3157
            Property p3157 = new Property()
            {
                PropertyNumber = 3157,
                ZipCode = "32202",
                State = StateList.SD,
                StreetAddress = "601 Maria Mission Apt. 554",
                AptNum = null,
                City = "Myerstown",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 269.55m,
                PricePerWeekday = 223.27m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 11.35m,
                NumberOfBeds = 7,
                NumberOfBaths = 9,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3157.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3157);

            // Add Property p3158
            Property p3158 = new Property()
            {
                PropertyNumber = 3158,
                ZipCode = "17431",
                State = StateList.OH,
                StreetAddress = "238 Shawn Well",
                AptNum = null,
                City = "Port Johnshire",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 112.64m,
                PricePerWeekday = 173.63m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 6.38m,
                NumberOfBeds = 7,
                NumberOfBaths = 8,
                NumberOfGuestsAllowed = 14,
                Status = pStatus.Active
            };
            p3158.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3158);

            // Add Property p3159
            Property p3159 = new Property()
            {
                PropertyNumber = 3159,
                ZipCode = "37901",
                State = StateList.SC,
                StreetAddress = "41743 Berger Inlet Apt. 527",
                AptNum = null,
                City = "South Tammymouth",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 163.2m,
                PricePerWeekday = 176.23m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 14.77m,
                NumberOfBeds = 7,
                NumberOfBaths = 9,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3159.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3159);

            // Add Property p3160
            Property p3160 = new Property()
            {
                PropertyNumber = 3160,
                ZipCode = "17895",
                State = StateList.MO,
                StreetAddress = "9983 Mary Grove Apt. 643",
                AptNum = null,
                City = "Beardview",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 209.33m,
                PricePerWeekday = 219.53m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 24.51m,
                NumberOfBeds = 7,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3160.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3160);

            // Add Property p3161
            Property p3161 = new Property()
            {
                PropertyNumber = 3161,
                ZipCode = "90576",
                State = StateList.HI,
                StreetAddress = "03541 Ryan Islands Apt. 562",
                AptNum = null,
                City = "East Michaelfort",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 269.63m,
                PricePerWeekday = 126.25m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 8.27m,
                NumberOfBeds = 1,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 10,
                Status = pStatus.Active
            };
            p3161.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3161);

            // Add Property p3162
            Property p3162 = new Property()
            {
                PropertyNumber = 3162,
                ZipCode = "94980",
                State = StateList.SC,
                StreetAddress = "6591 Angela Mission Apt. 108",
                AptNum = null,
                City = "Penabury",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 286.86m,
                PricePerWeekday = 143.98m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 20.48m,
                NumberOfBeds = 5,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 14,
                Status = pStatus.Active
            };
            p3162.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3162);

            // Add Property p3163
            Property p3163 = new Property()
            {
                PropertyNumber = 3163,
                ZipCode = "44974",
                State = StateList.CO,
                StreetAddress = "492 Ramirez Crossing",
                AptNum = null,
                City = "Aaronberg",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 144.6m,
                PricePerWeekday = 121.91m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 10.12m,
                NumberOfBeds = 1,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 10,
                Status = pStatus.Active
            };
            p3163.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3163);

            // Add Property p3164
            Property p3164 = new Property()
            {
                PropertyNumber = 3164,
                ZipCode = "66170",
                State = StateList.DE,
                StreetAddress = "35974 Sharon Locks Apt. 101",
                AptNum = null,
                City = "Jennyport",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 114.46m,
                PricePerWeekday = 137.8m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 17.74m,
                NumberOfBeds = 7,
                NumberOfBaths = 9,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3164.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3164);

            // Add Property p3165
            Property p3165 = new Property()
            {
                PropertyNumber = 3165,
                ZipCode = "22495",
                State = StateList.UT,
                StreetAddress = "89403 Gabriella Mills",
                AptNum = null,
                City = "East Steven",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 155.1m,
                PricePerWeekday = 128.63m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 23.05m,
                NumberOfBeds = 3,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 11,
                Status = pStatus.Active
            };
            p3165.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3165);

            // Add Property p3166
            Property p3166 = new Property()
            {
                PropertyNumber = 3166,
                ZipCode = "85059",
                State = StateList.NH,
                StreetAddress = "601 Kyle Roads",
                AptNum = null,
                City = "Clarkfurt",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 284.39m,
                PricePerWeekday = 209.11m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 6.25m,
                NumberOfBeds = 4,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 4,
                Status = pStatus.Active
            };
            p3166.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3166);

            // Add Property p3167
            Property p3167 = new Property()
            {
                PropertyNumber = 3167,
                ZipCode = "61092",
                State = StateList.IN,
                StreetAddress = "60969 Justin Passage Suite 774",
                AptNum = null,
                City = "Joshuaburgh",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 121.0m,
                PricePerWeekday = 128.59m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 19.36m,
                NumberOfBeds = 1,
                NumberOfBaths = 1,
                NumberOfGuestsAllowed = 7,
                Status = pStatus.Active
            };
            p3167.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3167);

            // Add Property p3168
            Property p3168 = new Property()
            {
                PropertyNumber = 3168,
                ZipCode = "43986",
                State = StateList.PA,
                StreetAddress = "7943 Tina Mount",
                AptNum = null,
                City = "East Lisa",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 104.47m,
                PricePerWeekday = 122.88m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 25.31m,
                NumberOfBeds = 4,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 14,
                Status = pStatus.Active
            };
            p3168.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3168);

            // Add Property p3169
            Property p3169 = new Property()
            {
                PropertyNumber = 3169,
                ZipCode = "91397",
                State = StateList.NC,
                StreetAddress = "6775 James Ford",
                AptNum = null,
                City = "South Victorialand",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 275.5m,
                PricePerWeekday = 211.24m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 15.74m,
                NumberOfBeds = 1,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3169.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3169);

            // Add Property p3170
            Property p3170 = new Property()
            {
                PropertyNumber = 3170,
                ZipCode = "67849",
                State = StateList.VT,
                StreetAddress = "431 Johnson Neck Suite 039",
                AptNum = null,
                City = "Mariechester",
                HostEmail = "rice@yahoo.com",
                PricePerWeekend = 126.24m,
                PricePerWeekday = 124.65m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 24.3m,
                NumberOfBeds = 1,
                NumberOfBaths = 1,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3170.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3170);

            // Add Property p3171
            Property p3171 = new Property()
            {
                PropertyNumber = 3171,
                ZipCode = "20687",
                State = StateList.NM,
                StreetAddress = "15666 Justin Locks",
                AptNum = null,
                City = "Lake Ryanport",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 112.05m,
                PricePerWeekday = 70.11m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 27.45m,
                NumberOfBeds = 6,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.Active
            };
            p3171.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3171);

            // Add Property p3172
            Property p3172 = new Property()
            {
                PropertyNumber = 3172,
                ZipCode = "30222",
                State = StateList.TX,
                StreetAddress = "9947 Torres Viaduct Apt. 506",
                AptNum = null,
                City = "Benjaminport",
                HostEmail = "ingram@gmail.com",
                PricePerWeekend = 152.09m,
                PricePerWeekday = 174.87m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 18.44m,
                NumberOfBeds = 1,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 11,
                Status = pStatus.Active
            };
            p3172.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Apartment");
            Properties.Add(p3172);

            // Add Property p3173
            Property p3173 = new Property()
            {
                PropertyNumber = 3173,
                ZipCode = "21190",
                State = StateList.NJ,
                StreetAddress = "20866 Keith Mill",
                AptNum = null,
                City = "Susanton",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 174.06m,
                PricePerWeekday = 96.8m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 28.15m,
                NumberOfBeds = 2,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 10,
                Status = pStatus.Active
            };
            p3173.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3173);

            // Add Property p3174
            Property p3174 = new Property()
            {
                PropertyNumber = 3174,
                ZipCode = "04838",
                State = StateList.AL,
                StreetAddress = "04374 Nicholas Cliff Suite 001",
                AptNum = null,
                City = "Adrianport",
                HostEmail = "jacobs@yahoo.com",
                PricePerWeekend = 108.24m,
                PricePerWeekday = 205.01m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 6.56m,
                NumberOfBeds = 1,
                NumberOfBaths = 1,
                NumberOfGuestsAllowed = 10,
                Status = pStatus.Active
            };
            p3174.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Condo");
            Properties.Add(p3174);

            // Add Property p3175
            Property p3175 = new Property()
            {
                PropertyNumber = 3175,
                ZipCode = "80130",
                State = StateList.CA,
                StreetAddress = "271 Andrew Summit",
                AptNum = null,
                City = "Port Craig",
                HostEmail = "gonzalez@aol.com",
                PricePerWeekend = 148.39m,
                PricePerWeekday = 197.52m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 20.55m,
                NumberOfBeds = 7,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 7,
                Status = pStatus.notActive
            };
            p3175.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3175);

            // Add Property p3176
            Property p3176 = new Property()
            {
                PropertyNumber = 3176,
                ZipCode = "96166",
                State = StateList.MN,
                StreetAddress = "17611 Robbins Mission",
                AptNum = null,
                City = "New Curtis",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 286.13m,
                PricePerWeekday = 219.69m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 10.64m,
                NumberOfBeds = 3,
                NumberOfBaths = 3,
                NumberOfGuestsAllowed = 9,
                Status = pStatus.Active
            };
            p3176.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3176);

            // Add Property p3177
            Property p3177 = new Property()
            {
                PropertyNumber = 3177,
                ZipCode = "40702",
                State = StateList.MO,
                StreetAddress = "80831 Kemp Pines",
                AptNum = null,
                City = "Annashire",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 123.93m,
                PricePerWeekday = 91.26m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 19.36m,
                NumberOfBeds = 1,
                NumberOfBaths = 2,
                NumberOfGuestsAllowed = 7,
                Status = pStatus.Active
            };
            p3177.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3177);

            // Add Property p3178
            Property p3178 = new Property()
            {
                PropertyNumber = 3178,
                ZipCode = "86023",
                State = StateList.IL,
                StreetAddress = "96545 Smith Alley",
                AptNum = null,
                City = "West Joy",
                HostEmail = "martinez@aol.com",
                PricePerWeekend = 254.38m,
                PricePerWeekday = 132.54m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 14.83m,
                NumberOfBeds = 6,
                NumberOfBaths = 8,
                NumberOfGuestsAllowed = 7,
                Status = pStatus.Active
            };
            p3178.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3178);

            // Add Property p3179
            Property p3179 = new Property()
            {
                PropertyNumber = 3179,
                ZipCode = "70897",
                State = StateList.MT,
                StreetAddress = "6146 Johnson Isle",
                AptNum = null,
                City = "South Arthur",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 228.04m,
                PricePerWeekday = 227.96m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 6.99m,
                NumberOfBeds = 2,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3179.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3179);

            // Add Property p3180
            Property p3180 = new Property()
            {
                PropertyNumber = 3180,
                ZipCode = "69154",
                State = StateList.MN,
                StreetAddress = "0415 Smith Springs",
                AptNum = null,
                City = "Jeremyburgh",
                HostEmail = "loter@yahoo.com",
                PricePerWeekend = 228.81m,
                PricePerWeekday = 140.93m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 29.74m,
                NumberOfBeds = 4,
                NumberOfBaths = 4,
                NumberOfGuestsAllowed = 3,
                Status = pStatus.Active
            };
            p3180.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3180);

            // Add Property p3181
            Property p3181 = new Property()
            {
                PropertyNumber = 3181,
                ZipCode = "53524",
                State = StateList.HI,
                StreetAddress = "3999 Ricky Via",
                AptNum = null,
                City = "West Adamburgh",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 255.43m,
                PricePerWeekday = 137.35m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.Yes,
                CleaningFee = 16.62m,
                NumberOfBeds = 7,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 6,
                Status = pStatus.Active
            };
            p3181.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "House");
            Properties.Add(p3181);

            // Add Property p3182
            Property p3182 = new Property()
            {
                PropertyNumber = 3182,
                ZipCode = "24886",
                State = StateList.MN,
                StreetAddress = "83787 Stuart Key",
                AptNum = null,
                City = "Davetown",
                HostEmail = "chung@yahoo.com",
                PricePerWeekend = 146.75m,
                PricePerWeekday = 172.99m,
                PetsAllowed = YesNo.Yes,
                ParkingAllowed = YesNo.No,
                CleaningFee = 26.24m,
                NumberOfBeds = 7,
                NumberOfBaths = 6,
                NumberOfGuestsAllowed = 4,
                Status = pStatus.notActive
            };
            p3182.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3182);

            // Add Property p3183
            Property p3183 = new Property()
            {
                PropertyNumber = 3183,
                ZipCode = "56713",
                State = StateList.TX,
                StreetAddress = "690 Christina Park",
                AptNum = null,
                City = "Toddburgh",
                HostEmail = "tanner@utexas.edu",
                PricePerWeekend = 157.96m,
                PricePerWeekday = 188.53m,
                PetsAllowed = YesNo.No,
                ParkingAllowed = YesNo.No,
                CleaningFee = 6.69m,
                NumberOfBeds = 3,
                NumberOfBaths = 5,
                NumberOfGuestsAllowed = 1,
                Status = pStatus.Active
            };
            p3183.Category = context.Categories.FirstOrDefault(p => p.CategoryName == "Cabin");
            Properties.Add(p3183);

            // Add all properties to the context
            context.Properties.AddRange(Properties);

            // Save changes to the database
            await context.SaveChangesAsync();
            Console.WriteLine("Properties seeded successfully.");
        }
    }
}
