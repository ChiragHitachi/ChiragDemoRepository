using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TypeScriptDemo.Domain;

namespace TypeScriptDemo.Controllers
{
    //[Authorize]
    public class HotelReviewController : ApiController
    {
        // GET api/values

        // GET api/values/5
        public IEnumerable<HotelReview> Get(int hotelId)
        {
            return HotelHelper.GetReviews(hotelId);
        }

        // POST api/values
        public void Post([FromBody]HotelReview review)
        {
            var reviews = HotelHelper.GetReviews(review.HotelId);
            reviews.Add(review);
        }

        // PUT api/values/5
        public void Put([FromBody]HotelReview review)
        {
            var reviews = HotelHelper.GetReviews(review.HotelId);
            var currentReview = reviews.FirstOrDefault(r => r.ReviewId == review.ReviewId);
            if (currentReview != null)
            {
                currentReview.Rating = review.Rating;
                currentReview.ReviewDate = DateTime.Now;
                currentReview.ReviewerName = review.ReviewerName;
                currentReview.Comments = review.Comments;
            }
        }

        // DELETE api/values/5
        public void Delete(int hotelId, int reviewId)
        {
            var reviews = HotelHelper.GetReviews(hotelId);
            var review = reviews.FirstOrDefault(r=>r.ReviewId == reviewId);
            if(review != null)
                reviews.Remove(review);
        }
    }
}
