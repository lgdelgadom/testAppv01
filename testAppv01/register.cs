using System;
using Xamarin.Forms;

namespace WorkingWithNavigation
{
	public class Register : ContentPage
	{
		public Register ()
		{
			Label Registrate = new Label {
				Text = "Regístrate",
				TextColor = Color.Black,
				FontAttributes = FontAttributes.Bold
			};

			Label IngresaDat = new Label {
				Text = "Ingresa los datos requeridos",
				FontAttributes= FontAttributes.Bold,

			};

			Button FacebookAcc = new Button {
				Text = "Facebook",
				TextColor = Color.White,
				BackgroundColor = Color.FromRgb(37,73,149),
				WidthRequest = 290
			};

			Button GoogleAcc = new Button {
				Text = "Google",
				TextColor = Color.White,
				BackgroundColor = Color.FromRgb(220,40,28),
				WidthRequest = 290,
				 
			};

			TableView RegisterForm = new TableView {
				Intent = TableIntent.Form,
				Root = new TableRoot{
					new TableSection {
						new EntryCell{
							Placeholder = "Nombre",
							Keyboard=Keyboard.Default
						},

						new EntryCell{
							Placeholder = "Apellido",
							Keyboard = Keyboard.Default
						},

						new EntryCell{
							Placeholder = "Celular",
							Keyboard = Keyboard.Telephone
						},

						new EntryCell{
							Placeholder = "Correo",
							Keyboard = Keyboard.Email
						}
					}
				}
			};

			Button Registrar = new Button {
				Text = "Registrar",
				WidthRequest = 290,
				BackgroundColor = Color.FromRgb(210,34,70),
				TextColor = Color.White
			};


			RelativeLayout relLayout2 = new RelativeLayout();

			relLayout2.Children.Add ((Registrate), 
				Constraint.RelativeToParent ((parent) => {
					return parent.Width/2 - Registrate.Width/2;
				}),
				Constraint.RelativeToParent((parent) => {
					return 10;
				}));

			relLayout2.Children.Add ((FacebookAcc), 
				Constraint.RelativeToParent ((parent) => {
					return parent.Width/2 - FacebookAcc.Width/2;
				}),
				Constraint.RelativeToParent((parent) => {
					return parent.Height/7;
				}));

			relLayout2.Children.Add ((GoogleAcc),
				Constraint.RelativeToParent ((parent) => {
					return parent.Width / 2 - GoogleAcc.Width / 2;
				}),
				Constraint.RelativeToParent ((parent) => {
					return parent.Height / 7 + FacebookAcc.Height + 10;
				}));

			relLayout2.Children.Add ((IngresaDat),
				Constraint.RelativeToParent ((parent) => {
					return FacebookAcc.X;
				}),
				Constraint.RelativeToParent ((parent) => {
					return GoogleAcc.Y + 80;
				}));

			relLayout2.Children.Add ((Nombre),
				Constraint.RelativeToParent ((parent) => {
					return parent.Width / 2 - Nombre.Width / 2;
				}),
				Constraint.RelativeToParent ((parent) => {
					return IngresaDat.Y + 50;
				}));

			relLayout2.Children.Add ((Apellido),
				Constraint.RelativeToParent ((parent) => {
					return parent.Width / 2 - Apellido.Width / 2;
				}),
				Constraint.RelativeToParent ((parent) => {
					return Nombre.Y + 40;
				}));

			relLayout2.Children.Add ((Celular),
				Constraint.RelativeToParent ((parent) => {
					return parent.Width / 2 - Celular.Width / 2;
				}),
				Constraint.RelativeToParent ((parent) => {
					return Apellido.Y + 40;
				}));

			relLayout2.Children.Add ((Correo),
				Constraint.RelativeToParent ((parent) => {
					return parent.Width / 2 - Correo.Width / 2;
				}),
				Constraint.RelativeToParent ((parent) => {
					return Celular.Y + 40;
				}));

			relLayout2.Children.Add ((Registrar),
				Constraint.RelativeToParent ((parent) => {
					return parent.Width / 2 - Registrar.Width / 2;
				}),
				Constraint.RelativeToParent ((parent) => {
					return Correo.Y + 60;
				}));


			//para que se centre en el relativelayout (tomando en cuenta el width del label,etc)
			Registrate.SizeChanged += ((sender, eventArgs) =>
				{
					relLayout2.ForceLayout();
				});

			Content = relLayout2;
			Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);

		}

	}
}

