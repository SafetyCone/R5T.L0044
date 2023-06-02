using System;

using R5T.T0178;


namespace R5T.L0044.T000
{
    /// <summary>
    /// Strongly-types a string as a project name token.
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectNameToken : IStrongTypeMarker,
        L0043.T000.INameToken
    {
    }
}