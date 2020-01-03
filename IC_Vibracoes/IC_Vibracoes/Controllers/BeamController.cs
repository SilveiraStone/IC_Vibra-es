﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IC_Vibrations.Core.Operations.Piezoelectric.Calculate;
using IC_Vibrations.DataContract;
using IC_Vibrations.DataContract.Beam;
using IC_Vibrations.DataContract.Beam.CalculatePiezoelectric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    [Route("api/piezoelectric")]
    public class BeamController : ControllerBase
    {
        private readonly ICalculatePiezoelectric _calculatePiezoelectric;

        public BeamController(ICalculatePiezoelectric calculatePiezoelectric)
        {
            this._calculatePiezoelectric = calculatePiezoelectric;
        }

        public ActionResult<CalculateBeamResponse> Calculate(BeamRequestData requestData)
        {
            CalculateBeamRequest request = new CalculateBeamRequest(requestData);
            //mudar para receber um arquivo
            CalculateBeamResponse response = this._calculatePiezoelectric.Process(request);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}