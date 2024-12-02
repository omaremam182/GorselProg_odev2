namespace Gorsel2;

public partial class Kredi_Hesaplama : ContentPage
{
	
	public Kredi_Hesaplama()
	{
		InitializeComponent();
	}

    private void vade_slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        vade_Entry.Text =Math.Round (vade_slider.Value).ToString();


    }

    private void vade_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (double.TryParse(vade_Entry.Text, out double result))
        {
            vade_slider.Value = Double.Parse(vade_Entry.Text.ToString());
            Hesapla();
        }
        else
            vade_slider.Value = 0;


     }
    public void Hesapla()
    {
        if (faiz_Entry.Text.ToString() !="" && faiz_Entry.Text.ToString()!=" " && tutar_Entry.Text.ToString() != "" && tutar_Entry.Text.ToString() != " " && vade_Entry.Text.ToString() != "") { 
        double KKDF = 0;
        double BSMV = 0;
        if (myPicker.SelectedIndex == 0)
        {
            KKDF = 0.15;
            BSMV = 0.1;
        }
        else if (myPicker.SelectedIndex == 2)
        {
            KKDF = 0.15;
            BSMV = 0.5;
        }
        else if (myPicker.SelectedIndex == 3)
            BSMV = 0.5;
       

            double oran = double.Parse(faiz_Entry.Text.ToString());
            double vade = double.Parse(vade_Entry.Text.ToString());
            double tutar = double.Parse(tutar_Entry.Text.ToString());

            double brutFaiz = ((oran + (oran * BSMV) + (oran * KKDF)) / 100);
            double aylikTaksit = ((Math.Pow(1 + brutFaiz, vade) * brutFaiz) / (Math.Pow(1 + brutFaiz, vade) - 1)) * tutar;
            double toplam = aylikTaksit * vade;

            aylik_Label.Text = "Aylýk Taksit : " + (Math.Round(aylikTaksit, 2)).ToString();
            aylik_Label.IsVisible = true;

            faiz_Label.Text = "Toplam faiz : " + Math.Round(toplam-tutar,2).ToString();
            faiz_Label.IsVisible = true;

            toplam_Label.Text = "Toplam Ödeme : " + (Math.Round(toplam, 2)).ToString();
            toplam_Label.IsVisible = true;

        }
    }

    private void myPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        Hesapla();
    }
}
