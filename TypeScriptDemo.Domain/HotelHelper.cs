using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeScriptDemo.Domain
{

    public static class HotelHelper
    {
          static IList<Hotel> Hotels = new List<Hotel> {
              new Hotel(){ HotelId = 1, Name = "Taj", City = "Pune"},
              new Hotel(){ HotelId = 2, Name = "Hyatt", City = "Pune"},
              new Hotel(){ HotelId = 3, Name = "Barbossa", City = "Pune"},
              new Hotel(){ HotelId = 4, Name = "Orchid", City = "Pune"}
          };

        static IList<HotelReview> HotelReviews = new List<HotelReview> {
                new HotelReview() { HotelId = 1,  ReviewId = 1, ReviewerName =  "Chirag" , Comments = "Comfortable stay", Rating = Rating.Good, ReviewDate = DateTime.Now.AddDays(-4) },
                new HotelReview() { HotelId = 1,  ReviewId = 2, ReviewerName = "Rohit" , Comments = "Clean room, good food but slow service", Rating = Rating.Good, ReviewDate = DateTime.Now.AddDays(-7) },
                new HotelReview() { HotelId = 1, ReviewId = 3, ReviewerName = "Rupesh" , Comments = "Average food & Service", Rating = Rating.Average, ReviewDate = DateTime.Now.AddDays(-7) },
                new HotelReview() { HotelId = 1, ReviewId = 4, ReviewerName = "Mohit" , Comments = "Clean room, good food", Rating = Rating.Good, ReviewDate = DateTime.Now.AddDays(-5) },
                new HotelReview() { HotelId = 1, ReviewId = 5, ReviewerName = "Suraj" , Comments = "Spacious room, good food", Rating = Rating.Good, ReviewDate = DateTime.Now.AddDays(-43) },
                new HotelReview() { HotelId = 1, ReviewId = 6, ReviewerName = "Rajesh" , Comments = "Average food, Clean room", Rating = Rating.Average, ReviewDate = DateTime.Now.AddDays(-32) },

                new HotelReview() { HotelId = 2,  ReviewId = 8, ReviewerName =  "Chirag" , Comments = "Comfortable stay", Rating = Rating.Good, ReviewDate = DateTime.Now.AddDays(-4) },
                new HotelReview() { HotelId = 2,  ReviewId = 9, ReviewerName = "Rohit" , Comments = "Clean room, good food but slow service", Rating = Rating.Good, ReviewDate = DateTime.Now.AddDays(-2) },
                new HotelReview() { HotelId = 2, ReviewId = 10, ReviewerName = "Rupesh" , Comments = "Average food & Service", Rating = Rating.Average, ReviewDate = DateTime.Now.AddDays(-55) },
                new HotelReview() { HotelId = 2, ReviewId = 11, ReviewerName = "Mohit" , Comments = "Clean room, good food", Rating = Rating.Good, ReviewDate = DateTime.Now.AddDays(-43) },
                new HotelReview() { HotelId = 2, ReviewId = 12, ReviewerName = "Suraj" , Comments = "Spacious room, good food", Rating = Rating.Good, ReviewDate = DateTime.Now.AddDays(-24) },
                new HotelReview() { HotelId = 2, ReviewId = 13, ReviewerName = "Rajesh" , Comments = "Average food, Clean room", Rating = Rating.Average, ReviewDate = DateTime.Now.AddDays(-48) },

                new HotelReview() { HotelId = 3,  ReviewId = 15, ReviewerName =  "Chirag" , Comments = "Comfortable stay", Rating = Rating.Good, ReviewDate = DateTime.Now.AddDays(-4) },
                new HotelReview() { HotelId = 3,  ReviewId = 16, ReviewerName = "Rohit" , Comments = "Clean room, good food but slow service", Rating = Rating.Good, ReviewDate = DateTime.Now.AddDays(-24) },
                new HotelReview() { HotelId = 3, ReviewId = 17, ReviewerName = "Rupesh" , Comments = "Average food & Service", Rating = Rating.Average, ReviewDate = DateTime.Now.AddDays(-14) },
                new HotelReview() { HotelId = 3, ReviewId = 18, ReviewerName = "Mohit" , Comments = "Clean room, good food", Rating = Rating.Good, ReviewDate = DateTime.Now.AddDays(-94) },
                new HotelReview() { HotelId = 3, ReviewId = 19, ReviewerName = "Suraj" , Comments = "Spacious room, good food", Rating = Rating.Good, ReviewDate = DateTime.Now.AddDays(-34) },
                new HotelReview() { HotelId = 3, ReviewId = 20, ReviewerName = "Rajesh" , Comments = "Average food, Clean room", Rating = Rating.Average, ReviewDate = DateTime.Now.AddDays(-44) },
                new HotelReview() { HotelId = 3, ReviewId = 21, ReviewerName = "Mukesh" , Comments = "Filthy room, Poor service", Rating = Rating.Bad, ReviewDate = DateTime.Now.AddDays(-54) }
         };

        public  static IList<Hotel> GetHotels()
        {
            return Hotels;
        }
        
        public  static IList<HotelReview> GetReviews(int hotelId)
        {
            return HotelReviews;
        }
    } 
}
