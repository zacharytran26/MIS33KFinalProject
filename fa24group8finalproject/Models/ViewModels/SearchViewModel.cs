using System;
namespace Tran_Zachary_HW3.Models
{
	public class SearchViewModel
	{
		public string? City { get; set; }
		public string? State { get; set; }
		public Int32 NumberOfBeds { get; set; }
		public Int32 NumberOfBaths { get; set; }
		public Decimal AverageRating { get; set; }
		public Int32 PricePerWeekend { get; set; }
		public Int32 PricePerWeekday { get; set; }
		public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
		public Boolean ParkingAllowed { get; set; }
        public Boolean PetsAllowed { get; set; }
		public Boolean ApprovalStatus { get; set; }
		public string? Category { get; set; }
        public string? PropertyName { get; set; }


    }
}

