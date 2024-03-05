namespace Aula04;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent(); 
    }

    private  void LearnMore_Clicked(object sender, EventArgs e)
    {
        Launcher.Default.OpenAsync("https://Google.com");
    }
}