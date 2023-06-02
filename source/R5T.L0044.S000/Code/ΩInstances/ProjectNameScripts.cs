using System;


namespace R5T.L0044.S000
{
    public class ProjectNameScripts : IProjectNameScripts
    {
        #region Infrastructure

        public static IProjectNameScripts Instance { get; } = new ProjectNameScripts();


        private ProjectNameScripts()
        {
        }

        #endregion
    }
}
