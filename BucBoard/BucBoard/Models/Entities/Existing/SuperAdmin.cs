﻿using System;
using System.Collections.Generic;

namespace BucBoard.Models.Entities.Existing
{
    public partial class SuperAdmin
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}