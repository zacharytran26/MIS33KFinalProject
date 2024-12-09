//TODO: Change this using statement to match your project
using fa24group8finalproject.DAL;
using fa24group8finalproject.Models;
using fa24group8finalproject.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
//WHATEVER I ADDED PLS DO NOT DELETE
namespace fa24group8finalproject.Controllers
{
    //to manage account, we want everyone to be authenticated
    [Authorize]
    public class AccountController : Controller
    {
        private SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> _userManager;
        private PasswordValidator<AppUser> _passwordValidator;
        private AppDbContext _context;

        public AccountController(AppDbContext appDbContext, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _context = appDbContext;
            _userManager = userManager;
            _signInManager = signIn;
            //user manager only has one password validator
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }

        // GET: /Account/Register
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            // Displays the central register page with buttons
            return View();
        }

        // POST: Redirect to RegisterCustomer
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult RedirectToCustomerRegistration()
        {
            return RedirectToAction("RegisterCustomer");
        }

        // POST: Redirect to RegisterHost
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult RedirectToHostRegistration()
        {
            return RedirectToAction("RegisterHost");
        }

        // GET: /Account/RegisterCustomer
        [HttpGet]
        [AllowAnonymous]
        public IActionResult RegisterCustomer()
        {
            return View();
        }

