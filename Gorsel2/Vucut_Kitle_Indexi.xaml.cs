namespace Gorsel2;

public partial class Vucut_Kitle_Indexi : ContentPage
{
	public Vucut_Kitle_Indexi()
	{
		InitializeComponent();
	}

    private void kiloEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        string v = kilo_Entry.Text.ToString();
        if (v!="" && v!=" ")
        kilo_Slider.Value = Double.Parse(v);
            vkiHesapla();
    }

    private void boyEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        string v = boy_Entry.Text.ToString();
        if (v != "" && v != " ") { 
            boy_Slider.Value = Double.Parse(boy_Entry.Text.ToString());

        vkiHesapla();
    }
    }
    private void vkiHesapla() { 
        double boy  = boy_Slider.Value /100;
        double kilo = kilo_Slider.Value;
        double vki  = kilo / (boy*boy);
        String d = "";
        vki_Label.Text = "VKI :  "+ vki;
        vki_Label.IsVisible =true;

        if (vki < 16)
            d = " Ileri düzeyde Zayýf";
        else if (vki >= 16 && vki < 17)
            d = "Orta Düzeyde Zayýf";
        else if (vki >= 17 && vki < 18.5)
            d = "Hafif Düzeyde Zayýf";
        else if (vki >= 18.5 && vki < 25)
            d = "Normal";
        else if (vki >= 25 && vki < 30)
            d = "Hafif Þiþman";
        else if (vki >= 30 && vki < 35)
            d = "1. Dereceden Obez";
        else if (vki >= 35 && vki < 40)
            d = "2. Dereceden Obez";
        else if (vki >= 40)
            d = "Morbiz Obez";
        durum_Label.Text = d;
        durum_Label.IsVisible = true;

    }
   

   

    private void kilo_Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    { 
        kilo_Entry.Text = kilo_Slider.Value.ToString(); 
    }

    private void boy_Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        boy_Entry.Text = boy_Slider.Value.ToString();
    }
}