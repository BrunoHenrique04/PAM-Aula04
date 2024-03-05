
namespace Aula04;

public partial class NotePage : ContentPage
{

    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    //Método Constructor
    

	public NotePage()
	{
		InitializeComponent();

        if (File.Exists(_fileName))
        {
            TextEditor.Text = File.ReadAllText(_fileName);
            DisplayAlert("Arquivo Carregado", "O seu arquivo foi Carregado com sucesso!!", "CONTINUAR");
        }
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, TextEditor.Text);
        await DisplayAlert("Arquivo Gravado", "O seu arquivo foi gravado com sucesso!!", "CONTINUAR");

    }

    private async void DeleteButton_Clicked(Object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
        {
            File.Delete(_fileName);
            TextEditor.Text = string.Empty;
            await DisplayAlert("Arquivo Deletado", "O seu arquivo foi deletado com sucesso!!", "CONTINUAR");
        }

    }
}