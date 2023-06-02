using System;


namespace R5T.L0044.X000
{
    public class ProjectNameTypeConverter : IProjectNameTypeConverter
    {
        #region Infrastructure

        public static IProjectNameTypeConverter Instance { get; } = new ProjectNameTypeConverter();


        private ProjectNameTypeConverter()
        {
        }

        #endregion
    }
}
