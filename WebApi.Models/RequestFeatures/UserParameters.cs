﻿namespace WebApi.Entities.RequestFeatures
{
    public class UserParameters : RequestFeatures.RequestParameters
    {
        public uint MinAge { get; set; }

        public uint MaxAge { get; set; } = int.MaxValue;

        public bool ValidAgeRange => MaxAge > MinAge;
    }
}
