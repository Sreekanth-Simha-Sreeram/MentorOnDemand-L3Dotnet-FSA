using MentorOnDemand.BuisnessLayer.Interfaces;
using MentorOnDemand.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentorOnDemand.BuisnessLayer.Services
{
    public class UserServices : IUserServices
    {
        public User AddProfile(long UserId)
        {
            User user = new User();
            return user;

        }

        public bool AssignRating(int Rating)
        {
            if (true)
            {
                return true;
            }
            else
            {

            }
        }

        public User EditProfile(long UserId)
        {
            User user = new User();
            return user;

        }

        public List<MentorDtl> SearchMentor(string Technology)
        {
            List<MentorDtl> mentor = new List<MentorDtl>();
            return mentor;
        }

        public MentorDtl SelectMentor(long MentorId)
        {
            MentorDtl mentor = new MentorDtl();
            return mentor;

        }

        public bool SendProposal(User User, long MentorId)
        {
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public User ViewProfile(long UserId)
        {
            User user = new User();
            return user;

        }

        public List<TrainingDetails> ViewTrainings(string status)
        {
            List<TrainingDetails> TrainingDetails = new List<TrainingDetails>();
            return TrainingDetails;
        }
    }
}
