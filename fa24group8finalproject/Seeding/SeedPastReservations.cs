
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using fa24group8finalproject.DAL;
using fa24group8finalproject.Models;

namespace fa24group8finalproject.Seeding
{
    public static class SeedingReservations
    {
        public static async Task SeedReservations(AppDbContext context)
        {
            // Create a list of reservations
            List<Reservation> Reservations = new List<Reservation>();

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3133),
                CheckInDate = new DateTime(2024, 11, 1),
                CheckOutDate = new DateTime(2024, 11, 3),
                NumberOfGuests = 1,
                PricePerWeekday = 134.72m,
                PricePerWeekend = 249.39m,
                CleaningFee = 19.19m,
                Discount = 0.0m,
                Status = rStatus.Past,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "sheff44@puppy.com")?.Id,
                ConfirmationNumber = 21900
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3150),
                CheckInDate = new DateTime(2024, 11, 4),
                CheckOutDate = new DateTime(2024, 11, 6),
                NumberOfGuests = 2,
                PricePerWeekday = 204.67m,
                PricePerWeekend = 207.51m,
                CleaningFee = 26.36m,
                Discount = 0.2172819653377785m,
                Status = rStatus.Past,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "luce_chuck@puppy.com")?.Id,
                ConfirmationNumber = 21901
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3116),
                CheckInDate = new DateTime(2024, 11, 6),
                CheckOutDate = new DateTime(2024, 11, 10),
                NumberOfGuests = 14,
                PricePerWeekday = 163.3m,
                PricePerWeekend = 262.77m,
                CleaningFee = 13.74m,
                Discount = 0.15783334197277493m,
                Status = rStatus.Cancelled,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "luce_chuck@puppy.com")?.Id,
                ConfirmationNumber = 21901
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3133),
                CheckInDate = new DateTime(2024, 11, 7),
                CheckOutDate = new DateTime(2024, 11, 12),
                NumberOfGuests = 1,
                PricePerWeekday = 134.72m,
                PricePerWeekend = 249.39m,
                CleaningFee = 19.19m,
                Discount = 0.0m,
                Status = rStatus.Past,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "lamemartin.martin@aool.com")?.Id,
                ConfirmationNumber = 21902
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3067),
                CheckInDate = new DateTime(2024, 11, 6),
                CheckOutDate = new DateTime(2024, 11, 18),
                NumberOfGuests = 9,
                PricePerWeekday = 163.68m,
                PricePerWeekend = 286.53m,
                CleaningFee = 25.57m,
                Discount = 0.0m,
                Status = rStatus.Past,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "tuck33@puppy.com")?.Id,
                ConfirmationNumber = 21903
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3075),
                CheckInDate = new DateTime(2024, 11, 7),
                CheckOutDate = new DateTime(2024, 11, 15),
                NumberOfGuests = 3,
                PricePerWeekday = 147.55m,
                PricePerWeekend = 209.77m,
                CleaningFee = 27.65m,
                Discount = 0.087890398442729m,
                Status = rStatus.Past,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "liz@puppy.com")?.Id,
                ConfirmationNumber = 21904
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3127),
                CheckInDate = new DateTime(2024, 11, 17),
                CheckOutDate = new DateTime(2024, 11, 22),
                NumberOfGuests = 12,
                PricePerWeekday = 224.98m,
                PricePerWeekend = 180.86m,
                CleaningFee = 11.91m,
                Discount = 0.0m,
                Status = rStatus.Past,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "orielly@foxnets.com")?.Id,
                ConfirmationNumber = 21905
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3133),
                CheckInDate = new DateTime(2024, 11, 22),
                CheckOutDate = new DateTime(2024, 11, 27),
                NumberOfGuests = 1,
                PricePerWeekday = 134.72m,
                PricePerWeekend = 249.39m,
                CleaningFee = 19.19m,
                Discount = 0.0m,
                Status = rStatus.Past,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "orielly@foxnets.com")?.Id,
                ConfirmationNumber = 21906
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3082),
                CheckInDate = new DateTime(2024, 11, 23),
                CheckOutDate = new DateTime(2024, 12, 1),
                NumberOfGuests = 5,
                PricePerWeekday = 93.35m,
                PricePerWeekend = 271.49m,
                CleaningFee = 8.54m,
                Discount = 0.17515031842671308m,
                Status = rStatus.Active,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "elowe@netscrape.net")?.Id,
                ConfirmationNumber = 21907
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3172),
                CheckInDate = new DateTime(2024, 11, 24),
                CheckOutDate = new DateTime(2024, 12, 4),
                NumberOfGuests = 11,
                PricePerWeekday = 174.87m,
                PricePerWeekend = 152.09m,
                CleaningFee = 18.44m,
                Discount = 0.07725655928579118m,
                Status = rStatus.Active,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "victoria@puppy.com")?.Id,
                ConfirmationNumber = 21908
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3056),
                CheckInDate = new DateTime(2024, 11, 29),
                CheckOutDate = new DateTime(2024, 12, 18),
                NumberOfGuests = 10,
                PricePerWeekday = 117.45m,
                PricePerWeekend = 167.53m,
                CleaningFee = 24.75m,
                Discount = 0.16765499120781757m,
                Status = rStatus.Cancelled,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "wjhearniii@umch.edu")?.Id,
                ConfirmationNumber = 21909
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3065),
                CheckInDate = new DateTime(2024, 11, 28),
                CheckOutDate = new DateTime(2024, 12, 1),
                NumberOfGuests = 13,
                PricePerWeekday = 155.03m,
                PricePerWeekend = 139.83m,
                CleaningFee = 21.05m,
                Discount = 0.09495617203701066m,
                Status = rStatus.Active,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "fd@puppy.com")?.Id,
                ConfirmationNumber = 21910
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3067),
                CheckInDate = new DateTime(2024, 11, 1),
                CheckOutDate = new DateTime(2024, 11, 5),
                NumberOfGuests = 9,
                PricePerWeekday = 163.68m,
                PricePerWeekend = 286.53m,
                CleaningFee = 25.57m,
                Discount = 0.0m,
                Status = rStatus.Past,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "tfreeley@puppy.com")?.Id,
                ConfirmationNumber = 21911
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3094),
                CheckInDate = new DateTime(2024, 11, 15),
                CheckOutDate = new DateTime(2024, 12, 1),
                NumberOfGuests = 14,
                PricePerWeekday = 215.38m,
                PricePerWeekend = 117.17m,
                CleaningFee = 24.31m,
                Discount = 0.0m,
                Status = rStatus.Cancelled,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "wendy@puppy.com")?.Id,
                ConfirmationNumber = 21912
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3148),
                CheckInDate = new DateTime(2024, 11, 5),
                CheckOutDate = new DateTime(2024, 12, 3),
                NumberOfGuests = 7,
                PricePerWeekday = 150.69m,
                PricePerWeekend = 109.87m,
                CleaningFee = 13.3m,
                Discount = 0.0m,
                Status = rStatus.Active,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "444444.dave@aool.com")?.Id,
                ConfirmationNumber = 21913
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3127),
                CheckInDate = new DateTime(2024, 11, 1),
                CheckOutDate = new DateTime(2024, 11, 16),
                NumberOfGuests = 12,
                PricePerWeekday = 224.98m,
                PricePerWeekend = 180.86m,
                CleaningFee = 11.91m,
                Discount = 0.0m,
                Status = rStatus.Past,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "father.ingram@aool.com")?.Id,
                ConfirmationNumber = 21914
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3085),
                CheckInDate = new DateTime(2024, 12, 8),
                CheckOutDate = new DateTime(2024, 12, 10),
                NumberOfGuests = 11,
                PricePerWeekday = 194.84m,
                PricePerWeekend = 278.17m,
                CleaningFee = 5.88m,
                Discount = 0.0m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "orielly@foxnets.com")?.Id,
                ConfirmationNumber = 21915
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3180),
                CheckInDate = new DateTime(2024, 12, 9),
                CheckOutDate = new DateTime(2024, 12, 11),
                NumberOfGuests = 3,
                PricePerWeekday = 140.93m,
                PricePerWeekend = 228.81m,
                CleaningFee = 29.74m,
                Discount = 0.15023775787043414m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "hicks43@puppy.com")?.Id,
                ConfirmationNumber = 21916
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3161),
                CheckInDate = new DateTime(2024, 12, 2),
                CheckOutDate = new DateTime(2024, 12, 5),
                NumberOfGuests = 10,
                PricePerWeekday = 126.25m,
                PricePerWeekend = 269.63m,
                CleaningFee = 8.27m,
                Discount = 0.16075149978012182m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "orielly@foxnets.com")?.Id,
                ConfirmationNumber = 21917
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3085),
                CheckInDate = new DateTime(2024, 12, 1),
                CheckOutDate = new DateTime(2024, 12, 4),
                NumberOfGuests = 11,
                PricePerWeekday = 194.84m,
                PricePerWeekend = 278.17m,
                CleaningFee = 5.88m,
                Discount = 0.0m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "sheff44@puppy.com")?.Id,
                ConfirmationNumber = 21918
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3021),
                CheckInDate = new DateTime(2024, 12, 8),
                CheckOutDate = new DateTime(2024, 12, 9),
                NumberOfGuests = 12,
                PricePerWeekday = 112.62m,
                PricePerWeekend = 165.32m,
                CleaningFee = 24.26m,
                Discount = 0.0m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "sheff44@puppy.com")?.Id,
                ConfirmationNumber = 21919
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3174),
                CheckInDate = new DateTime(2024, 12, 10),
                CheckOutDate = new DateTime(2024, 12, 11),
                NumberOfGuests = 10,
                PricePerWeekday = 205.01m,
                PricePerWeekend = 108.24m,
                CleaningFee = 6.56m,
                Discount = 0.0m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "sheff44@puppy.com")?.Id,
                ConfirmationNumber = 21919
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3005),
                CheckInDate = new DateTime(2024, 12, 9),
                CheckOutDate = new DateTime(2024, 12, 10),
                NumberOfGuests = 12,
                PricePerWeekday = 170.25m,
                PricePerWeekend = 100.37m,
                CleaningFee = 18.64m,
                Discount = 0.0m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "sheff44@puppy.com")?.Id,
                ConfirmationNumber = 21919
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3161),
                CheckInDate = new DateTime(2024, 11, 22),
                CheckOutDate = new DateTime(2024, 12, 1),
                NumberOfGuests = 10,
                PricePerWeekday = 126.25m,
                PricePerWeekend = 269.63m,
                CleaningFee = 8.27m,
                Discount = 0.16075149978012182m,
                Status = rStatus.Active,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "father.ingram@aool.com")?.Id,
                ConfirmationNumber = 21919
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3087),
                CheckInDate = new DateTime(2024, 12, 8),
                CheckOutDate = new DateTime(2024, 12, 12),
                NumberOfGuests = 1,
                PricePerWeekday = 127.97m,
                PricePerWeekend = 182.77m,
                CleaningFee = 13.02m,
                Discount = 0.17221234967106303m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "fd@puppy.com")?.Id,
                ConfirmationNumber = 21920
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3107),
                CheckInDate = new DateTime(2024, 12, 8),
                CheckOutDate = new DateTime(2024, 12, 12),
                NumberOfGuests = 8,
                PricePerWeekday = 83.34m,
                PricePerWeekend = 128.05m,
                CleaningFee = 11.29m,
                Discount = 0.20579577371388896m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "father.ingram@aool.com")?.Id,
                ConfirmationNumber = 21921
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3051),
                CheckInDate = new DateTime(2024, 12, 12),
                CheckOutDate = new DateTime(2024, 12, 15),
                NumberOfGuests = 10,
                PricePerWeekday = 204.04m,
                PricePerWeekend = 204.28m,
                CleaningFee = 11.07m,
                Discount = 0.0m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "father.ingram@aool.com")?.Id,
                ConfirmationNumber = 21921
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3073),
                CheckInDate = new DateTime(2024, 12, 7),
                CheckOutDate = new DateTime(2024, 12, 31),
                NumberOfGuests = 3,
                PricePerWeekday = 130.47m,
                PricePerWeekend = 196.09m,
                CleaningFee = 14.53m,
                Discount = 0.0m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "jeff@puppy.com")?.Id,
                ConfirmationNumber = 21923
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3097),
                CheckInDate = new DateTime(2024, 12, 11),
                CheckOutDate = new DateTime(2024, 12, 24),
                NumberOfGuests = 13,
                PricePerWeekday = 170.07m,
                PricePerWeekend = 176.37m,
                CleaningFee = 8.54m,
                Discount = 0.09092317764201632m,
                Status = rStatus.Cancelled,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "cmiller@mapster.com")?.Id,
                ConfirmationNumber = 21923
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3087),
                CheckInDate = new DateTime(2024, 11, 22),
                CheckOutDate = new DateTime(2024, 11, 29),
                NumberOfGuests = 1,
                PricePerWeekday = 127.97m,
                PricePerWeekend = 182.77m,
                CleaningFee = 13.02m,
                Discount = 0.17221234967106303m,
                Status = rStatus.Active,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "tuck33@puppy.com")?.Id,
                ConfirmationNumber = 21924
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3038),
                CheckInDate = new DateTime(2024, 12, 16),
                CheckOutDate = new DateTime(2024, 12, 22),
                NumberOfGuests = 5,
                PricePerWeekday = 104.05m,
                PricePerWeekend = 158.42m,
                CleaningFee = 5.36m,
                Discount = 0.22717037959754555m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "tfreeley@puppy.com")?.Id,
                ConfirmationNumber = 21925
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3107),
                CheckInDate = new DateTime(2024, 11, 20),
                CheckOutDate = new DateTime(2024, 12, 1),
                NumberOfGuests = 8,
                PricePerWeekday = 83.34m,
                PricePerWeekend = 128.05m,
                CleaningFee = 11.29m,
                Discount = 0.20579577371388896m,
                Status = rStatus.Active,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "tfreeley@puppy.com")?.Id,
                ConfirmationNumber = 21925
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3113),
                CheckInDate = new DateTime(2024, 12, 22),
                CheckOutDate = new DateTime(2024, 12, 28),
                NumberOfGuests = 4,
                PricePerWeekday = 106.3m,
                PricePerWeekend = 192.46m,
                CleaningFee = 17.59m,
                Discount = 0.0m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "tfreeley@puppy.com")?.Id,
                ConfirmationNumber = 21925
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3142),
                CheckInDate = new DateTime(2024, 12, 28),
                CheckOutDate = new DateTime(2024, 12, 31),
                NumberOfGuests = 6,
                PricePerWeekday = 199.68m,
                PricePerWeekend = 241.45m,
                CleaningFee = 25.94m,
                Discount = 0.0m,
                Status = rStatus.Cancelled,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "tfreeley@puppy.com")?.Id,
                ConfirmationNumber = 21925
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3071),
                CheckInDate = new DateTime(2024, 12, 14),
                CheckOutDate = new DateTime(2024, 12, 16),
                NumberOfGuests = 1,
                PricePerWeekday = 89.88m,
                PricePerWeekend = 123.04m,
                CleaningFee = 19.14m,
                Discount = 0.0m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "tfreeley@puppy.com")?.Id,
                ConfirmationNumber = 21925
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3065),
                CheckInDate = new DateTime(2024, 12, 2),
                CheckOutDate = new DateTime(2024, 12, 6),
                NumberOfGuests = 13,
                PricePerWeekday = 155.03m,
                PricePerWeekend = 139.83m,
                CleaningFee = 21.05m,
                Discount = 0.09495617203701066m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "tfreeley@puppy.com")?.Id,
                ConfirmationNumber = 21926
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3157),
                CheckInDate = new DateTime(2024, 12, 15),
                CheckOutDate = new DateTime(2024, 12, 24),
                NumberOfGuests = 9,
                PricePerWeekday = 223.27m,
                PricePerWeekend = 269.55m,
                CleaningFee = 11.35m,
                Discount = 0.0m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "peterstump@hootmail.com")?.Id,
                ConfirmationNumber = 21927
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3107),
                CheckInDate = new DateTime(2024, 12, 1),
                CheckOutDate = new DateTime(2024, 12, 4),
                NumberOfGuests = 8,
                PricePerWeekday = 83.34m,
                PricePerWeekend = 128.05m,
                CleaningFee = 11.29m,
                Discount = 0.20579577371388896m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "ra@aoo.com")?.Id,
                ConfirmationNumber = 21928
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3065),
                CheckInDate = new DateTime(2024, 12, 1),
                CheckOutDate = new DateTime(2024, 12, 2),
                NumberOfGuests = 13,
                PricePerWeekday = 155.03m,
                PricePerWeekend = 139.83m,
                CleaningFee = 21.05m,
                Discount = 0.09495617203701066m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "orielly@foxnets.com")?.Id,
                ConfirmationNumber = 21929
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3034),
                CheckInDate = new DateTime(2024, 12, 28),
                CheckOutDate = new DateTime(2025, 1, 3),
                NumberOfGuests = 14,
                PricePerWeekday = 172.83m,
                PricePerWeekend = 229.98m,
                CleaningFee = 23.55m,
                Discount = 0.0m,
                Status = rStatus.Cancelled,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "orielly@foxnets.com")?.Id,
                ConfirmationNumber = 21929
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3099),
                CheckInDate = new DateTime(2024, 12, 25),
                CheckOutDate = new DateTime(2024, 12, 28),
                NumberOfGuests = 1,
                PricePerWeekday = 111.73m,
                PricePerWeekend = 260.62m,
                CleaningFee = 15.89m,
                Discount = 0.24471219336460792m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "orielly@foxnets.com")?.Id,
                ConfirmationNumber = 21929
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3183),
                CheckInDate = new DateTime(2024, 12, 29),
                CheckOutDate = new DateTime(2024, 12, 31),
                NumberOfGuests = 1,
                PricePerWeekday = 188.53m,
                PricePerWeekend = 157.96m,
                CleaningFee = 6.69m,
                Discount = 0.0m,
                Status = rStatus.Cancelled,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "tanner@puppy.com")?.Id,
                ConfirmationNumber = 21930
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3127),
                CheckInDate = new DateTime(2024, 11, 29),
                CheckOutDate = new DateTime(2024, 12, 2),
                NumberOfGuests = 12,
                PricePerWeekday = 224.98m,
                PricePerWeekend = 180.86m,
                CleaningFee = 11.91m,
                Discount = 0.0m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "tuck33@puppy.com")?.Id,
                ConfirmationNumber = 21931
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3027),
                CheckInDate = new DateTime(2024, 12, 14),
                CheckOutDate = new DateTime(2024, 12, 26),
                NumberOfGuests = 4,
                PricePerWeekday = 70.24m,
                PricePerWeekend = 126.45m,
                CleaningFee = 18.69m,
                Discount = 0.07832854307103741m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "fd@puppy.com")?.Id,
                ConfirmationNumber = 21932
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3122),
                CheckInDate = new DateTime(2024, 12, 26),
                CheckOutDate = new DateTime(2024, 12, 31),
                NumberOfGuests = 1,
                PricePerWeekday = 189.98m,
                PricePerWeekend = 119.06m,
                CleaningFee = 25.11m,
                Discount = 0.0m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "fd@puppy.com")?.Id,
                ConfirmationNumber = 21932
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3107),
                CheckInDate = new DateTime(2024, 12, 4),
                CheckOutDate = new DateTime(2024, 12, 6),
                NumberOfGuests = 8,
                PricePerWeekday = 83.34m,
                PricePerWeekend = 128.05m,
                CleaningFee = 11.29m,
                Discount = 0.20579577371388896m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "fd@puppy.com")?.Id,
                ConfirmationNumber = 21932
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3065),
                CheckInDate = new DateTime(2024, 12, 6),
                CheckOutDate = new DateTime(2024, 12, 10),
                NumberOfGuests = 13,
                PricePerWeekday = 155.03m,
                PricePerWeekend = 139.83m,
                CleaningFee = 21.05m,
                Discount = 0.09495617203701066m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "ra@aoo.com")?.Id,
                ConfirmationNumber = 21933
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3105),
                CheckInDate = new DateTime(2024, 12, 26),
                CheckOutDate = new DateTime(2025, 1, 5),
                NumberOfGuests = 1,
                PricePerWeekday = 212.86m,
                PricePerWeekend = 212.7m,
                CleaningFee = 6.82m,
                Discount = 0.0m,
                Status = rStatus.Pending,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "louielouie@puppy.com")?.Id,
                ConfirmationNumber = 21934
            });

            Reservations.Add(new Reservation()
            {
                Property = context.Properties.FirstOrDefault(p => p.PropertyNumber == 3053),
                CheckInDate = new DateTime(2024, 11, 25),
                CheckOutDate = new DateTime(2024, 11, 27),
                NumberOfGuests = 6,
                PricePerWeekday = 106.87m,
                PricePerWeekend = 121.74m,
                CleaningFee = 5.62m,
                Discount = 0.058409227655741816m,
                Status = rStatus.Cancelled,
                UserID = context.Users.FirstOrDefault(u => u.NormalizedEmail.ToLower() == "rwood@voyager.net")?.Id,
                ConfirmationNumber = 21935
            });
            // Add the reservations to the database context
            foreach (var reservation in Reservations)
            {
                context.Reservations.Add(reservation);
            }
            context.SaveChanges();
        }
    }
}
