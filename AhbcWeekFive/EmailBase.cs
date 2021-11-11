using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFive
{
    public abstract class EmailBase
    {
        private string message;
        public string ToAddress { get; set; }
        public string Message { get; set; }

        public abstract void SendEmail();

        public virtual string GetReturn()
        {
            return "";
        }

        public void LogMessage()
        {
            // Log message
            CreateMessage("Stuff");
        }

        private string CreateMessage(string info)
        {
            message = message + info;
            return message;
        }
    }
}
