using System;

using R5T.T0132;


namespace R5T.T0218.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ITargetFrameworkMoniker"/>
        public ITargetFrameworkMoniker ToTargetFrameworkMoniker(string value)
        {
            var output = new TargetFrameworkMoniker(value);
            return output;
        }
    }
}
