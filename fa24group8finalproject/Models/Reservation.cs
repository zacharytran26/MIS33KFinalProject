using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace fa24group8finalproject.Models
{
    public enum rStatus { Active, Cancelled, Delete, Pending, Confirmed, Past}

    public class Reservation
    {
        private const decimal TAX_RATE = 0.07m;

        // Primary key
        public int ReservationID { get; set; }

        // Check-in date is required
        [Required(ErrorMessage = "Check-in Date is required!")]
        [Display(Name = "Check-in Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        // Check-out date is required
        [Required(ErrorMessage = "Check-out Date is required!")]
        [Display(Name = "Check-out Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }

        // Number of guests
        [Required(ErrorMessage = "Number of guests is required!")]
        [Display(Name = "Number of Guests")]
        [Range(1, int.MaxValue, ErrorMessage = "Number of guests must be at least 1.")]
        public int NumberOfGuests { get; set; }

        // Total price for the stay
        [Display(Name = "Stay Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal TotalPrice { get; set; }

        // Sales tax for the stay
        [Display(Name = "Sales Tax")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal SalesTax => (TotalPrice + CleaningFee) * TAX_RATE;

        // Total reservation price after discounts and fees
        [Display(Name = "Individual Reservation Total")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ReservationTotal { get; set; }

        // Subtotal for the stay (price + cleaning fee)
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Subtotal => TotalPrice + CleaningFee;

        // Cleaning fee for the property
        [Display(Name = "Cleaning Fee")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal CleaningFee { get; set; }

        // Reservation status
        [Display(Name = "Status")]
        public rStatus Status { get; set; }

        // Number of weekdays and weekends
        public int NumberOfWeekdays { get; set; }
        public int NumberOfWeekends { get; set; }

        // Property ID and User ID for relationships
        public int PropertyID { get; set; }
        public string UserID { get; set; }

        // Prices per day
        [Display(Name = "Weekday Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal PricePerWeekday { get; set; }

        [Display(Name = "Weekend Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal PricePerWeekend { get; set; }

        // Confirmation number for the reservation
        [Display(Name = "Confirmation Number")]
        public int ConfirmationNumber { get; set; }

        // Related navigation properties
        public AppUser User { get; set; }
        public Property Property { get; set; }

        // Total stay days and discount
        public int TotalStayDays { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Discount { get; set; }

        // Methods

        // Calculate the number of weekdays and weekends
        public void CalcNumberOfWeekdaysAndWeekends()
        {
            if (CheckOutDate <= CheckInDate)
            {
                throw new Exception("Check-out date must be after check-in date!");
            }

            if (DateTime.Now >= CheckInDate)
            {
                throw new Exception("This date has already passed!");
            }

            _weekdays = 0;
            _weekends = 0;
            _startDate = CheckInDate;

            while (_startDate < CheckOutDate)
            {
                if (_startDate.DayOfWeek == DayOfWeek.Saturday || _startDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    _weekends++;
                }
                else
                {
                    _weekdays++;
                }

                _startDate = _startDate.AddDays(1);
            }

            NumberOfWeekdays = _weekdays;
            NumberOfWeekends = _weekends;
            TotalStayDays = NumberOfWeekdays + NumberOfWeekends;
        }

        // Validate check-in and check-out dates
        public void CalcDates()
        {
            if ((CheckOutDate - CheckInDate).TotalDays <= 0)
            {
                throw new Exception("Check-out date must be later than check-in date.");
            }

            if ((CheckInDate - DateTime.Today).TotalDays <= 0)
            {
                throw new Exception("Check-in date must be after today's date!");
            }
        }

        // Check if the number of guests exceeds the property limit
        public void CheckGuestNumber()
        {
            if (NumberOfGuests > Property.NumberOfGuestsAllowed)
            {
                throw new Exception("Your guest count exceeds the property limit.");
            }
        }

        // Calculate total price for the stay
        public void CalcTotalPrice()
        {
            TotalPrice = ((NumberOfWeekdays * PricePerWeekday) + (NumberOfWeekends * PricePerWeekend))+ SalesTax;
        }

        // Private backing fields for calculations
        private DateTime _startDate;
        private int _weekdays;
        private int _weekends;
    }
}
