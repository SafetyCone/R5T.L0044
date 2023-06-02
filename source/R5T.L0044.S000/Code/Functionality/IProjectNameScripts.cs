using System;

using R5T.T0132;


namespace R5T.L0044.S000
{
    [FunctionalityMarker]
    public partial interface IProjectNameScripts : IFunctionalityMarker
    {
        public void Adjust_ProjectNameForPrivacy()
        {
            /// Inputs.
            var projectName = Instances.Values.Sample_ProjectName;
            bool isPrivate =
                false
                //true
                ;


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
