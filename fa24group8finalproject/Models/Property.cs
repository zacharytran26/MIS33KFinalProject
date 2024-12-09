using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Reflection.Emit;

namespace fa24group8finalproject.Models
{
    public enum StateList
    {
        [Display(Name = "Alabama")] AL,
        [Display(Name = "Alaska")] AK,
        [Display(Name = "Arizona")] AZ,
        [Display(Name = "Arkansas")] AR,
        [Display(Name = "California")] CA,
        [Display(Name = "Colorado")] CO,
        [Display(Name = "Connecticut")] CT,
        [Display(Name = "Delaware")] DE,
        [Display(Name = "Florida")] FL,
        [Display(Name = "Georgia")] GA,
        [Display(Name = "Hawaii")] HI,
        [Display(Name = "Idaho")] ID,
        [Display(Name = "Illinois")] IL,
        [Display(Name = "Indiana")] IN,
        [Display(Name = "Iowa")] IA,
        [Display(Name = "Kansas")] KS,
        [Display(Name = "Kentucky")] KY,
        [Display(Name = "Louisiana")] LA,
        [Display(Name = "Maine")] ME,
        [Display(Name = "Maryland")] MD,
        [Display(Name = "Massachusetts")] MA,
        [Display(Name = "Michigan")] MI,
        [Display(Name = "Minnesota")] MN,
        [Display(Name = "Mississippi")] MS,
        [Display(Name = "Missouri")] MO,
        [Display(Name = "Montana")] MT,
        [Display(Name = "Nebraska")] NE,
        [Display(Name = "Nevada")] NV,
        [Display(Name = "New Hampshire")] NH,
        [Display(Name = "New Jersey")] NJ,
        [Display(Name = "New Mexico")] NM,
        [Display(Name = "New York")] NY,
        [Display(Name = "North Carolina")] NC,
        [Display(Name = "North Dakota")] ND,
        [Display(Name = "Ohio")] OH,
        [Display(Name = "Oklahoma")] OK,
        [Display(Name = "Oregon")] OR,
        [Display(Name = "Pennsylvania")] PA,
        [Display(Name = "Rhode Island")] RI,
        [Display(Name = "South Carolina")] SC,
        [Display(Name = "South Dakota")] SD,
        [Display(Name = "Tennessee")] TN,
        [Display(Name = "Texas")] TX,
        [Display(Name = "Utah")] UT,
        [Display(Name = "Vermont")] VT,
        [Display(Name = "Virginia")] VA,
        [Display(Name = "Washington")] WA,
        [Display(Name = "West Virginia")] WV,
        [Display(Name = "Wisconsin")] WI,
        [Display(Name = "Wyoming")] WY,
        [Display(Name = "Washington D.C.")] DC
    }
    public enum pStatus
    {
        Active,
        [Display(Name = "Not Active")] notActive
    }
    public enum YesNo
    {
        Yes,
        No
    }

    public class Property
    {
        public Decimal HostRevenue = .90m;

        [Key]
        public Int32 PropertyID { get; set; }

        [Display(Name = "Property Number")]
        public Int32 PropertyNumber { get; set; }

