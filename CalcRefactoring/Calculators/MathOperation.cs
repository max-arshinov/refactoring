using System.ComponentModel.DataAnnotations;

namespace CalcRefactoring
{
    public enum MathOperation: byte
    {
        [Display(Name = "+")]
        Plus = 0,

        [Display(Name = "-")]
        Minus
    }
}