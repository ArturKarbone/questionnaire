﻿using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace Questionnaire.Video_Store.Domain
{
    class Movie
    {
        public string Title { get; set; }
        public int PriceCode { get; set; }
        public MovieType MovieType { get; set; }    
    }

    enum MovieType
    {
        Children = 1,
        Regular = 2,
        NewRelease = 3
    }
}
