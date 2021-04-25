using System;
using System.Collections.Generic;

#nullable disable

namespace Eprodaja.Models
{
    public partial class JediniceMjere
    {
        public JediniceMjere()
        {
            Proizvodis = new HashSet<Proizvodi>();
        }

        public int JedinicaMjereId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Proizvodi> Proizvodis { get; set; }
    }
}
