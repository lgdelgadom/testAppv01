using System;
using Xamarin.Forms;

namespace WorkingWithNavigation
{
	public class welcome : ContentPage
	{
		public welcome ()
		{
			Label header = new Label {
				Text = "Xylo",
				FontSize = 70,
				FontAttributes= FontAttributes.Bold,
				FontFamily="Avenir"
			};

			Button IniciarSes = new Button {
				Text = "Iniciar Sesión",
				TextColor = Color.White,
				BackgroundColor = Color.FromRgb(255,135,20),
				WidthRequest = 275
			};

			Button Registrate = new Button {
				Text = "Regístrate",
				TextColor = Color.White,
				BackgroundColor = Color.FromRgb (245, 104, 78),
				WidthRequest = 275,

			};

			RelativeLayout relLayout1 = new RelativeLayout();

			relLayout1.Children.Add(header,
				Constraint.RelativeToParent((parent) => {
					return (parent.Width / 2) - (header.Width/2.0);
				}),
				Constraint.RelativeToParent ((parent) => {
					return parent.Height/3 + 20;
				}));

			relLayout1.Children.Add (Registrate,
				Constraint.RelativeToParent ((parent) => {
					return (parent.Width / 2) - (Registrate.Width/2.0);
				}),
				Constraint.RelativeToParent((parent)=> {
					return parent.Height*0.75 - IniciarSes.Height - 10;
				}));

			relLayout1.Children.Add (IniciarSes,
				Constraint.RelativeToParent ((parent) => {
					return (parent.Width / 2) - (IniciarSes.Width/2.0);
				}),
				Constraint.RelativeToParent((parent)=> {
					return parent.Height*0.75;
				}));

			//para que se centre en el relativelayout (tomando en cuenta el width del label,etc)
			header.SizeChanged += ((sender, eventArgs) =>
				{
					relLayout1.ForceLayout();
				});

			Registrate.Clicked += OnNextPageButtonClicked;

			Content = new StackLayout { 
				Children = {
					relLayout1
				}
			};
		}

		async void OnNextPageButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new Register ());
		}
	}
}
