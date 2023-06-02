using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0044.T000
{
    /// <inheritdoc cref="IProjectNamePart"/>
    [StrongTypeImplementationMarker]
    public class ProjectNamePart : TypedBase<string>, IStrongTypeMarker,
        IProjectNamePart
    {
        public ProjectNamePart(string value)
            : base(value)
        {
        }
    }
}