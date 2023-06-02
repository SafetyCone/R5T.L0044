using System;

using R5T.T0178;


namespace R5T.L0044.T000
{
    /// <summary>
    /// Strongly-types a string as a project name part.
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectNamePart : IStrongTypeMarker,
        L0043.T000.INamePart
    {
    }
}