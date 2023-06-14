using System;

using R5T.T0131;

using R5T.L0044.T000;
using R5T.L0044.T000.Extensions;


namespace R5T.L0044.Z001
{
    [ValuesMarker]
    public partial interface IProjectNameTokens : IValuesMarker
    {
        public IProjectNameToken Client => "Client".ToProjectNameToken();
        public IProjectNameToken Server => "Server".ToProjectNameToken();
    }
}
