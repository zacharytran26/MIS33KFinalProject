using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Composition.Convention;

//TODO: Make this namespace match your project name
namespace fa24group8finalproject.Models
{
    public enum aStatus { Active, [Display(Name = "Not Active")] notActive }
    public class AppUser : IdentityUser
    {
        //TODO: Add custom user fields - first name is included as an example
        //UserID, Email, password and phone number all automatically added from the IdentityUser
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Display(Name = "Middle Initial")]
        public String? MI { get; set; }

        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Display(Name = "Full Name")]
        public String? FullName
        {
            get { return FirstName + " " + MI + " " + LastName; }
        }

        [Display(Name = "City")]
        public String? City { get; set; }
        [Display(Name = "State")]
        public StateList State { get; set; }
        [Display(Name = "Zip Code")]
        public String ZipCode { get; set; }
        [Display(Name = "Street Address")]
        public String? StreetAddress { get; set; }


        [Display(Name = "Full Address")]
        public String? FullAddress
        {
            get { return StreetAddress + " " + City + ", " + State + " " + ZipCode; }
        }
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }
        [Display(Name = "Activity Status")]
        public aStatus IsActive { get; set; }

        public string? Role { get; set; }

        // AppUser can create multiple property reviews
        public List<PropertyReview> PropertyReviews { get; set; }
        public List<Reservation> Reservations { get; set; }
        // AppUser can list many properties (host only)
        public List<Property> Properties { get; set; }
    }

}
