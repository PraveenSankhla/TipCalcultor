using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Shared
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "Please Enter Cost of Meal")]
        [Range(1, int.MaxValue, ErrorMessage = "Meal cost must be greater than 1")]
        public Int32 Costofmeal { get; set; }

        public Double DiscountPercent_15 { get; set; }
        public Double DiscountPercent_20 { get; set; } = 0.00;
        public Double DiscountPercent_25 { get; set; } = 0.00;
    }
}
