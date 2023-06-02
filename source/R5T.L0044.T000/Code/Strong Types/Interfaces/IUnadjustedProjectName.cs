using System;

using R5T.T0178;


namespace R5T.L0044.T000
{
    /// <summary>
    /// Strongly-types a string as an unadjusted project name.
    /// </summary>
    [StrongTypeMarker]
    public interface IUnadjustedProjectName : IStrongTypeMarker,
        L0043.T000.IUnadjustedName
    {
    }
}