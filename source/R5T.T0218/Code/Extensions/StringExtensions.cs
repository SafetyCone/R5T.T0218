using System;


namespace R5T.T0218.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToTargetFrameworkMoniker(string)"/>
        public static ITargetFrameworkMoniker ToTargetFrameworkMoniker(this string value)
        {
            return Instances.StringOperator_Extensions.ToTargetFrameworkMoniker(value);
        }
    }
}
