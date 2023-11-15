namespace Contador_ManuelvF1;

public partial class MainPage : ContentPage
{
    private int Xconteo;
    private int AumentoDefinido;
    public MainPage()
	{
		InitializeComponent();
        Xconteo = 0;
        ConteoLabel.Text = Xconteo.ToString();
        AumentoDefinido = 1;
    }

    private void OnContarButtonClicked(object sender, EventArgs e)
    {
        Xconteo += AumentoDefinido;
        ConteoLabel.Text = Xconteo.ToString();
    }

    private void OnReiniciarButtonClicked(object sender, EventArgs e)
    {
        Xconteo = 0;
        ConteoLabel.Text = Xconteo.ToString();
    }

    private void OnPasoSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        AumentoDefinido = (int)e.NewValue;
    }
}

