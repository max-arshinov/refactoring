using System.ComponentModel.DataAnnotations;

namespace Calculators
{
    public enum MathOperation: byte
    {
        [Display(Name = "+")]
        Plus = 0,

        [Display(Name = "-")]
        Minus,
        Divide
    }
}