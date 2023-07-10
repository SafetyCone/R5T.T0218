using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0218
{
    /// <inheritdoc cref="ITargetFrameworkMoniker"/>
    [StrongTypeImplementationMarker]
    public class TargetFrameworkMoniker : TypedBase<string>, IStrongTypeMarker,
        ITargetFrameworkMoniker
    {
        public TargetFrameworkMoniker(string value)
            : base(value)
        {
        }
    }
}