        // POST: /Account/Register/Customer
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterCustomer(RegisterViewModel rvm)
        {
            //if registration data is valid, create a new user on the database
            if (ModelState.IsValid ==false)
            {
                //this is the sad path - something went wrong, 
                //return the user to the register page to try again
                return View(rvm);
            }
            try
            {
                // Calculate and validate the user's age
                DateTime today = DateTime.Today;
                int age = today.Year - rvm.Birthday.Year;

                if (rvm.Birthday.Date > today.AddYears(-age)) age--;

                if (age < 18)
                {
                    ModelState.AddModelError("Birthday", "You must be at least 18 years old to register.");
                    return View(rvm); // Redisplay the form with the error
                }
            }
            catch (Exception ex)
            {
                // Log exception if needed and return a general error
                ModelState.AddModelError("", "An error occurred while calculating the age. Please try again.");
                return View(rvm);
            }


            //this code maps the RegisterViewModel to the AppUser domain model
            AppUser newUser = new AppUser
            {
                UserName = rvm.Email,
                Email = rvm.Email,
                PhoneNumber = rvm.PhoneNumber,

                //TODO: Add the rest of the custom user fields here
                //FirstName is included as an example
                FirstName = rvm.FirstName,
                MI = rvm.MI,
                LastName = rvm.LastName,
                StreetAddress = rvm.StreetAddress,
                City = rvm.City,
                State = rvm.State,
                ZipCode = rvm.ZipCode,
                Birthday = rvm.Birthday,
                
            };

            //create AddUserModel
            AddUserModel aum = new AddUserModel()
            {
                User = newUser,
                Password = rvm.Password,
                RoleName = "Customer"
            };

            //This code uses the AddUser utility to create a new user with the specified password
            IdentityResult result = await Utilities.AddUser.AddUserWithRoleAsync(aum, _userManager, _context);

            if (result.Succeeded) //everything is okay
            {
                //NOTE: This code logs the user into the account that they just created
                //You may or may not want to log a user in directly after they register - check
                //the business rules!
                Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, lockoutOnFailure: false);

                //Send the user to the home page
                return RedirectToAction("Index", "Home");
            }
            else  //the add user operation didn't work, and we need to show an error message
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send user back to page with errors
                return View(rvm);
            }
        }

        // GET: /Account/RegisterHost
        [HttpGet]
        [AllowAnonymous]
        public IActionResult RegisterHost()
        {
            return View();
        }

        // POST: Account/Register/Host
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterHost(RegisterViewModel rvm)
        {
            //if registration data is valid, create a new user on the database
            if (ModelState.IsValid == false)
            {
                //this is the sad path - something went wrong, 
                //return the user to the register page to try again
                return View(rvm);
            }

            //this code maps the RegisterViewModel to the AppUser domain model
            AppUser newUser = new AppUser
            {
                UserName = rvm.Email,
                Email = rvm.Email,
                PhoneNumber = rvm.PhoneNumber,

                //TODO: Add the rest of the custom user fields here
                //FirstName is included as an example
                FirstName = rvm.FirstName,
                MI = rvm.MI,
                LastName = rvm.LastName,
                StreetAddress = rvm.StreetAddress,
                City = rvm.City,
                State = rvm.State,
                ZipCode = rvm.ZipCode,
                Birthday = rvm.Birthday
            };
            var emailquery = _context.Users.FirstOrDefault(e => e.UserName == rvm.Email);

            if (rvm.Email == emailquery.ToString())
            {
                
                return View("Error", new String[] {"You need to create an account with an unique email"});
            }
            //create AddUserModel
            AddUserModel aum = new AddUserModel()
            {
                User = newUser,
                Password = rvm.Password,

                //TODO: You will need to change this value if you want to 
                //add the user to a different role - just specify the role name.
                RoleName = "Host"
            };

            //This code uses the AddUser utility to create a new user with the specified password
            IdentityResult result = await Utilities.AddUser.AddUserWithRoleAsync(aum, _userManager, _context);

            if (result.Succeeded) //everything is okay
            {
                //NOTE: This code logs the user into the account that they just created
                //You may or may not want to log a user in directly after they register - check
                //the business rules!
                Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, lockoutOnFailure: false);

                //Send the user to the home page
                return RedirectToAction("Index", "Home");
            }
            else  //the add user operation didn't work, and we need to show an error message
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send user back to page with errors
                return View(rvm);
            }
        }

        [HttpGet]
        [Authorize(Roles ="Admin")]
        public IActionResult RegisterAdmin()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterAdmin(RegisterViewModel rvm)
        {
            //if registration data is valid, create a new user on the database
            if (ModelState.IsValid == false)
            {
                //this is the sad path - something went wrong, 
                //return the user to the register page to try again
                return View(rvm);
            }

            //this code maps the RegisterViewModel to the AppUser domain model
            AppUser newUser = new AppUser
            {
                UserName = rvm.Email,
                Email = rvm.Email,
                PhoneNumber = rvm.PhoneNumber,

                //TODO: Add the rest of the custom user fields here
                //FirstName is included as an example
                FirstName = rvm.FirstName,
                MI = rvm.MI,
                LastName = rvm.LastName,
                StreetAddress = rvm.StreetAddress,
                City = rvm.City,
                State = rvm.State,
                ZipCode = rvm.ZipCode,
                Birthday = rvm.Birthday
            };

            //create AddUserModel
            AddUserModel aum = new AddUserModel()
            {
                User = newUser,
                Password = rvm.Password,

                //TODO: You will need to change this value if you want to 
                //add the user to a different role - just specify the role name.
                RoleName = "Admin"
            };

            //This code uses the AddUser utility to create a new user with the specified password
            IdentityResult result = await Utilities.AddUser.AddUserWithRoleAsync(aum, _userManager, _context);

            if (result.Succeeded) //everything is okay
            {
                //NOTE: This code logs the user into the account that they just created
                //You may or may not want to log a user in directly after they register - check
                //the business rules!
                Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, lockoutOnFailure: false);

                //Send the user to the home page
                return RedirectToAction("Index", "Home");
            }
            else  //the add user operation didn't work, and we need to show an error message
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send user back to page with errors
                return View(rvm);
            }
        }


        // GET: /Account/Login
        //of course, anyone can try and login
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            //this is a pre-build method User.Identity.IsAuthenticated
            if (User.Identity.IsAuthenticated) //user has been redirected here from a page they're not authorized to see
            {
                return View("Error", new string[] { "Access Denied" });
            }
            _signInManager.SignOutAsync(); //this removes any old cookies hanging around
            ViewBag.ReturnUrl = returnUrl; //pass along the page the user should go back to
            return View();
        }

        // POST: /Account/Login
        //this is the method that actually logs you in, so still needs to allowanonymous
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel lvm, string? returnUrl)
        {
            //if user forgot to include user name or password,
            //send them back to the login page to try again
            if (ModelState.IsValid == false)
            {
                return View(lvm);
            }

            //attempt to sign the user in using the SignInManager
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, lvm.RememberMe, lockoutOnFailure: false);

            //if the login worked, take the user to either the url
            //they requested OR the homepage if there isn't a specific url
            if (result.Succeeded)
            {
                //return ?? "/" means if returnUrl is null, substitute "/" (home)
                return Redirect(returnUrl ?? "/");
            }
            else //log in was not successful
            {
                //add an error to the model to show invalid attempt
                ModelState.AddModelError("", "Invalid login attempt.");
                //send user back to login page to try again
                return View(lvm);
            }
        }

        //GET: Account/Index
        public IActionResult Index()
        {
            IndexViewModel ivm = new IndexViewModel();

            //get user info
            String id = User.Identity.Name;
            AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);

            //populate the view model
            //(i.e. map the domain model to the view model)
            ivm.Email = user.Email;
            ivm.HasPassword = true;
            ivm.UserID = user.Id;
            ivm.UserName = user.UserName;
            ivm.Birthday = user.Birthday;
            ivm.FullName = user.FullName;
            ivm.FullAddress = user.FullAddress;
            ivm.PhoneNumber = user.PhoneNumber;

            //send data to the view
            return View(ivm);
        }



        //Logic for change password
        // GET: /Account/ChangePassword
        public ActionResult ChangePassword()
        {
            //don't let the user change the password for the default users
            //this will keep the sample working for everyone
            if (User.Identity.Name == "admin@example.com" || User.Identity.Name == "bevo@example.com")
            {
                return View("Error", new string[] { "You cannot change the password for the default users." });
            }

            return View();
        }



        // POST: /Account/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel cpvm)
        {
            if (User.Identity.Name == "admin@example.com" || User.Identity.Name == "bevo@example.com")
            {
                return View("Error", new string[] { "You cannot change the password for the default users." });
            }


            //if user forgot a field, send them back to 
            //change password page to try again
            if (ModelState.IsValid == false)
            {
                return View(cpvm);
            }

            //Find the logged in user using the UserManager
            AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

            //Attempt to change the password using the UserManager
            var result = await _userManager.ChangePasswordAsync(userLoggedIn, cpvm.OldPassword, cpvm.NewPassword);

            //if the attempt to change the password worked
            if (result.Succeeded)
            {
                //sign in the user with the new password
                await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);

                //send the user back to the home page
                return RedirectToAction("Index", "Home");
            }
            else //attempt to change the password didn't work
            {
                //Add all the errors from the result to the model state
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send the user back to the change password page to try again
                return View(cpvm);
            }
        }

        //GET:/Account/AccessDenied
        public IActionResult AccessDenied(String ReturnURL)
        {
            return View("Error", new string[] { "Access is denied" });
        }


        public IActionResult ChangeAddress(string id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a user to edit" });
            }

            // assigns user, an instance of AppUser, to be user in db with Email == id
            AppUser user = _context.Users
                        .FirstOrDefault(u => u.Email == id);

            // case if registration not found in the database
            if (user == null)
            {
                return View("Error", new String[] { "This user was not found in the database!" });
            }

            //registration does not belong to this user
            if ((User.IsInRole("Customer") || User.IsInRole("Host")) && user.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "You are not authorized to edit this profile!" });
            }

            return View(user);
        }

        // POST: Account/ChangeAddress
        //DONE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeAddress(string id, [Bind("Email,StreetAddress,City,State,ZipCode")] AppUser user)
        {
            string loggedInUser = User.Identity.Name;

            //if code gets this far, update the record
            try
            {
                //find the user in the database
                AppUser dbuser = await _userManager.FindByEmailAsync(user.Email);

                //update the user's address
                dbuser.StreetAddress = user.StreetAddress;
                dbuser.City = user.City;
                dbuser.State = user.State;
                dbuser.ZipCode = user.ZipCode;

                // save changes
                _context.Update(dbuser);
                await _context.SaveChangesAsync();

                // return user to respective account profile page
                if (loggedInUser == user.Email)
                {
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    return RedirectToAction("EditProfile", "RoleAdmin", new { id = dbuser.Id });
                }
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this profile!", ex.Message });
            }
        }

        //Logic for change name
        // GET: /Account/ChangeName
        //DONE
        [Authorize(Roles = "Admin")]
        public IActionResult ChangeName(string id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a user to edit" });
            }

            // assigns user, an instance of AppUser, to be user in db with Email == id
            AppUser user = _context.Users
                        .FirstOrDefault(u => u.Email == id);

            // case if registration not found in the database
            if (user == null)
            {
                return View("Error", new String[] { "This user was not found in the database!" });
            }

            return View(user);
        }

        // POST: Account/ChangeName
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //DONE
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ChangeName(string id, [Bind("Email,FirstName,MI,LastName")] AppUser user)
        {
            string loggedInUser = User.Identity.Name;

            //if code gets this far, update the record
            try
            {
                //find the user in the database
                AppUser dbuser = await _userManager.FindByEmailAsync(user.Email);

                //update the user's name
                dbuser.FirstName = user.FirstName;
                dbuser.MI = user.MI;
                dbuser.LastName = user.LastName;

                //save changes
                _context.Update(dbuser);
                await _context.SaveChangesAsync();

                //return admin to user edit profile page
                return RedirectToAction("EditProfile", "RoleAdmin", new { id = dbuser.Id });
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this profile!", ex.Message });
            }
        }

        //Logic for change phone number
        // GET: /Account/ChangePhoneNumber
        //DONE
        public IActionResult ChangePhoneNumber(string id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a user to edit" });
            }

            // assigns user, an instance of AppUser, to be user in db with Email == id
            AppUser user = _context.Users
                        .FirstOrDefault(u => u.Email == id);

            // case if registration not found in the database
            if (user == null)
            {
                return View("Error", new String[] { "This user was not found in the database!" });
            }

            return View(user);
        }

        // POST: Account/ChangePhoneNumber
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //DONE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePhoneNumber(string id, [Bind("Email,PhoneNumber")] AppUser user)
        {
            string loggedInUser = User.Identity.Name;

            //if code gets this far, update the record
            try
            {
                //find the user in the database
                AppUser dbuser = await _userManager.FindByEmailAsync(user.Email);

                //update the user's phone number
                dbuser.PhoneNumber = user.PhoneNumber;

                //save changes
                _context.Update(dbuser);
                await _context.SaveChangesAsync();

                // return user to respective account profile page
                if (loggedInUser == user.Email)
                {
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    return RedirectToAction("EditProfile", "RoleAdmin", new { id = dbuser.Id });
                }
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this profile!", ex.Message });
            }
        }

        //Logic for change birthday
        // GET: /Account/ChangeBirthday
        //DONE
        public IActionResult ChangeBirthday(string id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a user to edit" });
            }

            // assigns user, an instance of AppUser, to be user in db with Email == id
            AppUser user = _context.Users
                        .FirstOrDefault(u => u.Email == id);

            // case if registration not found in the database
            if (user == null)
            {
                return View("Error", new String[] { "This user was not found in the database!" });
            }

            return View(user);
        }

        // POST: Account/ChangeBirthday
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //DONE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeBirthday(string id, [Bind("Email,Birthday")] AppUser user)
        {
            string loggedInUser = User.Identity.Name;

            //check that age of user is 18 or greater with updated birthday
            try
            {
                ChangeBirthdayViewModel cbvm = new ChangeBirthdayViewModel();
                cbvm.NewBirthday = user.Birthday;
                cbvm.CalcAge();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this profile!", ex.Message });
            }

            //if code gets this far, update the record
            try
            {
                //find the user in the database
                AppUser dbuser = await _userManager.FindByEmailAsync(user.Email);

                //update the user's birthday
                dbuser.Birthday = user.Birthday;

                //save changes
                _context.Update(dbuser);
                await _context.SaveChangesAsync();

                // return user to respective account profile page
                if (loggedInUser == user.Email)
                {
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    return RedirectToAction("EditProfile", "RoleAdmin", new { id = dbuser.Id });
                }
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this profile!", ex.Message });
            }
        }


        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogOff()
        {
            //sign the user out of the application
            _signInManager.SignOutAsync();

            //send the user back to the home page
            return RedirectToAction("Index", "Home");
        }
    }
}