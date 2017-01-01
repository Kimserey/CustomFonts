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
				Title = "Custom Fonts sample",
				Content = new StackLayout
				{
					HorizontalOptions = LayoutOptions.CenterAndExpand,
					Children = {
						new Label { Text = "Hello world" },
						new WrapLayout {
							Children = {
								new IconLabel { Text = FontAwesome.FileO.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.SmileO.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.Taxi.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.Whatsapp.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.FileO.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.SmileO.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.Taxi.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.Whatsapp.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.FileO.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.SmileO.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.Taxi.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.Whatsapp.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.FileO.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.SmileO.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.Taxi.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.Whatsapp.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.FileO.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.SmileO.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.Taxi.ToString(), WidthRequest = 30, HeightRequest = 30 },
								new IconLabel { Text = FontAwesome.Whatsapp.ToString(), WidthRequest = 30, HeightRequest = 30 }
							}
						}
					}
				}
			};

			MainPage = new NavigationPage(content);
		}
	}
}
