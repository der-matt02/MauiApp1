namespace MauiApp1;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();
	}
    private async void OnFlexLayoutPageButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexLayoutPage());
    }
}