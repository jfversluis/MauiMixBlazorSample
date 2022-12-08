namespace MauiMixBlazorSample.MauiPages;

public partial class MauiPopupPage
{
	public MauiPopupPage()
	{
		InitializeComponent();
	}

    private void scanner_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        scanner.IsDetecting = false;

        Close(e.Results[0].Value);
    }
}