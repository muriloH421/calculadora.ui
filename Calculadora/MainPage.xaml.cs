namespace Calculadora
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void btnResult_Clicked(object sender, EventArgs e)
		{
			DisplayAlert("Hello World!", "Nun", "OK");
		}
	}

}
