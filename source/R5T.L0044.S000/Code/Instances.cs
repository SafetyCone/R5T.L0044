using System;


namespace R5T.L0044.S000
{
    public static class Instances
    {
        public static Library.IOperations Operations => Library.Operations.Instance;
        public static O001.IProjectNameOperations ProjectNameOperations => O001.ProjectNameOperations.Instance;
        public static Z0046.IValues Values => Z0046.Values.Instance;
    }
}