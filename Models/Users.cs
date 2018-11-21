using System;
using System.Collections.Generic;

namespace HelloApi.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
