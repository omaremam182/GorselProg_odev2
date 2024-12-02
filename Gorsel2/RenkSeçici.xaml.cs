namespace Gorsel2;

public partial class RenkSeçici : ContentPage
{
	public RenkSeçici()
	{
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        int red = (int)(ki_Slider.Value * 255);
        int green = (int)(ye_Slider.Value * 255);
        int blue = (int)(ma_Slider.Value * 255);

        string hexColor = $"#{red:X2}{green:X2}{blue:X2}";
        re_Label.Text = hexColor;
        re_Layout.BackgroundColor = Color.FromArgb(hexColor);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Random r = new Random();
        ki_Slider.Value = r.NextDouble();
        ma_Slider.Value = r.NextDouble();
        ye_Slider.Value = r.NextDouble();

    }
}