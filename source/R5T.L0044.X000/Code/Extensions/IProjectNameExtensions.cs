using System;

using R5T.L0043.T000;
using R5T.L0044.T000;

using IExternalProjectName = R5T.T0187.IProjectName;


namespace R5T.L0044.X000
{
    public static class IProjectNameExtensions
    {
        public static IExternalProjectName As_ExternalProjectName(this IProjectName projectName)
        {
            return Instances.ProjectNameTypeConverter.As_ExternalProjectName(projectName);
        }

        public static IExternalProjectName As_ExternalProjectName(this IName name)
        {
            return Instances.ProjectNameTypeConverter.As_ExternalProjectName(name);
        }

        public static IProjectName As_InternalProjectName(this IExternalProjectName externalProjectName)
        {
            return Instances.ProjectNameTypeConverter.As_InternalProjectName(externalProjectName);
        }
    }
}
