using MvvmCross.Core.ViewModels;
using MvvmCross.Localization;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using MyAppointments.Core.Utility;
using MyAppointments.Localization;

namespace MyAppointments.Core
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			base.Initialize();

			CreatableTypes()
				.EndingWith("Repository")
				.AsInterfaces()
				.RegisterAsLazySingleton(); //Creates one instance and always returns that single instance

			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();

			Mvx.RegisterSingleton<IMvxTextProvider>
				(new ResxTextProvider(Strings.ResourceManager));

			RegisterAppStart(new AppStart());
		}
	}
}
