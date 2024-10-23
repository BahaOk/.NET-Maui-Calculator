namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private string secilenSayi = ""; // Şu anki sayıyı tutar
    private string ilkSayi = "";  // İlk sayıyı tutar
    private string islem = "";    // Seçilen işlemi tutar

    public MainPage()
    {
        InitializeComponent();
    }

    // Rakam butonlarına basıldığında çalışır
    private void OnNumberClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string sayi = button.Text;

        // Sayıyı birleştir
        secilenSayi += sayi;
        Label.Text = secilenSayi; // Label'a sayıyı göster
    }

    // İşlem butonlarına basıldığında çalışır
    private void OnOperationClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        islem = button.Text;

        ilkSayi = secilenSayi;  // İlk sayıyı kaydet
        secilenSayi = "";           // Yeni giriş için sıfırla
    }

    // Eşittir butonuna basıldığında çalışır
    private void OnEqualsClicked(object sender, EventArgs e)
    {
        double sayi1 = double.Parse(ilkSayi);
        double sayi2 = double.Parse(secilenSayi);
        double sonuc = 0;

        switch (islem)
        {
            case "+":
                sonuc = sayi1 + sayi2;
                break;
            case "-":
                sonuc = sayi1 - sayi2;
                break;
            case "*":
                sonuc = sayi1 * sayi2;
                break;
            case "/":
                if (sayi2 != 0)
                    sonuc = sayi1 / sayi2;
                else
                    Label.Text = "Error"; // Bölme hatası
                return;
        }

        // Sonucu ekranda göster
        Label.Text = sonuc.ToString();
        secilenSayi = sonuc.ToString(); // Sonucu yeni giriş olarak kaydet
    }

    // Clear butonuna basıldığında çalışır
    private void OnClearClicked(object sender, EventArgs e)
    {
        secilenSayi = "";
        ilkSayi = "";
        islem = "";
        Label.Text = "0";
    }
}
