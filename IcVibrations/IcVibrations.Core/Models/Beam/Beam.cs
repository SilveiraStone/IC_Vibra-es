﻿using IcVibrations.Models.Beam.Characteristics;
using System;
using System.Collections.Generic;
using System.Text;

namespace IcVibrations.Models.Beam
{
    public class Beam
    {
        public int ElementCount { get; set; }

        public Material Material { get; set; }

        public Profile Profile { get; set; }

        public Fastening FirstFastening { get; set; }

        public Fastening LastFastening { get; set; }

        public double Length { get; set; }

        //public double[,] Mass { get; set; }

        //public double[,] Hardness { get; set; }

        //public double[,] Damping { get; set; }
    }
}
