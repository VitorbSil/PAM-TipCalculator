using System.Diagnostics;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        double valor = 0;
        double valorTotal = 0;
        double valorDaGorjeta = 0;

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
            valorTotal = Math.Ceiling(valorTotal);
            valorDaGorjeta = Math.Ceiling(valorDaGorjeta);
            TipLabel.Text = valorDaGorjeta.ToString("C");
            TotalLabel.Text = valorTotal.ToString("C");
        }

        private void RoundDownButton_Clicked(System.Object sender, System.EventArgs e)
        {
            valorTotal = Math.Floor(valorTotal);
            valorDaGorjeta = Math.Floor(valorDaGorjeta);
            TipLabel.Text = valorDaGorjeta.ToString("C");
            TotalLabel.Text = valorTotal.ToString("C");
        }
        private void TipSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            TipPercentLabel.Text = TipSlider.Value.ToString("#.##") + "%";
            try
            {
                valor = Convert.ToDouble(AmountEntry.Text);
                valorDaGorjeta = valor * (TipSlider.Value / 100);
                valorTotal = valorDaGorjeta + valor;

                TotalLabel.Text = valorTotal.ToString("C");
                TipLabel.Text = valorDaGorjeta.ToString("C");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void AmountEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                valor = Convert.ToDouble(AmountEntry.Text);
                valorDaGorjeta = valor * (TipSlider.Value / 100);
                valorTotal = valorDaGorjeta + valor;

                TotalLabel.Text = valorTotal.ToString("C");
                TipLabel.Text = valorDaGorjeta.ToString("C");
            }
            catch(Exception ex)
            { 
                Debug.WriteLine(ex.ToString());
            }
        }  
    }
}