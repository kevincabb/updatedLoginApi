using System;
using System.Collections.Generic;

#nullable disable

namespace updatedLoginApi_1.Context
{
    public partial class User
    {
        public int UserId { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string Email { get; set; }
        public string HashPassword { get; set; }
        public string Salt { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
