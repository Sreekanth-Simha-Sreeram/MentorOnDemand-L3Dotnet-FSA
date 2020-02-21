using MentorOnDemand.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentorOnDemand.BuisnessLayer.Interfaces
{
    public interface IMentorServices
    {
        MentorDtl AddProfile(long MentorId);
        MentorDtl ViewProfile(long MentorId);
        MentorDtl EditProfile(long MentorId);
        User ViewProposal(long UserId);
        MentorDtl ViewMentor(long MentorId);
        bool AcceptProposal(int UserId);
    }
}
