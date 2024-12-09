
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fa24group8finalproject.DAL;
using fa24group8finalproject.Models;

namespace fa24group8finalproject.Seeding
{
    public static class SeedingReviews
    {
        public static async Task SeedReviews(AppDbContext db)
        {
            // Create a list of reviews
            List<PropertyReview> Reviews = new List<PropertyReview>();

            PropertyReview r1 = new PropertyReview()
            {
                Rating = 4,
                Review = " ",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r1.User = db.Users.FirstOrDefault(r => r.Email == "father.Ingram@aool.com");
            r1.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3127);
            Reviews.Add(r1);

            PropertyReview r2 = new PropertyReview()
            {
                Rating = 3,
                Review = "It was meh, ya know? It was really close to the coast, but the beaches were kinda trashed. The apartment was nice, but there wasn't an elevator.",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r2.User = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com");
            r2.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3085);
            Reviews.Add(r2);

            PropertyReview r3 = new PropertyReview()
            {
                Rating = 4,
                Review = " ",
                Dispute = "The customer did not provide a valid reason for this rating.",
                dStatus = disputeStatus.Accepted
            };
            r3.User = db.Users.FirstOrDefault(r => r.Email == "father.Ingram@aool.com");
            r3.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3161);
            Reviews.Add(r3);

            PropertyReview r4 = new PropertyReview()
            {
                Rating = 2,
                Review = " ",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r4.User = db.Users.FirstOrDefault(r => r.Email == "tuck33@puppy.com");
            r4.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3127);
            Reviews.Add(r4);

            PropertyReview r5 = new PropertyReview()
            {
                Rating = 3,
                Review = "Nebraska was... interesting",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r5.User = db.Users.FirstOrDefault(r => r.Email == "father.Ingram@aool.com");
            r5.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3107);
            Reviews.Add(r5);

            PropertyReview r6 = new PropertyReview()
            {
                Rating = 1,
                Review = "There was corn EVERYWHERE! I looked left and BAM, CORN. Looked right, BAM, CORN",
                Dispute = "It is not my fault there was corn. It was not my corn!",
                dStatus = disputeStatus.notViewedYet
            };
            r6.User = db.Users.FirstOrDefault(r => r.Email == "tfreeley@puppy.com");
            r6.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3107);
            Reviews.Add(r6);

            PropertyReview r7 = new PropertyReview()
            {
                Rating = 1,
                Review = "Worst. Stay. Ever. Never using BevoBnB again",
                Dispute = "BevoBnB is the best",
                dStatus = disputeStatus.inDispute
            };
            r7.User = db.Users.FirstOrDefault(r => r.Email == "ra@aoo.com");
            r7.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3107);
            Reviews.Add(r7);

            PropertyReview r8 = new PropertyReview()
            {
                Rating = 5,
                Review = " ",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r8.User = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com");
            r8.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3065);
            Reviews.Add(r8);

            PropertyReview r9 = new PropertyReview()
            {
                Rating = 2,
                Review = " ",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r9.User = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com");
            r9.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3133);
            Reviews.Add(r9);

            PropertyReview r10 = new PropertyReview()
            {
                Rating = 1,
                Review = "It was SO hard to book this place. Who coded this site anyway? ;)",
                Dispute = "The website was coded by students so the owner should not be penalized!",
                dStatus = disputeStatus.notViewedYet
            };
            r10.User = db.Users.FirstOrDefault(r => r.Email == "tfreeley@puppy.com");
            r10.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3065);
            Reviews.Add(r10);

            PropertyReview r11 = new PropertyReview()
            {
                Rating = 4,
                Review = " ",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r11.User = db.Users.FirstOrDefault(r => r.Email == "tuck33@puppy.com");
            r11.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3067);
            Reviews.Add(r11);

            PropertyReview r12 = new PropertyReview()
            {
                Rating = 5,
                Review = "This place rocked!",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r12.User = db.Users.FirstOrDefault(r => r.Email == "ra@aoo.com");
            r12.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3065);
            Reviews.Add(r12);

            PropertyReview r13 = new PropertyReview()
            {
                Rating = 4,
                Review = " ",
                Dispute = "I do not understand this.",
                dStatus = disputeStatus.inDispute
            };
            r13.User = db.Users.FirstOrDefault(r => r.Email == "fd@puppy.com");
            r13.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3065);
            Reviews.Add(r13);

            PropertyReview r14 = new PropertyReview()
            {
                Rating = 4,
                Review = " ",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r14.User = db.Users.FirstOrDefault(r => r.Email == "lamemartin.Martin@aool.com");
            r14.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3133);
            Reviews.Add(r14);

            PropertyReview r15 = new PropertyReview()
            {
                Rating = 1,
                Review = "There were 1...5...22 roaches? I lost count.",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r15.User = db.Users.FirstOrDefault(r => r.Email == "fd@puppy.com");
            r15.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3107);
            Reviews.Add(r15);

            PropertyReview r16 = new PropertyReview()
            {
                Rating = 1,
                Review = " ",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r16.User = db.Users.FirstOrDefault(r => r.Email == "sheff44@puppy.com");
            r16.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3085);
            Reviews.Add(r16);

            PropertyReview r17 = new PropertyReview()
            {
                Rating = 4,
                Review = "I LOVED the place! Had a nice view of the mountains",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r17.User = db.Users.FirstOrDefault(r => r.Email == "fd@puppy.com");
            r17.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3087);
            Reviews.Add(r17);

            PropertyReview r18 = new PropertyReview()
            {
                Rating = 5,
                Review = " ",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r18.User = db.Users.FirstOrDefault(r => r.Email == "tuck33@puppy.com");
            r18.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3087);
            Reviews.Add(r18);

            PropertyReview r19 = new PropertyReview()
            {
                Rating = 5,
                Review = "My stay was amazing! Saved my marriage",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r19.User = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com");
            r19.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3127);
            Reviews.Add(r19);

            PropertyReview r20 = new PropertyReview()
            {
                Rating = 2,
                Review = " ",
                Dispute = "Why??",
                dStatus = disputeStatus.Accepted
            };
            r20.User = db.Users.FirstOrDefault(r => r.Email == "sheff44@puppy.com");
            r20.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3133);
            Reviews.Add(r20);

            PropertyReview r21 = new PropertyReview()
            {
                Rating = 2,
                Review = "My wife's attitude was the only thing rougher than the sand at the nearby beaches",
                Dispute = "No comments provided",
                dStatus = disputeStatus.notViewedYet
            };
            r21.User = db.Users.FirstOrDefault(r => r.Email == "orielly@foxnets.com");
            r21.Property = db.Properties.FirstOrDefault(p => p.PropertyNumber == 3161);
            Reviews.Add(r21);

            // Add the reviews to the database context
            foreach (var review in Reviews)
            {
                db.PropertyReviews.Add(review);
            }
            await db.SaveChangesAsync();
        }
    }
}
