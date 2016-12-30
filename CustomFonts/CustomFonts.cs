using System;
using Xamarin.Forms;

namespace CustomFonts
{
	public class FontAwesome
	{
		public static char FileO = '\xf016';
		public static char SmileO = '\xf118';
		public static char Taxi = '\xf1ba';
		public static char Whatsapp = '\xf232';
	}

	public class IconLabel : Label
	{
		public IconLabel()
		{
			Margin = 2;
		}
	}

	public class App : Application
	{
		public App()
		{
			var content = new ContentPage
			{
				Title = "Custom Fonts",
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Orientation = StackOrientation.Horizontal,
					Children = {
						new IconLabel { Text = FontAwesome.FileO.ToString() },
						new IconLabel { Text = FontAwesome.SmileO.ToString() },
						new IconLabel { Text = FontAwesome.Taxi.ToString() },
						new IconLabel { Text = FontAwesome.Whatsapp.ToString() }
					}
				}
			};

			MainPage = new NavigationPage(content);
		}
	}
}
