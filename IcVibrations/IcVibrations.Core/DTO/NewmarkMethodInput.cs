﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IcVibrations.Core.DTO
{
    /// <summary>
    /// It represents the input contant of NewmarkMethod operation.
    /// </summary>
    public class NewmarkMethodInput
    {
        /// <summary>
        /// Mass matrix of the object that is analyzed.
        /// </summary>
        public double[,] Mass { get; set; }

        /// <summary>
        /// Hardness matrix of the object that is analyzed.
        /// </summary>
        public double[,] Hardness { get; set; }

        /// <summary>
        /// Damping matrix of the object that is analyzed.
        /// </summary>
        public double[,] Damping { get; set; }

        /// <summary>
        /// Force vector of the object that is analyzed.
        /// </summary>
        public double[] Force { get; set; }

        /// <summary>
        /// Integration constant.
        /// </summary>
        public double A0 { get; set; }

        /// <summary>
        /// Integration constant.
        /// </summary>
        public double A1 { get; set; }

        /// <summary>
        /// Integration constant.
        /// </summary>
        public double A2 { get; set; }

        /// <summary>
        /// Integration constant.
        /// </summary>
        public double A3 { get; set; }

        /// <summary>
        /// Integration constant.
        /// </summary>
        public double A4 { get; set; }

        /// <summary>
        /// Integration constant.
        /// </summary>
        public double A5 { get; set; }
        
        /// <summary>
        /// number of boundary conditions that is true.
        /// </summary>
        public int NumberOfTrueBoundaryConditions { get; set; }
        
        /// <summary>
        /// Initial time.
        /// </summary>
        public double InitialTime { get; set; }

        /// <summary>
        /// Delta time.
        /// </summary>
        public double DeltaTime { get; set; }

        /// <summary>
        /// Number of division in the period.
        /// </summary>
        public double NumberOfPeriodDivisions { get; set; }

        /// <summary>
        /// Angular frequency used in the analysis.
        /// </summary>
        public double AngularFrequency { get; set; }

        /// <summary>
        /// Initial angular frequency in the analysis.
        /// </summary>
        public double InitialAngularFrequency { get; set; }

        /// <summary>
        /// Delta angular frequency.
        /// </summary>
        public double DeltaAngularFrequency { get; set; }

        /// <summary>
        /// Final angular frequency in the analysis.
        /// </summary>
        public double FinalAngularFrequency { get; set; }
    }
}
