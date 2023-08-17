namespace TicketCenter;

public partial class NewTicketPage : ContentPage
{
	public NewTicketPage()
	{
		InitializeComponent();
        Type.SelectedIndex = 0;
        Category.SelectedIndex = 0;
        Priority.SelectedIndex = 0;
        Owner.SelectedIndex = 0;
        Assigned.SelectedIndex = 0;
    }

    private async void SelectFileButton_Clicked(object sender, EventArgs e)
    {
        var fileResult = await FilePicker.PickAsync(new PickOptions
        {
            FileTypes = FilePickerFileType.Images,
            PickerTitle = "Selected file:"
        });

        if (fileResult != null)
        {
            selectedFileLabel.Text = $"Archivo Seleccionado: {fileResult.FileName}";
        }
    }
}