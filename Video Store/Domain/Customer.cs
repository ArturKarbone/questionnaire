﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Questionnaire.Video_Store.Domain
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}".Trim();
        public List<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
