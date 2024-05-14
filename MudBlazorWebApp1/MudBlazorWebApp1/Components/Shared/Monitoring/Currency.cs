namespace MudBlazorWebApp1.Components.Shared.Monitoring
{
    public class Currency
    {
        private Random _rnd = new Random();
        private DateTime DateTime = DateTime.Now;
        public double Amount = 0;
        private string Name = string.Empty;

        public Currency(string name)
        {
            Name = name;
        }

        public double GetValueInRubles()
        {
            return Amount * 93;
        }

        public DateTime GetDateTime()
        {
            return DateTime;
        }

        public void SetAmount(double amount) { Amount = amount; }

    }
}
