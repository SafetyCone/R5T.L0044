using System;

using R5T.T0131;
using R5T.T0187;


namespace R5T.L0044.S000.Library
{
    [ValuesMarker]
    public partial interface IOperations : IValuesMarker
    {
        public string Get_Adjust_ProjectNameForPrivacy_Message(
            IProjectName projectName,
            bool isPrivate,
            IProjectName adjustedProjectName)
        {
            var output = $"{adjustedProjectName}: adjusted project name for '{projectName}', is private: {isPrivate}.";
            return output;
        }

        public string Get_ConstructionProjectName_Message(
            IProjectName projectName,
            IProjectName constructionProjectName)
        {
            var output = $"{constructionProjectName}: construction project name for '{projectName}'.";
            return output;
        }

        public void Write_Adjust_ProjectNameForPrivacy_ToConsole(
            IProjectName projectName,
            bool isPrivate,
            IProjectName adjustedProjectName)
        {
            var message = this.Get_Adjust_ProjectNameForPrivacy_Message(
                projectName,
                isPrivate,
                adjustedProjectName);

            Console.WriteLine(message);
        }

        public void Write_Get_ConstructionProjectName_ToConsole(
            IProjectName projectName,
            IProjectName constructionProjectName)
        {
            var message = this.Get_ConstructionProjectName_Message(
                projectName,
                constructionProjectName);

            Console.WriteLine(message);
        }
    }
}
