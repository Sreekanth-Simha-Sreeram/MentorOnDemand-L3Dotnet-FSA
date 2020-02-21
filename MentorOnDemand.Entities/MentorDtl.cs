using System;
using System.Collections.Generic;
using System.Text;

namespace MentorOnDemand.Entities
{
    public class MentorDtl
    {
        public virtual long Id { get; set; }
        public virtual string Email { get; set; }
        public virtual string Technology { get; set; }
        public virtual string Role { get; set; }
        public virtual float Exprience { get; set; }
        public virtual string Facilities { get; set; }
        public virtual float Fees { get; set; }
        public virtual float WorkHours { get; set; }
        public virtual int Rating { get; set; }
    }
}
