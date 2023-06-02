using System;


namespace R5T.L0044.T000.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToProjectName(string)"/>
        public static IProjectName ToProjectName(this string value)
        {
            return Instances.StringOperator_Extensions.ToProjectName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToProjectNamePart(string)"/>
        public static IProjectNamePart ToProjectNamePart(this string value)
        {
            return Instances.StringOperator_Extensions.ToProjectNamePart(value);
        }

        /// <inheritdoc cref="IStringOperator.ToProjectNameToken(string)"/>
        public static IProjectNameToken ToProjectNameToken(this string value)
        {
            return Instances.StringOperator_Extensions.ToProjectNameToken(value);
        }

        /// <inheritdoc cref="IStringOperator.ToProjectNameTokenSeparator(string)"/>
        public static IProjectNameTokenSeparator ToProjectNameTokenSeparator(this string value)
        {
            return Instances.StringOperator_Extensions.ToProjectNameTokenSeparator(value);
        }

        /// <inheritdoc cref="IStringOperator.ToUnadjustedProjectName(string)"/>
        public static IUnadjustedProjectName ToUnadjustedProjectName(this string value)
        {
            return Instances.StringOperator_Extensions.ToUnadjustedProjectName(value);
        }
    }
}
