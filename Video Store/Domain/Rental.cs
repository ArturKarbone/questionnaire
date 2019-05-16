using System;
using System.Collections.Generic;
using System.Text;

namespace Questionnaire.Video_Store.Domain
{
    class Rental
    {
        public Movie Movie  { get; set; }
        public DateTime RentedAt { get; set; }
        public DateTime? ReturnedAt { get; set; }
        public int DaysRented => 
            (ReturnedAt ?? DateTime.Now)
            .Subtract(RentedAt)
            .Days;
    }
}
