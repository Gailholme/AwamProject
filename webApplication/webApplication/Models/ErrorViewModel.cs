using System;

namespace webApplication.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Person
    {
        public String UName { get; set; }
        public String UCity{ get; set; }
    }
}