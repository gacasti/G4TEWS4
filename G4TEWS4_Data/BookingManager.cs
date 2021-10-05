using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4TEWS4_Data
{
    public static class BookingManager
    {
        private static TEContext _context = new();
        /// <summary>
        /// Get a list of available packages for the general public
        /// </summary>
        /// <returns>Returns a list of Booking records</returns>
        public static List<Package> GetPackages()
        {
            List<Package> packages;
            packages = _context.Packages.ToList();

            return packages;
        }

        /// <summary>
        /// Add / create a booking for a customer
        /// </summary>
        /// <param name="booking">the booking object to be saved in the database</param>
        public static void AddBooking(Booking booking)
        {
            _context.Add(booking);
            _context.SaveChanges();

        }

        public static List<Booking> GetCustomerBookings(int custId)
        {
            List<Booking> customerBookings = null;
            using (_context)
            {
               

            }

            return customerBookings;
        }
    }
}
