﻿using IcVibrations.Common.Profiles;
using IcVibrations.Models.Beam.Characteristics;
using System.Threading.Tasks;

namespace IcVibrations.Core.Operations.Profiles
{
    /// <summary>
    /// It's responsible to build the profile.
    /// </summary>
    /// <typeparam name="TProfile"></typeparam>
    public abstract class ProfileBuilder<TProfile> : IProfileBuilder<TProfile>
        where TProfile : Profile
    {
        /// <summary>
        /// Method to build the profile.
        /// </summary>
        /// <param name="profile"></param>
        /// <param name="degreesFreedomMaximum"></param>
        /// <returns></returns>
        public abstract Task<GeometricProperty> Execute(TProfile profile, uint degreesFreedomMaximum);
    }
}
