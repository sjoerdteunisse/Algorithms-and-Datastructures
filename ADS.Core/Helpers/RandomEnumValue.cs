using System;

namespace ADS.Core.Helpers
{
    public class RandomEnumValue
    {
        public static T RandomEnum<T>(int seed)
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(new Random(seed).Next(v.Length));
        }
    }
}
