using System.Collections.Generic;

namespace Wba.Oefening.RateAMovie.Core.Entities
{
    public class Actor
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Movie> MovieAppearances { get; set; }
    }
}
