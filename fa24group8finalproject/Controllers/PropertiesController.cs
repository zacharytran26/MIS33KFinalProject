using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using fa24group8finalproject.DAL;
using fa24group8finalproject.Models;

namespace fa24group8finalproject.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly AppDbContext _context;

        public PropertiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Properties
        public async Task<IActionResult> Index()
        {
            AppUser UserLoggedIn = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            List<Property> properties;
            foreach (Property property in _context.Properties.Include(pr => pr.PropertyReviews))
            {
                property.CheckRating();
                _context.Update(property);
            }
            _context.SaveChanges();

            if (User.IsInRole("Host"))
            {
                var query = from p in _context.Properties
                            join c in _context.Categories
                            on p.Category.CategoryID equals c.CategoryID
                            select p;


                query = query.Where(p => p.HostEmail == UserLoggedIn.Email);
                query = query.Where(p => p.Status == pStatus.Active);

                // use the .ToList() method to execute the query
                // add an include statement so that you get the navigational data
                List<Property> HostProperties = query.Include(p => p.Category).ToList();

                ViewBag.SelectedProperties = HostProperties.Count;
                ViewBag.AllProperties = HostProperties.Count;

                // return statement to the view
                return View("Index", HostProperties);
            }
            else
            {
                // create an LINQ query to filter the properties we want from the search
                var query = from p in _context.Properties
                            join c in _context.Categories
                            on p.Category.CategoryID equals c.CategoryID
                            select p;

                // use LINQ to limit the query to properties that have been approved by admin and properties that are active according to host
                query = query.Where(p => p.ApprovalStatus == pStatus.Active);
                query = query.Where(p => p.Status == pStatus.Active);

                // use the .ToList() method to execute the query
                // add an include statement so that you get the navigational data
                List<Property> ApprovedProperties = query.Include(p => p.Category).ToList();

                ViewBag.SelectedProperties = ApprovedProperties.Count;
                ViewBag.AllProperties = ApprovedProperties.Count;

                // return statement to the view
                return View("Index", ApprovedProperties);
            }
        }

        public IActionResult DetailedSearch()
        {
            // this allows user to see dropdown list of all categories when making new properties
            ViewBag.AllCategories = GetSelectAllCategories();
            return View();
        }

        [HttpPost, ActionName("DetailedSearch")]
        public IActionResult DisplaySearchResults(PropertySearchViewModel psvm, int SelectedCategory)
        {
            // Base query including necessary navigation properties
            // IQueryable features queries are not executed immediately when defined
            IQueryable<Property> query = _context.Properties.Include(p => p.Category);

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

            if (!string.IsNullOrEmpty(psvm?.SearchState.ToString()))
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
            var selectedProperties = query.OrderBy(p => p.PropertyNumber).ToList();

            ViewBag.AllProperties = _context.Properties.Count();
            ViewBag.SelectedProperties = selectedProperties.Count;

            return View("Index", selectedProperties);
        }


        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Properties.Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.PropertyID == id);
            if (@property == null)
            {
                return NotFound();
            }

            return View(@property);
        }

        // GET: Properties/Create
        [Authorize(Roles = "Host")]
        public IActionResult Create()
        {
            // Populate categories for the dropdown
            ViewBag.Categories = GetSelectAllCategories();
            return View();
        }



            [HttpPost]
            [ValidateAntiForgeryToken]
            [Authorize(Roles = "Host")]
            public async Task<IActionResult> Create(
        [Bind("PropertyID,PropertyNumber,HostEmail,StreetAddress,City,AptNum,State,ZipCode,NumberOfBeds,NumberOfBaths,NumberOfGuestsAllowed,AverageRating,PricePerWeekday,PricePerWeekend,PetsAllowed,ParkingAllowed,ApprovalStatus,Discount,CleaningFee,DiscountDays,Status")] Property property,
        int Category)
            {
                // Generate a unique property number

                property.PropertyNumber = Utilities.GenerateNextPropertyNumber.GetNextPropertyNumber(_context);

                // Get the logged-in user
                var userLoggedIn = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                if (userLoggedIn == null)
                {
                    return View("Error", new string[] { "Unable to find the logged-in user." });
                }

                // Associate the property with the logged-in host
                property.HostEmail = userLoggedIn.Email;

                // Fetch the category associated with the property
                var dbCategory = _context.Categories.FirstOrDefault(c => c.CategoryID == Category);
                property.Category = dbCategory;

                // Check if the category is "Apartment" and validate AptNum
                if (dbCategory.CategoryName.Equals("Apartment", StringComparison.OrdinalIgnoreCase) && string.IsNullOrWhiteSpace(property.AptNum))
                {
                    ModelState.AddModelError("AptNum", "Apartment Number is required for properties in the Apartment category.");
                }

                // Set default property values
                property.Status = pStatus.Active;        // Default: Active
                property.ApprovalStatus = pStatus.notActive; // Default: Not active
                property.AverageRating = 0;             // Default rating


                // Save the property to the database
                _context.Add(property);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }


            // GET: Properties/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                // Include related data, such as Category, for editing
                var property = await _context.Properties
                    .Include(p => p.Category)
                    .FirstOrDefaultAsync(p => p.PropertyID == id);

                if (property == null)
                {
                    return NotFound();
                }

                // Populate categories for dropdown
                ViewBag.Categories = GetSelectAllCategories();

                return View(property);
            }
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("PropertyID,PropertyNumber,HostEmail,StreetAddress,City,AptNum,State,ZipCode,NumberOfBeds,NumberOfBaths,NumberOfGuestsAllowed,AverageRating,PricePerWeekday,PricePerWeekend,PetsAllowed,ParkingAllowed,ApprovalStatus,Discount,CleaningFee,DiscountDays,Status")] Property property)
            {
                if (id != @property.PropertyID)
                {
                    return NotFound();
                }

                try
                {
                    _context.Update(@property);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertyExists(@property.PropertyID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Home");
            }

            // GET: Properties/Delete/5
            public async Task<IActionResult> Delete(int? id)
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

                return View(@property);
            }

            // POST: Properties/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var @property = await _context.Properties.FindAsync(id);
                @property.Status = pStatus.notActive;

                List<Reservation> reservations = _context.Reservations.Include(r => r.User).Include(r => r.Property).Where(r => r.Property.PropertyID == property.PropertyID).ToList();
                foreach (Reservation reservation in reservations)
                {
                    if (reservation.Status == rStatus.Pending)
                    {
                        reservation.Status = rStatus.Delete;
                        //SENDING EMAIL: email to user when host deletes property bc reservation for property becomes deleted from cart


                    }
                    else if (reservation.Status == rStatus.Active && reservation.CheckInDate > DateTime.Now)
                    {
                        reservation.Status = rStatus.Cancelled;
                        //SENDING EMAIL: email to user when host deletes property bc reservation for property becomes cancelled

                    }
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }

                // save changes
                _context.Update(property);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            public IActionResult SeeDeleted()
            {
                // find logged in user
                AppUser userLoggedIn = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

                var query = from p in _context.Properties
                            select p;

                query = query.Where(p => p.HostEmail == userLoggedIn.Email);
                query = query.Where(p => p.Status == pStatus.notActive);

                // use the .ToList() method to execute the query
                // add an include statement so that you get the navigational data
                List<Property> HostProperties = query.Include(p => p.Category).ToList();

                if (HostProperties.Count == 0)
                {
                    ViewBag.noResults = "You have no deleted listings.";
                }

                // return statement to the view
                return View("SeeDeleted", HostProperties);
            }

            // GET: Properties/Reactivate/5
            //DONE
            [Authorize(Roles = "Host")]
            public async Task<IActionResult> Reactivate(int? id)
            {
                if (id == null)
                {
                    return View("Error", new string[] { "Please specify a property to reactivate!" });
                }

                Property property = await _context.Properties
                    .FirstOrDefaultAsync(m => m.PropertyID == id);

                if (property == null)
                {
                    return View("Error", new string[] { "This property was not found!" });
                }

                return View(property);
            }

            // POST: Properties/Reactivate/5
            //DONE
            [Authorize(Roles = "Host")]
            [HttpPost, ActionName("Reactivate")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> ReactivateConfirmed(int id)
            {
                // find property to delete based on PropertyID
                Property property = await _context.Properties.FindAsync(id);

                // reactivate property by changing status to Active
                property.Status = pStatus.Active;

                // save changes
                _context.Update(property);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            [Authorize(Roles = "Admin")]
            public IActionResult AdminReport(AdminReportViewModel arvm)
            {
                List<Reservation> AllReservations = _context.Reservations.ToList();
                List<Reservation> PastReservations = new List<Reservation>();
                Int32 ReservationCount = 0;

                foreach (Reservation reservation in AllReservations)
                {
                    if (reservation.Status == rStatus.Active)
                    {
                        PastReservations.Add(reservation);
                        ReservationCount++;
                    }
                }
                Decimal TotalCommission = 0.0m;
                foreach (Reservation reservation in PastReservations)
                {
                    TotalCommission += .10m * (reservation.TotalPrice - reservation.Discount);

                }
                arvm.BnBTotalCommission = TotalCommission;
                arvm.BnBTotalReservations = ReservationCount;
                if (ReservationCount == 0)
                {
                    arvm.BnBTotalCommission = 0.0m;
                }
                else
                {
                    arvm.BnBAvgCommission = TotalCommission / ReservationCount;

                }
                Int32 propertyCount = 0;
                foreach (Property property in _context.Properties)
                {
                    if (property.Status == pStatus.Active)
                    {
                        propertyCount++;

                    }
                }
                arvm.BnBSelectedProperties = propertyCount;
                List<Reservation> AllBnBReservations = new List<Reservation>();
                foreach (Reservation r in _context.Reservations.Where(r => r.Status == rStatus.Active))
                {
                    AllBnBReservations.Add(r);
                }
                //find how many total reservations there are
                ViewBag.AllReservations = AllBnBReservations.Count();
                return View("AdminReport", arvm);
            }
            [Authorize(Roles = "Admin")]
            public IActionResult AdminReportSearch()
            {
                ViewBag.AllCategories = GetSelectAllCategories();
                return View();

            }
            [Authorize(Roles = "Admin")]
            [HttpPost]
            public ActionResult AdminReportSearch(int SelectedCategory, PropertySearchViewModel psvm)
            {

                // create a query
                var reservationsQuery = from r in _context.Reservations
                                        join p in _context.Properties
                                        on r.Property.PropertyID equals p.PropertyID
                                        join c in _context.Categories
                                        on p.Category.CategoryID equals c.CategoryID
                                        select r;
                var propertiesQuery = from p in _context.Properties
                                      join c in _context.Categories
                                      on p.Category.CategoryID equals c.CategoryID
                                      select p;

                //check that search dates of user are valid
                try
                {
                    psvm.CalcSearchDates();
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = ex.Message;
                    ViewBag.AllCategories = GetSelectAllCategories();
                    //TODO: Change the name of the view it returns
                    return View("AdminReportSearch", psvm);
                }

                if ((psvm.SearchCheckIn != null) && (psvm.SearchCheckOut != null))
                {
                    reservationsQuery = reservationsQuery.Where(r => r.CheckInDate >= psvm.SearchCheckIn && r.CheckOutDate <= psvm.SearchCheckOut && r.Status == rStatus.Active);

                }
                else
                {
                    reservationsQuery = reservationsQuery.Where(r => r.Status == rStatus.Active);
                }
                // query to check search by Category
                // -1 means they chose all categories


                // find logged in user
                AppUser userLoggedIn = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

                //just make sure property is available and approved
                propertiesQuery = propertiesQuery.Where(p => p.ApprovalStatus == pStatus.Active);
                propertiesQuery = propertiesQuery.Where(p => p.Status == pStatus.Active);

                // use the .ToList() method to execute the query
                // add an include statement so that you get the navigational data
                List<Property> SelectedProperties = propertiesQuery.ToList();
                List<Property> PropertiesWithReservations = new List<Property>();
                List<Reservation> SelectedReservations = reservationsQuery.ToList();

                foreach (Property p in SelectedProperties)
                {
                    Int32 Seen = 0;
                    foreach (Reservation r in p.Reservations)
                    {
                        foreach (Reservation r2 in SelectedReservations)
                        {
                            if (r.ReservationID == r2.ReservationID)
                            {
                                Seen += 1;
                            }
                        }
                    }
                    if (Seen > 0)
                    {
                        PropertiesWithReservations.Add(p);
                    }

                }


                List<Property> AllProperties = propertiesQuery.Include(p => p.Category).ToList();

                Int32 NumProperties = PropertiesWithReservations.Count;



                AdminReportViewModel arvm = new AdminReportViewModel();
                //use the selected properties to calculate admin report data
                List<Reservation> SelectedPropertyReservations = SelectedReservations.ToList();

                //create new variable to keep track of total commission
                Decimal TotalCommission = 0.0m;

                //for each reservation in the past reservation list add the reservation total to the commission
                foreach (Reservation reservation in SelectedReservations)
                {
                    TotalCommission += 0.10m * (reservation.ReservationTotal);
                }

                //set the object commission equal to the commission calculated above
                arvm.BnBTotalCommission = TotalCommission;


                //find total number reservations
                arvm.BnBTotalReservations = SelectedReservations.Count;

                if (SelectedReservations.Count == 0)
                {
                    arvm.BnBAvgCommission = 0.0m;
                }
                //find avg commission
                else
                {
                    arvm.BnBAvgCommission = TotalCommission / SelectedReservations.Count;
                }

                arvm.BnBSelectedProperties = NumProperties;

                List<Reservation> AllBnBReservations = new List<Reservation>();
                foreach (Reservation r in _context.Reservations.Where(r => r.Status == rStatus.Active))
                {
                    AllBnBReservations.Add(r);
                }
                //find how many total reservations there are
                ViewBag.AllReservations = AllBnBReservations.Count();
                return View("AdminReport", arvm);
            }

            [Authorize(Roles = "Host")]
            public IActionResult HostReport(HostReportViewModel hpvm)
            {
                // first create a list of every property the host owns
                List<Property> all_properties = new List<Property>();
                foreach (Property property in _context.Properties.Include(p => p.Reservations))
                {
                    if (property.HostEmail == User.Identity.Name)
                    {
                        all_properties.Add(property);
                    }
                }

                Decimal TotalDailyPrice = 0.0m;
                Decimal TotalCleaningRevenue = 0.0m;
                Int32 TotalCompletedReservations = 0;
                Decimal TotalDiscount = 0.0m;

                List<HostReportPropertyViewModel> PVMList = new List<HostReportPropertyViewModel>();
                foreach (Property property in all_properties)
                {
                    HostReportPropertyViewModel newPVM = new HostReportPropertyViewModel();
                    Decimal newPVMStayRevenue = 0.0m;
                    Decimal newPVMCleaningFees = 0.0m;
                    Int32 newPVMCompletedReservations = 0;
                    Decimal newPVMDiscount = 0.0m;

                    foreach (Reservation reservation in property.Reservations)
                    {
                        if (reservation.Status == rStatus.Active)
                        {
                            newPVMStayRevenue += reservation.TotalPrice;
                            newPVMCleaningFees += reservation.CleaningFee;
                            newPVMDiscount = reservation.Discount;
                            newPVMCompletedReservations += 1;
                        }

                    }
                    TotalDailyPrice += newPVMStayRevenue;
                    TotalCleaningRevenue += newPVMCleaningFees;
                    TotalCompletedReservations += newPVMCompletedReservations;
                    TotalDiscount += newPVMDiscount;
                    newPVM.Report = hpvm;
                    newPVM.pTotalStayRevenue = newPVMStayRevenue;
                    newPVM.pTotalCleaningFees = newPVMCleaningFees;
                    newPVM.pCompletedReservations = newPVMCompletedReservations;
                    newPVM.pTotalDiscount = newPVMDiscount;
                    newPVM.property = property;
                    PVMList.Add(newPVM);
                }
                hpvm.TotalCleaningFees = TotalCleaningRevenue;
                hpvm.TotalHostDiscount = TotalDiscount;
                hpvm.TotalDailyPrice = TotalDailyPrice;
                Decimal TotalStayRevenue = TotalDailyPrice - TotalDiscount;
                hpvm.TotalStayRevenue = TotalStayRevenue;
                hpvm.TotalHostStayRevenue = 0.90m * TotalStayRevenue;
                hpvm.HostPayout = 0.90m * TotalStayRevenue + TotalCleaningRevenue;
                hpvm.CompletedReservations = TotalCompletedReservations;
                hpvm.IndividualPropertyReports = PVMList;

                List<Reservation> AllReservations = new List<Reservation>();
                foreach (Reservation r in _context.Reservations.Where(r => r.Property.HostEmail == User.Identity.Name && r.Status == rStatus.Active))
                {
                    AllReservations.Add(r);
                }
                //find how many total reservations there are
                ViewBag.AllReservations = AllReservations.Count();
                return View("HostReport", hpvm);
            }


            // HOSTREPORTSEARCH 
            // GET: Properties/HostReportSearch
            [Authorize(Roles = "Host")]
            public IActionResult HostReportSearch()
            {
                // this allows admins to see dropdown list of all categories when searching for different things
                ViewBag.AllCategories = GetSelectAllCategories();
                return View();
            }

            //POST: Properties/HostReportSearch
            //Host report to for specific search
            [Authorize(Roles = "Host")]
            [HttpPost]
            public ActionResult HostReportSearch(int SelectedCategory, PropertySearchViewModel psvm)
            {

                // create a query
                var reservationsQuery = from r in _context.Reservations
                                        join p in _context.Properties
                                        on r.Property.PropertyID equals p.PropertyID
                                        join c in _context.Categories
                                        on p.Category.CategoryID equals c.CategoryID
                                        select r;
                var propertiesQuery = from p in _context.Properties
                                      join c in _context.Categories
                                      on p.Category.CategoryID equals c.CategoryID
                                      select p;
                // find logged in user
                AppUser userLoggedIn = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                propertiesQuery = propertiesQuery.Where(p => p.HostEmail == userLoggedIn.Email);

                try
                {
                    psvm.CalcSearchDates();
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = ex.Message;
                    ViewBag.AllCategories = GetSelectAllCategories();
                    //TODO: Change the name of the view it returns
                    return View("HostReportSearch", psvm);
                }

                if ((psvm.SearchCheckIn != null) && (psvm.SearchCheckOut != null))
                {
                    reservationsQuery = reservationsQuery.Where(r => r.CheckInDate >= psvm.SearchCheckIn && r.CheckOutDate <= psvm.SearchCheckOut && r.Status == rStatus.Active);

                }
                else
                {
                    reservationsQuery = reservationsQuery.Where(r => r.Status == rStatus.Active);
                }
                // query to check search by Category
                // -1 means they chose all categories
                // cannot select multiple categories at a time right now -- Do we need this functionality???
                if (SelectedCategory != -1)
                {
                    Category dbCategory = _context.Categories.FirstOrDefault(c => c.CategoryID == SelectedCategory);
                    reservationsQuery = reservationsQuery.Where(r => r.Property.Category.CategoryID == dbCategory.CategoryID);
                    propertiesQuery = propertiesQuery.Where(p => p.Category.CategoryID == dbCategory.CategoryID);
                }


                //just make sure property is available and approved
                propertiesQuery = propertiesQuery.Where(p => p.ApprovalStatus == pStatus.Active);
                propertiesQuery = propertiesQuery.Where(p => p.Status == pStatus.Active);

                // use the .ToList() method to execute the query
                // add an include statement so that you get the navigational data
                List<Property> SelectedProperties = propertiesQuery.ToList();
                List<Property> PropertiesWithReservations = new List<Property>();
                List<Reservation> SelectedReservations = reservationsQuery.ToList();

                foreach (Property p in SelectedProperties)
                {
                    Int32 Seen = 0;
                    foreach (Reservation r in p.Reservations)
                    {
                        foreach (Reservation r2 in SelectedReservations)
                        {
                            if (r.ReservationID == r2.ReservationID)
                            {
                                Seen += 1;
                            }
                        }
                    }
                    if (Seen > 0)
                    {
                        PropertiesWithReservations.Add(p);
                    }

                }

                HostReportViewModel hpvm = new HostReportViewModel();


                //use the selected properties to calculate admin report data
                List<Reservation> SelectedPropertyReservations = new List<Reservation>();


                Decimal TotalCleaningRevenue = 0.0m;
                Int32 TotalCompletedReservations = 0;
                Decimal TotalDiscount = 0.0m;
                Decimal TotalDailyPrice = 0.0m;

                // List to hold the PVM
                List<HostReportPropertyViewModel> PVMList = new List<HostReportPropertyViewModel>();
                List<Property> removeDupes = new List<Property>();
                foreach (Property p in SelectedProperties)
                {
                    if (removeDupes.Contains(p) == false)
                    {
                        removeDupes.Add(p);
                    }
                }
                foreach (Property property in SelectedProperties)
                {
                    HostReportPropertyViewModel newPVM = new HostReportPropertyViewModel();
                    Decimal newPVMStayRevenue = 0.0m;
                    Decimal newPVMCleaningFees = 0.0m;
                    Int32 newPVMCompletedReservations = 0;
                    Decimal newPVMDiscount = 0.0m;

                    foreach (Reservation reservation in property.Reservations)
                    {
                        if (reservation.Status == rStatus.Active && SelectedReservations.Contains(reservation))
                        {
                            newPVMStayRevenue += reservation.TotalPrice;
                            newPVMCleaningFees += reservation.CleaningFee;
                            newPVMDiscount = reservation.Discount;
                            newPVMCompletedReservations += 1;
                        }
                    }
                    TotalDailyPrice += newPVMStayRevenue;
                    TotalCleaningRevenue += newPVMCleaningFees;
                    TotalCompletedReservations += newPVMCompletedReservations;
                    TotalDiscount += newPVMDiscount;
                    newPVM.Report = hpvm;
                    // TODO: check if total stay revenue subtracts discount
                    newPVM.pTotalStayRevenue = newPVMStayRevenue - newPVMDiscount;
                    newPVM.pTotalCleaningFees = newPVMCleaningFees;
                    newPVM.pCompletedReservations = newPVMCompletedReservations;
                    newPVM.pTotalDiscount = newPVMDiscount;
                    newPVM.property = property;
                    PVMList.Add(newPVM);
                }
                hpvm.TotalCleaningFees = TotalCleaningRevenue;
                hpvm.TotalHostDiscount = TotalDiscount;
                hpvm.TotalDailyPrice = TotalDailyPrice;
                Decimal TotalStayRevenue = TotalDailyPrice - TotalDiscount;
                hpvm.TotalStayRevenue = TotalStayRevenue;
                hpvm.TotalHostStayRevenue = 0.90m * TotalStayRevenue;
                hpvm.HostPayout = 0.90m * TotalStayRevenue + TotalCleaningRevenue;
                hpvm.CompletedReservations = TotalCompletedReservations;
                hpvm.IndividualPropertyReports = PVMList;

                List<Reservation> AllReservations = new List<Reservation>();
                foreach (Reservation r in _context.Reservations.Where(r => r.Property.HostEmail == User.Identity.Name && r.Status == rStatus.Active))
                {
                    AllReservations.Add(r);
                }
                //find how many total reservations there are
                ViewBag.AllReservations = AllReservations.Count();
                return View("HostReport", hpvm);
            }

            private bool PropertyExists(int id)
            {
                return _context.Properties.Any(e => e.PropertyID == id);
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
        }
    }