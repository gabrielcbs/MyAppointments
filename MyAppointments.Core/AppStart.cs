using MvvmCross.Core.ViewModels;

namespace MyAppointments.Core
{
	public class AppStart: MvxNavigatingObject, IMvxAppStart
	{
		public async void Start(object hint = null)
		{
			ShowViewModel<PrincipalViewModel>();
		}
	}
}
