using System;

namespace CalcRefactoring
{
    public static class FuncExtensions
    {
        public static void EiterOr(this bool flag, Action success, Action error)
        {
            if (flag)
            {
                success();
            }
            else
            {
                error();
            }
        }
    }
}