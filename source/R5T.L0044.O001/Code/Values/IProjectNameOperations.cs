using System;

using R5T.T0131;

using R5T.L0044.X000;

using IExternalProjectName = R5T.T0187.IProjectName;


namespace R5T.L0044.O001
{
    [ValuesMarker]
    public partial interface IProjectNameOperations : IValuesMarker
    {
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

        public IExternalProjectName Get_ConstructionProjectName(
            IExternalProjectName projectName)
        {
            var internalProjectName = projectName.As_InternalProjectName();

            var constructionProjectName = Instances.NameGenerationOperations.Get_ConstructionName(
                internalProjectName)
                .As_ExternalProjectName();

            return constructionProjectName;
        }
    }
}
