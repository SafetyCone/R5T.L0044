using System;


namespace R5T.L0044.Z001
{
    public class ProjectNameTokens : IProjectNameTokens
    {
        #region Infrastructure

        public static IProjectNameTokens Instance { get; } = new ProjectNameTokens();


        private ProjectNameTokens()
        {
        }

        #endregion
    }
}
