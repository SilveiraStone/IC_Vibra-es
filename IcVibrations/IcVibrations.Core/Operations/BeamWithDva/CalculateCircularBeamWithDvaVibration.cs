﻿using IcVibrations.Common.Profiles;
using IcVibrations.Core.Mapper;
using IcVibrations.Core.Mapper.Profiles;
using IcVibrations.Core.Models.BeamWithDynamicVibrationAbsorber;
using IcVibrations.Core.Validators.Profiles;
using IcVibrations.Methods.AuxiliarOperations;
using IcVibrations.Methods.NewmarkMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace IcVibrations.Core.Operations.BeamWithDva
{
    /// <summary>
    /// It's responsible to calculate the vibration in a circular beam with dynamic vibration absorber.
    /// </summary>
    public class CalculateCircularBeamWithDvaVibration : CalculateBeamWithDvaVibration<CircularProfile>
    {
        /// <summary>
        /// Class construtor.
        /// </summary>
        /// <param name="newmarkMethod"></param>
        /// <param name="mappingResolver"></param>
        /// <param name="profileValidator"></param>
        /// <param name="auxiliarOperation"></param>
        /// <param name="profileMapper"></param>
        public CalculateCircularBeamWithDvaVibration(
            INewmarkMethod<BeamWithDva<CircularProfile>, CircularProfile> newmarkMethod,
            IMappingResolver mappingResolver, 
            IProfileValidator<CircularProfile> profileValidator, 
            IAuxiliarOperation auxiliarOperation, 
            IProfileMapper<CircularProfile> profileMapper) 
            : base(newmarkMethod, mappingResolver, profileValidator, auxiliarOperation, profileMapper)
        {
        }
    }
}
