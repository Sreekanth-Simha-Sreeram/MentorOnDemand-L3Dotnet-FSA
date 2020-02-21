using MentorOnDemand.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentorOnDemand.BuisnessLayer.Interfaces
{
    public interface IUserServices
    {
        User AddProfile(long UserId);
        User ViewProfile(long UserId);
        User EditProfile(long UserId);
        List<MentorDtl> SearchMentor(string Technology);
        MentorDtl SelectMentor(long MentorId);
        bool SendProposal(User User, long MentorId);
        bool AssignRating(int Rating);
        List<TrainingDetails> ViewTrainings(string status);
    }
}
