namespace MauiMixBlazorSample.MauiPages;

public partial class MauiPage : ContentPage
{
	public MauiPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }
}