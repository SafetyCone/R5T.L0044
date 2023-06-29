using System;

using R5T.T0131;

using R5T.L0044.X000;

using IExternalProjectName = R5T.T0187.IProjectName;


namespace R5T.L0044.O001
{
    /// <summary>
    /// All project name operations (both common and Rivet-specific).
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectNameOperations : IValuesMarker
    {
        private static Internal.IProjectNameOperations Internal => O001.Internal.ProjectNameOperations.Instance;


        public IExternalProjectName Adjust_ProjectNameForPrivacy(
            IExternalProjectName projectName,
            bool isPrivate)
        {
            var internalProjectName = projectName.As_InternalProjectName();

            var adjustedProjectName = Instances.NameOperations.Adjust_ForPrivacy(
                internalProjectName,
                isPrivate)
                .As_ExternalProjectName();

            return adjustedProjectName;
        }

        public IExternalProjectName Get_ClientProjectName(
            IExternalProjectName projectName)
        {
            var internalProjectName = projectName.As_InternalProjectName();

            var clientProjectName = Internal.Get_ClientProjectName(internalProjectName)
                .As_ExternalProjectName();

            return clientProjectName;
        }

        public IExternalProjectName Get_ConstructionClientProjectName(
            IExternalProjectName projectName)
        {
            var internalProjectName = projectName.As_InternalProjectName();

            var constructionProjectName = Instances.NameGenerationOperations.Get_ConstructionName(internalProjectName)
                .As_InternalProjectName();

            var constructionClientProjectName = Internal.Get_ClientProjectName(constructionProjectName);

            var output = constructionClientProjectName.As_ExternalProjectName();
            return output;
        }

        public IExternalProjectName Get_ConstructionServerProjectName(
            IExternalProjectName projectName)
        {
            var internalProjectName = projectName.As_InternalProjectName();

            var constructionProjectName = Instances.NameGenerationOperations.Get_ConstructionName(internalProjectName)
                .As_InternalProjectName();

            var constructionServerProjectName = Internal.Get_ServerProjectName(constructionProjectName);

            var output = constructionServerProjectName.As_ExternalProjectName();
            return output;
        }

        public IExternalProjectName Get_ConstructionProjectName(
            IExternalProjectName projectName)
        {
            var internalProjectName = projectName.As_InternalProjectName();

            var constructionProjectName = Instances.NameGenerationOperations.Get_ConstructionName(
                internalProjectName)
                .As_ExternalProjectName();

            return constructionProjectName;
        }

        public IExternalProjectName Get_ServerProjectName(
            IExternalProjectName projectName)
        {
            var internalProjectName = projectName.As_InternalProjectName();

            var serverProjectName = Internal.Get_ServerProjectName(internalProjectName)
                .As_ExternalProjectName();

            return serverProjectName;
        }
    }
}
