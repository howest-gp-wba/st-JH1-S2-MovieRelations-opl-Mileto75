using System.Collections.Generic;
using Wba.Oefening.RateAMovie.Core.Entities;

namespace Wba.Oefening.RateAMovie.Core.Entities
{
    public class Company
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
