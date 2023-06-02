using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0044.T000
{
    /// <inheritdoc cref="IProjectName"/>
    [StrongTypeImplementationMarker]
    public class ProjectName : TypedBase<string>, IStrongTypeMarker,
        IProjectName
    {
        public ProjectName(string value)
            : base(value)
        {
        }
    }
}