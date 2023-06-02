using System;

using R5T.T0178;


namespace R5T.L0044.T000
{
    /// <summary>
    /// Strongly-types a string as a project name token separator.
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectNameTokenSeparator : IStrongTypeMarker,
        L0043.T000.INameTokenSeparator
    {
    }
}