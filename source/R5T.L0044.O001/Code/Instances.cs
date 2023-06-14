using System;


namespace R5T.L0044.O001
{
    public static class Instances
    {
        public static L0043.O002.INameGenerationOperations NameGenerationOperations => L0043.O002.NameGenerationOperations.Instance;
        public static L0043.O001.INameOperations NameOperations => L0043.O001.NameOperations.Instance;
        public static L0043.F000.INameOperator NameOperator => L0043.F000.NameOperator.Instance;
        public static Z001.IProjectNameTokens ProjectNameTokens => Z001.ProjectNameTokens.Instance;
    }
}