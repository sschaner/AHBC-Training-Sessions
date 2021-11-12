using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFive
{
    public class CandidateInterviewCacelled : InterviewEmailBase
    {
        public bool IsRescheduled { get; set; }

        public virtual void ScheduleInterview()
        {
            // do stuff
        }

    }
}
