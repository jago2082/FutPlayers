﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string Name { get; set; }

        public virtual ICollection<City> Citys { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
