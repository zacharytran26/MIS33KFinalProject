using fa24group8finalproject.DAL;
using fa24group8finalproject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace fa24group8finalproject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string SearchString, DateTime? SearchCheckIn, DateTime? SearchCheckOut, int? SelectedCategory)
        {
            ViewBag.Categories = _context.Categories.ToList();

            //CHANGED
            var properties = _context.Properties
                .Include(p => p.Category)
                .Include(p => p.PropertyReviews) 
                .AsQueryable();

            // Get the logged-in user
            var loggedInUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            if (User.IsInRole("Host"))
            { //CHANGED
                properties = properties.Where(p => p.HostEmail == loggedInUser.Email && p.Status == pStatus.Active);
            }

            // Apply filters based on user input
            if (!string.IsNullOrEmpty(SearchString))
            {
                properties = properties.Where(p => p.StreetAddress.Contains(SearchString) || p.City.Contains(SearchString));
            }

            if (SelectedCategory.HasValue)
            {
                properties = properties.Where(p => p.Category.CategoryID == SelectedCategory.Value);
            }

            if (SearchCheckIn.HasValue && SearchCheckOut.HasValue)
            {
                properties = properties.Where(p => !p.Reservations.Any(r =>
                    r.Status == rStatus.Active &&
                    ((r.CheckOutDate > SearchCheckIn && r.CheckInDate < SearchCheckIn) ||
                     (r.CheckInDate < SearchCheckOut && r.CheckOutDate > SearchCheckOut) ||
                     (r.CheckInDate < SearchCheckIn && r.CheckOutDate > SearchCheckOut) ||
                     (r.CheckInDate >= SearchCheckIn && r.CheckOutDate <= SearchCheckOut))));
            }

            // Execute the query and fetch all properties
            var selectedProperties = properties.ToList();

            // Dynamically update ratings for all fetched properties
            foreach (var property in selectedProperties)
            {
                property.CheckRating(); // Recalculate AverageRating for display
            }

            // Set ViewBag values
            ViewBag.AllProperties = _context.Properties.Count(); // Total properties in the database
            ViewBag.SelectedProperty = selectedProperties.Count(); // Count of properties matching the filters

            // Return the filtered and processed list to the view
            return View(selectedProperties.OrderBy(p => p.PropertyNumber));
        }
        
        public IActionResult DetailedSearch()
        {
            // this allows user to see dropdown list of all categories when making new properties
            ViewBag.AllCategories = GetSelectAllCategories();
            return View();
        }
        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Properties
                .FirstOrDefaultAsync(m => m.PropertyID == id);
            if (@property == null)
            {
                return NotFound();
            }

            return RedirectToAction("Details", "Properties", new { id = property.PropertyID });
        }
        [HttpPost, ActionName("DetailedSearch")]
        public IActionResult DisplaySearchResults(PropertySearchViewModel psvm, int SelectedCategory)
        {
            // Base query including necessary navigation properties
            // IQueryable features queries are not executed immediately when defined
            IQueryable<Property> query = _context.Properties.Include(p => p.Category);
            var categories = _context.Categories.ToList();
            ViewBag.Categories = categories;
            try
            {
                psvm?.CalcSearchDates();
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                ViewBag.AllCategories = GetSelectAllCategories();
                return View("DetailedSearch", psvm);
            }

            // Filter for check-in/check-out date availabilities
            if (psvm?.SearchCheckIn != null && psvm.SearchCheckOut != null)
            {
                query = query.Where(property =>
                    !property.Reservations.Any(r =>
                        r.Status == rStatus.Active &&
                        ((r.CheckOutDate > psvm.SearchCheckIn && r.CheckInDate < psvm.SearchCheckIn) ||
                         (r.CheckInDate < psvm.SearchCheckOut && r.CheckOutDate > psvm.SearchCheckOut) ||
                         (r.CheckInDate < psvm.SearchCheckIn && r.CheckOutDate > psvm.SearchCheckOut) ||
                         (r.CheckInDate >= psvm.SearchCheckIn && r.CheckOutDate <= psvm.SearchCheckOut))));
            }

            // Filter by category
            if (SelectedCategory != -1)
            {
                query = query.Where(p => p.Category.CategoryID == SelectedCategory);
            }

            // Filter by city and state
            if (!string.IsNullOrEmpty(psvm?.SearchCity))
            {
                query = query.Where(p => p.City == psvm.SearchCity);
            }

            if (psvm?.SearchState != null)
            {
                query = query.Where(p => p.State == psvm.SearchState);
            }

            // Filter by average guest rating
            if (psvm?.SearchGuestRatingMin != null)
            {
                query = query.Where(p => p.AverageRating >= psvm.SearchGuestRatingMin);
            }
            if (psvm?.SearchGuestRatingMax != null)
            {
                query = query.Where(p => p.AverageRating <= psvm.SearchGuestRatingMax);
            }

            // Filter by number of guests
            if (psvm?.SearchNumGuestsMin != null)
            {
                query = query.Where(p => p.NumberOfGuestsAllowed >= psvm.SearchNumGuestsMin);
            }
            if (psvm?.SearchNumGuestsMax != null)
            {
                query = query.Where(p => p.NumberOfGuestsAllowed <= psvm.SearchNumGuestsMax);
            }

            // Filter by price (weekend and weekday)
            if (psvm?.SearchWeekendPriceMin != null)
            {
                query = query.Where(p => p.PricePerWeekend >= psvm.SearchWeekendPriceMin);
            }
            if (psvm?.SearchWeekendPriceMax != null)
            {
                query = query.Where(p => p.PricePerWeekend <= psvm.SearchWeekendPriceMax);
            }
            if (psvm?.SearchWeekdayPriceMin != null)
            {
                query = query.Where(p => p.PricePerWeekday >= psvm.SearchWeekdayPriceMin);
            }
            if (psvm?.SearchWeekdayPriceMax != null)
            {
                query = query.Where(p => p.PricePerWeekday <= psvm.SearchWeekdayPriceMax);
            }

            // Filter by number of beds and baths
            if (psvm?.SearchNumBedsMin != null)
            {
                query = query.Where(p => p.NumberOfBeds >= psvm.SearchNumBedsMin);
            }
            if (psvm?.SearchNumBedsMax != null)
            {
                query = query.Where(p => p.NumberOfBeds <= psvm.SearchNumBedsMax);
            }
            if (psvm?.SearchNumBathsMin != null)
            {
                query = query.Where(p => p.NumberOfBaths >= psvm.SearchNumBathsMin);
            }
            if (psvm?.SearchNumBathsMax != null)
            {
                query = query.Where(p => p.NumberOfBaths <= psvm.SearchNumBathsMax);
            }

            // Filter by pets allowed and parking
            if (psvm?.SearchPetsAllowed != null)
            {
                query = query.Where(p => p.PetsAllowed == psvm.SearchPetsAllowed);
            }
            if (psvm?.SearchParkingAllowed != null)
            {
                query = query.Where(p => p.ParkingAllowed == psvm.SearchParkingAllowed);
            }

            // Filter based on user role
            AppUser userLoggedIn = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            if (User.IsInRole("Host"))
            {
                query = query.Where(p => p.HostEmail == userLoggedIn.Email && p.Status == pStatus.Active);
            }
            else
            {
                query = query.Where(p => p.ApprovalStatus == pStatus.Active && p.Status == pStatus.Active);
            }

            // Execute the query and prepare for the view
            List<Property> SelectedProperty = query.Include(p => p.Category).ToList();

            ViewBag.AllProperties = _context.Properties.Count();
            ViewBag.SelectedProperty = SelectedProperty.Count();

            return View("Index", SelectedProperty.ToList());
        }

        private SelectList GetSelectAllCategories()
        {
            //Get the list of categories from the database
            List<Category> categoryList = _context.Categories.ToList();

            //add a dummy entry so the user can select all genres
            Category SelectAll = new Category() { CategoryID = -1, CategoryName = "All Categories" };
            categoryList.Add(SelectAll);

            //convert the list to a SelectList by calling SelecStList constructor
            //CategoryID and CategoryName are the names of the properties on the Category class
            //CategoryID is the primary key
            SelectList categorySelectList = new SelectList(categoryList.OrderBy(c => c.CategoryID), "CategoryID", "CategoryName");

            //return the electList
            return categorySelectList;
        }

        private void PopulateAverageRating(int? id)
        {
            List<Property> Properties = _context.Properties.Include(p => p.Category).Include(p => p.PropertyReviews).ToList();
            Property property = Properties.FirstOrDefault(m => m.PropertyID == id);
            Int32 pid = property.PropertyID;
            property.CheckRating();
            List<PropertyReview> reviews = new List<PropertyReview>();
            foreach (PropertyReview review in _context.PropertyReviews)
            {
                if (review.Property.PropertyID == pid)
                {
                    reviews.Add(review);
                }
            }

            if (property.PropertyReviews.Count == 0)
            {
                ViewBag.noResults = "No review has been made for this property yet.";
            }
            // returns viewbag to list property address
            ViewBag.Property = property.FullAddress;
            ViewBag.AverageRating = property.AverageRating;
        }


    }
}