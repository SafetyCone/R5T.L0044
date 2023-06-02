using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0044.T000
{
    /// <inheritdoc cref="IProjectNameToken"/>
    [StrongTypeImplementationMarker]
    public class ProjectNameToken : TypedBase<string>, IStrongTypeMarker,
        IProjectNameToken
    {
        public ProjectNameToken(string value)
            : base(value)
        {
        }
    }
}