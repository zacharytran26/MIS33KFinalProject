using System;
using System.ComponentModel.DataAnnotations;

namespace fa24group8finalproject.Models
{
    public enum disputeStatus { notViewedYet, inDispute, Accepted, Rejected }

    public class PropertyReview
	{
        public Int32 PropertyReviewID { get; set; }

        // property for rating
        [Required(ErrorMessage = "Rating is required!")]
        [Display(Name = "Rating")]
        [Range(0, 5, ErrorMessage = "The rating must be between 0 and 5.")]
        public Int32 Rating { get; set; }

        // property for review description
        // this is optional
        [Display(Name = "Comment")]
        [StringLength(280, ErrorMessage = "Comment cannot exceed 280 characters. ")]
        public String? Review { get; set; }

        // property to allow for dispute from host of a review
        // optional, but only available to hosts
        public String? Dispute { get; set; }

        // property when host disputes a review and admin is looking over reviews
        // when this value is True (inDispute), then review rating doesn't factor into average rating
        [Display(Name = "Status")]
        public disputeStatus dStatus { get; set; }



        // relational properties

        // each property review is only associated with one user
        public AppUser User { get; set; }

        // each property review is only associated with one property
        public Property Property { get; set; }



        // method for relational properties
        public PropertyReview()
        {
        }
    }
}

