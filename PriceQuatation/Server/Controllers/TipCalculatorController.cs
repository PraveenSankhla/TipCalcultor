using TipCalculator.Shared;

namespace PriceQuatation.Server.Controllers
{
    public interface IPriceQuatation
    {
        Task<TipCalculatorModel> Calculate(TipCalculatorModel PQ);
    }

    public class TipCalculatorController : IPriceQuatation
    {
        public async Task<TipCalculatorModel> Calculate(TipCalculatorModel PQ)
        {
            TipCalculatorModel PQDATA = new();
            try
            {
                PQDATA.DiscountPercent_15 = (PQDATA.Costofmeal * 15) / 100;
                PQDATA.DiscountPercent_20 = (PQDATA.Costofmeal * 20) / 100;
                PQDATA.DiscountPercent_25 = (PQDATA.Costofmeal * 25) / 100;
                return PQDATA;
            }
            catch (Exception)
            {
                PQDATA = new TipCalculatorModel();
            }
            return PQDATA;
        }
    }
}
