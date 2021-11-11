using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFive
{
    class InterviewEmailBase : EmailBase
    {
        public Guid CandidateID { get; set; }

        public override void SendEmail()
        {
            // code
        }

        public override sealed string GetReturn()
        {
            string baseString = base.GetReturn();

            return "my string" + baseString;
        }
    }
}
