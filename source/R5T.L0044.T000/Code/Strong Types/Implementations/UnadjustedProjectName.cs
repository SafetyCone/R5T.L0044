using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0044.T000
{
    /// <inheritdoc cref="IUnadjustedProjectName"/>
    [StrongTypeImplementationMarker]
    public class UnadjustedProjectName : TypedBase<string>, IStrongTypeMarker,
        IUnadjustedProjectName
    {
        public UnadjustedProjectName(string value)
            : base(value)
        {
        }
    }
}