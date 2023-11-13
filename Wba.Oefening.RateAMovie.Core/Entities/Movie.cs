﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Wba.Oefening.RateAMovie.Core.Entities
{
    public class Movie
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public ICollection<Rating> Ratings { get; set; }

        //unshadowed foreign key for Company
        public long CompanyId { get; set; }

        public Company Company { get; set; }

        public ICollection<Actor> Cast { get; set; }

        public ICollection<Director> Directors { get; set; }
    }
}
