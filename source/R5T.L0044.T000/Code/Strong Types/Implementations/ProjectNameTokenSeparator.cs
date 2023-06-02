using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0044.T000
{
    /// <inheritdoc cref="IProjectNameTokenSeparator"/>
    [StrongTypeImplementationMarker]
    public class ProjectNameTokenSeparator : TypedBase<string>, IStrongTypeMarker,
        IProjectNameTokenSeparator
    {
        public ProjectNameTokenSeparator(string value)
            : base(value)
        {
        }
    }
}