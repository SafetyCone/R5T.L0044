using System;

using R5T.T0132;


namespace R5T.L0044.T000.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IProjectName"/>
        public IProjectName ToProjectName(string value)
        {
            var output = new ProjectName(value);
            return output;
        }

        /// <inheritdoc cref="IProjectNamePart"/>
        public IProjectNamePart ToProjectNamePart(string value)
        {
            var output = new ProjectNamePart(value);
            return output;
        }

        /// <inheritdoc cref="IProjectNameToken"/>
        public IProjectNameToken ToProjectNameToken(string value)
        {
            var output = new ProjectNameToken(value);
            return output;
        }

        /// <inheritdoc cref="IProjectNameTokenSeparator"/>
        public IProjectNameTokenSeparator ToProjectNameTokenSeparator(string value)
        {
            var output = new ProjectNameTokenSeparator(value);
            return output;
        }

        /// <inheritdoc cref="IUnadjustedProjectName"/>
        public IUnadjustedProjectName ToUnadjustedProjectName(string value)
        {
            var output = new UnadjustedProjectName(value);
            return output;
        }
    }
}
