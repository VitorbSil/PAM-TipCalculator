namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void SetLowTip_Clicked(System.Object sender, System.EventArgs e)
        {
            TipSlider.Value = 15;
            TipPercentLabel.Text = TipSlider.Value.ToString() + "%";
        }

        private void SetHighTip_Clicked(System.Object sender, System.EventArgs e)
        {
            TipSlider.Value = 20;
            TipPercentLabel.Text = TipSlider.Value.ToString() + "%";
        }

        private void RoundUpButton_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void RoundDownButton_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void TipSlider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
        {
            TipPercentLabel.Text = TipSlider.Value.ToString("#") + "%";
        }

        private void AmountEntry_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
        {
            double Valor = Convert.ToDouble(AmountEntry.Text);
            double ValorDaGorjeta = Valor * (TipSlider.Value / 100);
            double ValorTotal = ValorDaGorjeta + Valor;

            TotalLabel.Text = ValorTotal.ToString("C");
            TipLabel.Text = ValorDaGorjeta.ToString("C");
        }
    }
}