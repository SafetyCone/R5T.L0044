using System;

using R5T.T0141;


namespace R5T.L0044.Q000
{
    [DemonstrationsMarker]
    public partial interface IProjectNameDemonstrations : IDemonstrationsMarker
    {
        public void Adjust_ProjectNameForPrivacy()
        {
            /// Inputs.
            var projectName = Instances.Values.Sample_ProjectName;
            bool isPrivate = true;


            /// Run.
            var adjustedProjectName = Instances.ProjectNameOperations.Adjust_ProjectNameForPrivacy(
                projectName,
                isPrivate);

            Instances.Operations.Write_Adjust_ProjectNameForPrivacy_ToConsole(
                projectName,
                isPrivate,
                adjustedProjectName);
        }

        public void Get_ConstructionProjectName()
        {
            /// Inputs.
            var projectName = Instances.Values.Sample_ProjectName;


            /// Run.
            var constructionProjectName = Instances.ProjectNameOperations.Get_ConstructionProjectName(
                projectName);

            Instances.Operations.Write_Get_ConstructionProjectName_ToConsole(
                projectName,
                constructionProjectName);
        }
    }
}
