using System;

using R5T.T0132;

using R5T.L0043.T000;
using R5T.L0044.T000;
using R5T.L0044.T000.Extensions;

using IExternalProjectName = R5T.T0187.IProjectName;


namespace R5T.L0044.X000
{
    [FunctionalityMarker]
    public partial interface IProjectNameTypeConverter : IFunctionalityMarker
    {
        public IExternalProjectName As_ExternalProjectName(IProjectName projectName)
        {
            var output = Instances.StringOperator_External.ToProjectName(
                projectName.Value);

            return output;
        }

        public IExternalProjectName As_ExternalProjectName(IName name)
        {
            var output = Instances.StringOperator_External.ToProjectName(
                name.Value);

            return output;
        }

        public IProjectName As_InternalProjectName(IExternalProjectName externalProjectName)
        {
            var output = externalProjectName.Value.ToProjectName();
            return output;
        }
    }
}
