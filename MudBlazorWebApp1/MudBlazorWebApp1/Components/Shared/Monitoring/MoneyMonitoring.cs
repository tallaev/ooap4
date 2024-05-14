using Microsoft.VisualBasic;
using MudBlazor;


namespace MudBlazorWebApp1.Components.Shared.Monitoring
{
    public class MoneyMonitoring
    {
        private Currency dollar = new("USD");
        private Currency euro = new("EURO");

        private Random _rnd = new Random();
        ISnackbar _snackbar;
        public MoneyMonitoring(ISnackbar snackbar)
        {
            _snackbar = snackbar;
        }

        public void StartMonitoring(List<ChartSeries> Series, List<string> Date)
        {
            euro.SetAmount((_rnd.Next(1500) / 10.0 + 100));
            dollar.SetAmount((_rnd.Next(1500) / 10.0 + 100));
            _snackbar.Add($"Взяли {euro.Amount} Евро; {dollar.Amount} долларов");

            double dollarValue = dollar.GetValueInRubles();
            double euroValue = euro.GetValueInRubles();
            string dateAsStr = dollar.GetDateTime().ToString("yyyy-MM-dd HH-mm");
            Date.Add(dateAsStr);

            Series[0].Data = Series[0].Data.Append(dollarValue).ToArray();
            Series[1].Data = Series[1].Data.Append(euroValue).ToArray();

        }
    }
}
