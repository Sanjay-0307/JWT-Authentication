﻿namespace JWT_Auth.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string? Role { get; set; }

    }
}
