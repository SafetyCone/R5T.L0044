using System;


namespace R5T.L0044.O001.Internal
{
    public class ProjectNameOperations : IProjectNameOperations
    {
        #region Infrastructure

        public static IProjectNameOperations Instance { get; } = new ProjectNameOperations();


        private ProjectNameOperations()
        {
        }

        #endregion
    }
}