        [EmailAddress]
        [Display(Name = "Host Email")]
        public String HostEmail { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public String StreetAddress { get; set; }

        [Required]
        public String City { get; set; }

        [Display(Name = "Apartment Number (optional)")]
        public String? AptNum { get; set; }

        [Required]
        public StateList State { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public String ZipCode { get; set; }

        [Display(Name = "Full Address")]
        public String FullAddress
        {
            get { return StreetAddress + " " + AptNum + " " + City + ", " + State + " " + ZipCode; }
        }

        [Required(ErrorMessage = "Must specify number of beds.")]
        [Display(Name = "Number of Beds")]
        public Int32 NumberOfBeds { get; set; }

        [Required(ErrorMessage = "Must specify number of baths.")]
        [Display(Name = "Number of Baths")]
        public Int32 NumberOfBaths { get; set; }

        [Required(ErrorMessage = "Must specify guest limit.")]
        [Display(Name = "Guest Limit")]
        [Range(minimum: 0, maximum: double.PositiveInfinity, ErrorMessage = "Number of guests cannot be less than 0.")]
        public Int32 NumberOfGuestsAllowed { get; set; }

        [Display(Name = "Average Rating")]
        [DisplayFormat(DataFormatString = "{0:F1}")]
        public Decimal AverageRating { get; set; }

        [Required(ErrorMessage = "Must specify weekday price.")]
        [Display(Name = "Price per Weekday")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(minimum: 0, maximum: double.PositiveInfinity, ErrorMessage = "Price cannot be less than $0")]
        public Decimal PricePerWeekday { get; set; }

        // displays price per weekend
        [Required(ErrorMessage = "Must specify weekend price.")]
        [Display(Name = "Price per Weekend")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(minimum: 0, maximum: double.PositiveInfinity, ErrorMessage = "Price cannot be less than $0")]
        public Decimal PricePerWeekend { get; set; }

        [Required(ErrorMessage = "Must specify if pets are allowed.")]
        [Display(Name = "Pets Allowed?")]
        public YesNo PetsAllowed { get; set; }

        [Required(ErrorMessage = "Must specify if free parking is available.")]
        [Display(Name = "Free Parking Available?")]
        public YesNo ParkingAllowed { get; set; }

        [Display(Name = "Property Activity Status")]
        public pStatus ApprovalStatus { get; set; }

        [Range(minimum: 0, maximum: 100, ErrorMessage = "You cannot set a discount less than 0% or greater than 100%.")]
        public Int32 Discount { get; set; }

        [Display(Name = "Cleaning Fee")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(minimum: 0, maximum: double.PositiveInfinity, ErrorMessage = "Cleaning fee cannot be less than $0.")]
        public Decimal CleaningFee { get; set; }

        [Display(Name = "Number of Days Required for Discount")]
        [Range(minimum: 0, maximum: double.PositiveInfinity, ErrorMessage = "Number of days cannot be less than 0.")]
        public Int32 DiscountDays { get; set; }

        [Display(Name = "Property Approval Status")]
        public pStatus Status { get; set; }

        //Host Report 
        [Display(Name = "All Stay Revenue")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal AllStayRevenue { get { return Reservations.Sum(r => r.TotalPrice); } }

        [Display(Name = "BevoBnB Commission")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Commission
        {
            get { return AllStayRevenue - TotalStayRevenue; }
        }

        [Display(Name = "Total Stay Revenue")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal TotalStayRevenue
        {
            get { return AllStayRevenue * HostRevenue; }
        }

        [Display(Name = "Total Cleaning Fees")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal TotalCleaningFees
        {
            get { return Reservations.Sum(r => r.CleaningFee); }
        }

        [Display(Name = "Total Amount to Host")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal TotalCollected
        {
            get { return TotalStayRevenue + TotalCleaningFees; }
        }

        // property of number of completed reservations
        [Display(Name = "Total Number of Completed Reservations")]
        public Int32 CompletedReservations
        {
            // TODO: determine what to return... just copleted? put an if statement on checkout date? when host wants to specify date range they want the host report over, does this value change?
            get { return -1; }
        }


        public Category Category { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<PropertyReview> PropertyReviews { get; set; }

        public Property()
        {
            if (Reservations == null)
            {
                Reservations = new List<Reservation>();
            }

            if (PropertyReviews == null)
            {
                PropertyReviews = new List<PropertyReview>();
            }
        }


        public decimal _sumRatings { get { return PropertyReviews.Where(pr => pr.dStatus == disputeStatus.notViewedYet || pr.dStatus == disputeStatus.Rejected).Sum(pr => pr.Rating); } }

        public void CheckRating()
        {
            if (_sumRatings == 0)
            {
                AverageRating = 0;
            }
            else
            {
                AverageRating = Math.Round((Decimal)PropertyReviews.Where(pr => pr.dStatus == disputeStatus.notViewedYet || pr.dStatus == disputeStatus.Rejected).Average(pr => pr.Rating), 1);
            }
        }

    }

}

