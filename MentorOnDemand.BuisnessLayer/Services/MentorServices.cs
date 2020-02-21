using MentorOnDemand.BuisnessLayer.Interfaces;
using MentorOnDemand.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentorOnDemand.BuisnessLayer.Services
{
    public class MentorServices : IMentorServices
    {
        public bool AcceptProposal(int UserId)
        {
            return true;
        }

        public MentorDtl AddProfile(long MentorId)
        {
            MentorDtl mentor = new MentorDtl();
            return mentor;

        }

        public MentorDtl EditProfile(long MentorId)
        {
            MentorDtl mentor = new MentorDtl();
            return mentor;

        }


        public MentorDtl ViewMentor(long Id)
        {
            MentorDtl mentordetails = new MentorDtl();
            return mentordetails;
        }

        public MentorDtl ViewProfile(long MentorId)
        {
            MentorDtl mentor = new MentorDtl();
            return mentor;

        }

        public User ViewProposal(long UserId)
        {
            User user = new User();
            return user;

        }
    }
}
