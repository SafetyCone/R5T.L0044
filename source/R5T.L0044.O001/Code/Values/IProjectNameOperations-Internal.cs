using System;

using R5T.T0131;

using R5T.L0044.T000;
using R5T.L0044.X000;


namespace R5T.L0044.O001.Internal
{
    /// <summary>
    /// All project name operations (both common and Rivet-specific).
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectNameOperations : IValuesMarker
    {
        public IProjectName Get_ClientProjectName(
            IProjectName projectName)
        {
            var clientProjectName = Instances.NameOperator.Append_Token(
                projectName,
                Instances.ProjectNameTokens.Client)
                .As_InternalProjectName();

            return clientProjectName;
        }

        public IProjectName Get_ServerProjectName(
            IProjectName projectName)
        {
            var clientProjectName = Instances.NameOperator.Append_Token(
                projectName,
                Instances.ProjectNameTokens.Server)
                .As_InternalProjectName();

            return clientProjectName;
        }
    }
}
