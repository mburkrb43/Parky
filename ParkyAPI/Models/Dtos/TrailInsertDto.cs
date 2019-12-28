﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static ParkyAPI.Models.Trail;

namespace ParkyAPI.Models.Dtos
{
    public class TrailInsertDto
    {
       

        [Required]
        public string Name { get; set; }

        [Required]
        public double Distance { get; set; }

        
        public DifficultType Difficulty { get; set; }

        [Required]
        public int NationalParkId { get; set; }

    }
}
