﻿using IcVibrations.Calculator.MainMatrixes;
using IcVibrations.Common.Profiles;
using IcVibrations.Core.Calculator.MainMatrixes.Beam;
using IcVibrations.Core.Mapper;
using IcVibrations.Core.Mapper.Profiles;
using IcVibrations.Core.NewmarkNumericalIntegration;
using IcVibrations.Core.Validators.Profiles;
using IcVibrations.Methods.AuxiliarOperations;

namespace IcVibrations.Core.Operations.Beam
{
    /// <summary>
    /// It's responsible to calculate the vibration in a rectangular beam.
    /// </summary>
    public class CalculateRectangularBeamVibration : CalculateBeamVibration<RectangularProfile>
    {
        /// <summary>
        /// Class construtor.
        /// </summary>
        /// <param name="newmarkMethod"></param>
        /// <param name="mappingResolver"></param>
        /// <param name="profileValidator"></param>
        /// <param name="profileMapper"></param>
        /// <param name="auxiliarOperation"></param>
        /// <param name="mainMatrix"></param>
        /// <param name="commonMainMatrix"></param>
        public CalculateRectangularBeamVibration(
            INewmarkMethod newmarkMethod,
            IMappingResolver mappingResolver,
            IProfileValidator<RectangularProfile> profileValidator,
            IProfileMapper<RectangularProfile> profileMapper,
            IAuxiliarOperation auxiliarOperation, 
            IBeamMainMatrix<RectangularProfile> mainMatrix, 
            ICommonMainMatrix commonMainMatrix) 
            : base(newmarkMethod, mappingResolver, profileValidator, profileMapper, auxiliarOperation, mainMatrix, commonMainMatrix)
        {
        }
    }
}
