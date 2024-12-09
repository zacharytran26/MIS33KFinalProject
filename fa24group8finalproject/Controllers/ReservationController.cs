using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fa24group8finalproject.DAL;
using fa24group8finalproject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace fa24group8finalproject.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;


        public ReservationController(AppDbContext context, UserManager<AppUser> userManger)
        {
            _context = context;
            _userManager = userManger;

        }

        // GET: Reservation
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            //Set up a list of reservations to display
            var model = new ReservationIndexViewModel
            {
                User = currentUser,
                Pending = await _context.Reservations
             .Include(r => r.Property)
             .Where(r => r.User.UserName == currentUser.UserName && r.Status == rStatus.Pending)
             .ToListAsync(),
                Unavailable = await _context.Reservations
             .Include(r => r.Property)
             .Where(r => r.Property.HostEmail == currentUser.Email && r.Status == rStatus.Active)
             .ToListAsync(),
                Upcoming = await _context.Reservations
             .Include(r => r.Property)
             .Where(r => r.User.UserName == currentUser.UserName && r.Status == rStatus.Active && r.CheckInDate > DateTime.Today)
             .ToListAsync(),
                Cancelled = await _context.Reservations
             .Include(r => r.Property)
             .Where(r => r.User.UserName == currentUser.UserName && r.Status == rStatus.Cancelled)
             .ToListAsync(),
                Past = await _context.Reservations
             .Include(r => r.Property)
             .Where(r => r.User.UserName == currentUser.UserName && r.Status == rStatus.Past && r.CheckOutDate < DateTime.Today)
             .ToListAsync()
            };

            return View(model);

        }

        // GET: Reservation/Details/5
        public async Task<IActionResult> Details(int? rid)
        {
            if (rid == null)
            {
                return View("Error", new String[] { "No reservation selected - please try again." });
            }

            var reservation = await _context.Reservations
                .Include(r => r.Property)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.ReservationID == rid);

            if (reservation == null)
            {
                return View("Error", new String[] { "This reservation was not found!" });
            }

            //make sure this reservation belongs to this user
            if (User.IsInRole("Customer") && reservation.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your reservation!" });
            }

            return View(reservation);
        }



        public async Task<IActionResult> DetailReservation(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "No reservation selected - please try again." });
            }

            var reservation = await _context.Reservations
                .Include(r => r.Property)
                .Include(r => r.User)
            .FirstOrDefaultAsync(m => m.ReservationID == id);

            if (reservation == null)
            {
                return View("Error", new String[] { "This reservation was not found!" });
            }

            //make sure this reservation belongs to this user
            if (User.IsInRole("Customer") && reservation.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your reservation!" });
            }

            return View(reservation);
        }

        // GET: Reservation/Create
        // TODO: I think I need ot add the viewbag here as well...

        [Authorize]
        public IActionResult Create(int? id)
        {
            // Check if property exists in the database
            Property property = _context.Properties.FirstOrDefault(p => p.PropertyID == id);

            if (property == null)
            {
                return View("Error", new String[] { "That property was not found in the database." });
            }

            // Create a new reservation and set default dates
            Reservation reservation = new Reservation
            {
                Property = property,
                CheckInDate = DateTime.Now,          // Default checkindate to today's date
                CheckOutDate = DateTime.Now.AddDays(1) // Default checkoutdate to tomorrow's date
            };

            ViewBag.PropertyID = property.PropertyID;
            ViewBag.AllCustomers = GetAllCustomersSelectList();
            // ViewData["PropertyID"] = new SelectList(_context.Properties, "PropertyID", "City");

            return View(reservation);
        }


        // POST: Reservation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Customer,Admin")]
        // [Bind("ReservationID,CheckInDate,CheckOutDate,NumberOfGuests,TotalPrice,ReservationTotal,CleaningFee,Status,NumberOfWeekdays,NumberOfWeekends,PropertyID,PricePerWeekday,PricePerWeekend,TotalStayDays,Discount")]
        public async Task<IActionResult> Create(
    [Bind("PropertyID,ReservationID,CheckInDate,CheckOutDate,NumberOfGuests,CleaningFee")] Reservation reservation,
    string customeremail,
    string email)
        {
            // Fetch the property
            Property property = _context.Properties.FirstOrDefault(p => p.PropertyID == reservation.PropertyID);
            if (property == null)
                return View("Error", new String[] { "Property not found." });

            if (property.Status == pStatus.notActive)
                return View("Error", new String[] { "This property is no longer active." });

            // Initialize reservation
            InitializeReservation(reservation, property);

            try
            {
                reservation.CheckGuestNumber();
                reservation.CalcDates();
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                ViewBag.PropertyID = reservation.PropertyID;
                return View("Create", reservation);
            }

            // Check for conflicting reservations
            var conflictingReservations = GetConflictingReservations(reservation);
            if (conflictingReservations.Any())
            {
                ViewBag.ErrorMessage = "There is already an active reservation for this property on your dates. Please choose different dates.";
                ViewBag.PropertyID = reservation.PropertyID;
                return View("Create", reservation);
            }

            // Role-based handling
            if (User.IsInRole("Admin"))
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(customeremail))
                    return View("Error", new String[] { "Please specify a customer to create the reservation for." });

                var customer = _context.Users.FirstOrDefault(u => u.Email == customeremail);
                if (customer == null)
                    return View("Error", new String[] { "The specified customer does not exist." });

                reservation.User = customer;
            }
            else if (User.IsInRole("Customer"))
            {
                var loggedInUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                if (loggedInUser == null)
                    return View("Error", new String[] { "Logged-in user not found." });

                reservation.User = loggedInUser;
            }
            else
            {
                return View("Error", new String[] { "Unauthorized access." });
            }

            // Calculate pricing and apply discounts
            reservation.CalcNumberOfWeekdaysAndWeekends();
            reservation.CalcTotalPrice();
            ApplyDiscount(reservation, property);

            try
            {
                // Save reservation
                var existingReservation = _context.Reservations
                    .FirstOrDefault(r => r.Status == rStatus.Pending && r.PropertyID == reservation.Property.PropertyID);

                if (existingReservation == null)
                {
                    reservation.ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetConfirmNumber(_context);
                    _context.Add(reservation);
                }
                else
                {
                    existingReservation.Status = rStatus.Active;
                    _context.Update(existingReservation);
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error creating or updating the reservation.", ex.Message });
            }

            // Redirect based on role
            if (User.IsInRole("Customer"))
                return RedirectToAction("Index", "Reservation");
            if (User.IsInRole("Admin"))
                return RedirectToAction("Index", "Reservation", new { id = reservation.ReservationID });

            return RedirectToAction("Index", "Properties");
        }

        // Helper method to initialize the reservation
        private void InitializeReservation(Reservation reservation, Property property)
        {
            reservation.Property = property;
            reservation.CleaningFee = property.CleaningFee;
            reservation.PricePerWeekday = property.PricePerWeekday;
            reservation.PricePerWeekend = property.PricePerWeekend;
            reservation.Status = rStatus.Pending;
        }

        // Helper method to get conflicting reservations
        private List<Reservation> GetConflictingReservations(Reservation reservation)
        {
            return _context.Reservations
                .Include(r => r.Property)
                .Where(r => r.PropertyID == reservation.Property.PropertyID &&
                            r.Status == rStatus.Active &&
                            ((r.CheckOutDate > reservation.CheckInDate && r.CheckOutDate <= reservation.CheckOutDate) ||
                             (r.CheckInDate >= reservation.CheckInDate && r.CheckInDate < reservation.CheckOutDate) ||
                             (r.CheckInDate <= reservation.CheckInDate && r.CheckOutDate >= reservation.CheckOutDate)))
                .ToList();
        }

        // Helper method to apply discount
        private void ApplyDiscount(Reservation reservation, Property property)
        {
            if (reservation.TotalStayDays >= property.DiscountDays)
            {
                reservation.Discount = property.Discount;
            }
            reservation.ReservationTotal = reservation.Subtotal - reservation.Discount + reservation.SalesTax;
        }




        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var reservation = await _context.Reservations.FirstOrDefaultAsync(r => r.ReservationID == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        [HttpPost]
        [Authorize(Roles = "Customer, Host")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int[] IdsToCancel)
        {
            if (IdsToCancel == null || !IdsToCancel.Any())
            {
                return View("Error", new string[] { "No reservations were selected to delete." });
            }

            foreach (var id in IdsToCancel)
            {
                var reservation = _context.Reservations.FirstOrDefault(r => r.ReservationID == id);
                if (reservation == null)
                {
                    return View("Error", new string[] { $"Reservation with ID {id} not found." });
                }

                // Mark the reservation as deleted (or cancelled)
                reservation.Status = rStatus.Cancelled; // Adjust based on your requirements
                _context.Update(reservation);
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var reservation = await _context.Reservations
        //        .FirstOrDefaultAsync(m => m.ReservationID == id);
        //    if (reservation == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(reservation);
        //}


        //// POST: Reservation/Delete/5
        //// Doesn't actually delete the reservation, but changes the status to cancelled

        //public ActionResult Delete(int[] IdsToCancel)
        //{
        //    //if RoleModificationModel is valid, add new users
        //    if (ModelState.IsValid)
        //    {
        //        //if there are users to make inactive (terminate for admins), inactivate them
        //        if (IdsToCancel != null)
        //        {
        //            //loop through all the ids to make inactive
        //            foreach (Int32 reservationId in IdsToCancel)
        //            {
        //                //find the reservation in the database using their id
        //                Reservation reservation = _context.Reservations.Include(o => o.User).FirstOrDefault(r => r.ReservationID == reservationId);

        //                // attempt to change status of the reservation to delete
        //                try
        //                {
        //                    reservation.Status = rStatus.Delete;
        //                    //save the changes
        //                    _context.Update(reservation);
        //                    _context.SaveChanges();
        //                }
        //                // if attempt did not work, show user the error page
        //                catch (Exception ex)
        //                {
        //                    return View("Error", ex);
        //                }
        //            }
        //        }
        //        //this is the happy path - all edits worked
        //        //take the user back to the RoleAdmin Index page
        //        return RedirectToAction("Index");
        //    }
        //    //this is a sad path - the status was not found
        //    //show the user the error page
        //    return View("Error", new string[] { "Unable to remove reservation from cart." });
        //}


        //[Authorize(Roles = "Customer,Admin")]
        //    public async Task<IActionResult> Confirm(int[] IdstoCheckout)
        //    {
        //        if (IdstoCheckout == null || IdstoCheckout.Length == 0)
        //        {
        //            return View("Error", new string[] { "No reservations specified for confirmation." });
        //        }

        //        foreach (var id in IdstoCheckout)
        //        {
        //            var reservation = await _context.Reservations
        //                .Include(r => r.Property)
        //                .Include(r => r.User)
        //                .FirstOrDefaultAsync(r => r.ReservationID == id);

        //            if (reservation == null)
        //            {
        //                return View("Error", new string[] { $"Reservation with ID {id} not found." });
        //            }

        //            // Check for conflicting reservations
        //            var conflictingReservations = _context.Reservations
        //                .Where(r => r.PropertyID == reservation.Property.PropertyID
        //                            && r.Status == rStatus.Active
        //                            && (
        //                                (r.CheckOutDate > reservation.CheckInDate && r.CheckOutDate <= reservation.CheckOutDate) ||
        //                                (r.CheckInDate >= reservation.CheckInDate && r.CheckInDate < reservation.CheckOutDate) ||
        //                                (r.CheckInDate <= reservation.CheckInDate && r.CheckOutDate >= reservation.CheckOutDate) ||
        //                                (r.CheckInDate >= reservation.CheckInDate && r.CheckOutDate <= reservation.CheckOutDate)))
        //                .ToList();

        //            if (conflictingReservations.Any())
        //            {
        //                return View("Error", new string[] { $"Reservation with ID {id} conflicts with another active reservation. Please modify your dates." });
        //            }

        //            if (reservation.CheckInDate < DateTime.Now)
        //            {
        //                return View("Error", new string[] { $"Reservation with ID {id} has a past check-in date and cannot be confirmed." });
        //            }

        //            // Confirm the reservation
        //            reservation.Status = rStatus.Active;
        //            reservation.ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetConfirmNumber(_context);
        //            _context.Update(reservation);
        //        }

        //        // Save changes for all updated reservations
        //        await _context.SaveChangesAsync();

        //        return RedirectToAction("Details", "Reservation", new { id = IdstoCheckout[0] });
        //    }




        public ActionResult Cancel(ReservationModificationModel rmm)
        {
            //if RoleModificationModel is valid, add new users
            if (ModelState.IsValid)
            {
                //if there are users to make inactive (terminate for admins), inactivate them
                if (rmm.IdsToCancel != null)
                {
                    //loop through all the ids to make inactive
                    foreach (Int32 reservationId in rmm.IdsToCancel)
                    {
                        //find the reservation in the database using their id
                        Reservation reservation = _context.Reservations.Include(o => o.User).FirstOrDefault(r => r.ReservationID == reservationId);

                        // attempt to change status of the reservation to cancelled
                        try
                        {
                            reservation.Status = rStatus.Cancelled;
                            //save the changes
                            _context.Update(reservation);
                            _context.SaveChanges();
                        }
                        // if attempt did not work, show user the error page
                        catch (Exception ex)
                        {
                            return View("Error", ex);
                        }
                    }
                }
                //this is the happy path - all edits worked
                //take the user back to the RoleAdmin Index page
                return RedirectToAction("Index");
            }
            //this is a sad path - the status was not found
            //show the user the error page
            return View("Error", new string[] { "Unable to cancel reservation." });
        }



        [Authorize(Roles = "Customer,Admin")]
        public async Task<IActionResult> ConfirmReservation(int? ridc)
        {
            if (ridc == null)
            {
                return View("Error", new String[] { "Unable to specify reservation to confirm." });
            }

            // Find the reservation including property and user details
            Reservation reservation = _context.Reservations
                .Include(r => r.Property)
                .Include(r => r.User)
                .FirstOrDefault(r => r.ReservationID == ridc);

            if (reservation == null)
            {
                return View("Error", new String[] { "Reservation not found." });
            }

            // Check for conflicts
            var conflictingReservations = _context.Reservations
                .Where(r => r.Property.PropertyID == reservation.Property.PropertyID &&
                            r.Status == rStatus.Active &&
                            (
                                (r.CheckOutDate > reservation.CheckInDate && r.CheckOutDate <= reservation.CheckOutDate) ||
                                (r.CheckInDate >= reservation.CheckInDate && r.CheckInDate < reservation.CheckOutDate) ||
                                (r.CheckInDate <= reservation.CheckInDate && r.CheckOutDate >= reservation.CheckOutDate) ||
                                (r.CheckInDate >= reservation.CheckInDate && r.CheckOutDate <= reservation.CheckOutDate)
                            ))
                .ToList();

            if (conflictingReservations.Any())
            {
                return View("Error", new String[] {
            "Oops! This reservation conflicts with another active reservation. Please modify the dates or choose a different property."
        });
            }

            if ((reservation.CheckInDate - DateTime.Now).TotalDays < 0)
            {
                return View("Error", new String[] {
            "Oops! This reservation has a check-in date in the past. Please modify the dates."
        });
            }

            // Set reservation status to active
            reservation.Status = rStatus.Active;
            reservation.ConfirmationNumber = Utilities.GenerateNextConfirmationNumber.GetConfirmNumber(_context);
            _context.Update(reservation);
            await _context.SaveChangesAsync();

            // Redirect to the confirmation page
            return RedirectToAction("Details", new { rid = reservation.ReservationID });
        }

        // GET: Reservations/ReservationConfirmation
        // This is the confirmation page
        [Authorize(Roles = "Customer,Admin")]
        public IActionResult ReservationConfirmation(int? rid)
        {
            if (rid == null)
            {
                return View("Error", new String[] { "There was an error displaying this reservation confirmation!" });
            }

            // Find the reservation
            Reservation reservation = _context.Reservations
                .Include(r => r.Property)
                .Include(r => r.User)
                .FirstOrDefault(r => r.ReservationID == rid);

            if (reservation == null)
            {
                return View("Error", new String[] { "Reservation not found." });
            }

            return View(reservation);
        }




        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.ReservationID == id);
        }


        // method to check if reservation times have a conflict
        private bool IsReservationConflict(Reservation newReservation)
        {
            return _context.Reservations
                .Any(existingReservation =>
                    existingReservation.PropertyID == newReservation.PropertyID && // Same property
                    existingReservation.ReservationID != newReservation.ReservationID && // Exclude the same reservation
                    (
                        // New check-in date overlaps
                        (newReservation.CheckInDate >= existingReservation.CheckInDate &&
                         newReservation.CheckInDate < existingReservation.CheckOutDate) ||

                        // New check-out date overlaps
                        (newReservation.CheckOutDate > existingReservation.CheckInDate &&
                         newReservation.CheckOutDate <= existingReservation.CheckOutDate) ||

                        // New reservation completely overlaps existing reservation
                        (newReservation.CheckInDate <= existingReservation.CheckInDate &&
                         newReservation.CheckOutDate >= existingReservation.CheckOutDate)
                    ));
        }

        // populate customers viewbag for admin to make reservation for them
        private SelectList GetAllCustomersSelectList()
        {

            //Make list to hold customers
            List<AppUser> Customers = new List<AppUser>();

            foreach (AppUser user in _context.Users.Where(u => u.Role == "Customer" && u.IsActive == aStatus.Active).ToList())
            {
                Customers.Add(user);
            }

            //convert the list to a SelectList by calling SelectList constructor
            SelectList customerSelectList = new SelectList(Customers.OrderBy(c => c.Email), "Email", "Email");

            //return the electList
            return customerSelectList;
        }
    }
}

