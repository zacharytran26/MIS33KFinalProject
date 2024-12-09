using System;
using System.ComponentModel.DataAnnotations;

namespace fa24group8finalproject.Models
{
	public class Category
	{
		public Int32 CategoryID { get; set; }
        // name of the category
        [Required(ErrorMessage = "Category name is required!")]
        [Display(Name = "Category Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Category name may only contain letters")]
        public string CategoryName { get; set; }

        //public List<string> CategoryName = new List<string> { "Apartment", "Cabin", "Condo", "Hotel", "House" };
        // relational properties

        // category will have many properties
        public List<Property> Properties { get; set; }



        // methods for relational properties
        public Category()
        {
            if (Properties == null)
            {
                Properties = new List<Property>();
            }

        }
    }
}

