﻿using IcVibrations.Core.DTO;
using IcVibrations.Core.Mapper;
using IcVibrations.Core.Models;
using IcVibrations.Core.Models.Piezoelectric;
using IcVibrations.Core.Validators.Beam;
using IcVibrations.Core.Validators.MethodParameters;
using IcVibrations.DataContracts.Beam;
using IcVibrations.DataContracts.Piezoelectric;
using IcVibrations.DataContracts.Piezoelectric.Calculate;
using IcVibrations.Methods.AuxiliarOperations;
using IcVibrations.Methods.NewmarkMethod;
using IcVibrations.Models.Beam;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IcVibrations.Core.Operations.PiezoelectricVibration.Calculate
{
    public class CalculatePiezoelectricVibration : OperationBase<CalculatePiezoelectricRequest, CalculatePiezoelectricResponse>, ICalculatePiezoelectricVibration
    {
        private readonly IMethodParameterValidator _methodParameterValidator;
        private readonly IBeamRequestValidator<RectangularBeamRequestData> _beamRequestValidator;
        private readonly INewmarkMethod _newmarkMethod;
        private readonly IMappingResolver _mappingResolver;

        public CalculatePiezoelectricVibration(
            IMethodParameterValidator methodParameterValidator,
            IBeamRequestValidator<RectangularBeamRequestData> beamRequestValidator,
            INewmarkMethod newmarkMethod,
            IMappingResolver mappingResolver)
        {
            this._methodParameterValidator = methodParameterValidator;
            this._beamRequestValidator = beamRequestValidator;
            this._newmarkMethod = newmarkMethod;
            this._mappingResolver = mappingResolver;
        }

        protected override async Task<CalculatePiezoelectricResponse> ProcessOperation(CalculatePiezoelectricRequest request)
        {
            CalculatePiezoelectricResponse response = new CalculatePiezoelectricResponse();

            RectangularBeam beam = this._mappingResolver.BuildFrom(request.BeamData);

            RectangularPiezoelectric piezoelectric = this._mappingResolver.BuildFrom(request.PiezoelectricRequestData);

            uint degreesFreedomMaximum = this.DegreesFreedomMaximum(request.BeamData.ElementCount);

            NewmarkMethodInput input = await this._newmarkMethod.CreateInput(request.MethodParameterData, beam, piezoelectric, degreesFreedomMaximum);

            NewmarkMethodOutput output = await this._newmarkMethod.CreateOutput(input, response);

            response.Data = this._mappingResolver.BuildFrom(output);

            return response;
        }

        protected override async Task<CalculatePiezoelectricResponse> ValidateOperation(CalculatePiezoelectricRequest request)
        {
            CalculatePiezoelectricResponse response = new CalculatePiezoelectricResponse();

            if (!this._methodParameterValidator.Execute(request.MethodParameterData, response))
            {
                return response;
            }

            // Validate piezoelectric

            if (!this._beamRequestValidator.Execute(request.BeamData, response))
            {
                return response;
            }

            return response;
        }

        public uint DegreesFreedomMaximum(uint element)
        {
            uint degreesFreedomMaximum = (element + 1) * Constants.DegreesFreedom;
            return degreesFreedomMaximum;
        }
    }
}
