﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IcVibrations.Models.Beam.Characteristics
{
    public abstract class Fastening
    {
        public abstract bool Displacement { get; }

        public abstract bool Angle { get; }

    }

    public class Fixed : Fastening
    {
        public override bool Displacement => false;

        public override bool Angle => false;

    }

    public class Simple : Fastening
    {
        public override bool Displacement => true;

        public override bool Angle => true;

    }

    public class Pinned : Fastening
    {
        public override bool Displacement => false;

        public override bool Angle => true;

    }
}