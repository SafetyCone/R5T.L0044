using System;


namespace R5T.L0044.Q000
{
    public static class Instances
    {
        public static S000.Library.IOperations Operations => S000.Library.Operations.Instance;
        public static O001.IProjectNameOperations ProjectNameOperations => O001.ProjectNameOperations.Instance;
        public static Z0046.IValues Values => Z0046.Values.Instance;
    }
}