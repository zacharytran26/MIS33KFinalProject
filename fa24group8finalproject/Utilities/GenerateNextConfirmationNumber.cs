using fa24group8finalproject.DAL;

namespace fa24group8finalproject.Utilities
{
    public class GenerateNextConfirmationNumber
    { 
        public static Int32 GetConfirmNumber(AppDbContext _context)
        {
            //set a constant to designate where the registration numbers 
            //should start
            const Int32 START_NUMBER = 21901;

            Int32 intMaxConfirmNumber; //the current maximum course number
            Int32 intNextConfirmNumber; //the course number for the next class

            if (_context.Reservations.Count() == 0) //there are no reservations in the database yet
            {
                intMaxConfirmNumber = START_NUMBER; // reservation numbers start at 21901
            }
            else
            {
                intMaxConfirmNumber = _context.Reservations.Max(o => o.ConfirmationNumber); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxConfirmNumber < START_NUMBER)
            {
                intMaxConfirmNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextConfirmNumber = intMaxConfirmNumber + 1;

            //return the value
            return intNextConfirmNumber;
        }

    }
}