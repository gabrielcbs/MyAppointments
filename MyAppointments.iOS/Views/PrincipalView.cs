using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using MyAppointments.Core;
using UIKit;

namespace MyAppointments.iOS
{
	public partial class PrincipalView : MvxTabBarViewController<PrincipalViewModel>
	{
		int _tabsCreatedSoFar;

		public PrincipalView(IntPtr handle) : base (handle)
        {
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			CreateTabs();
		}

		public override void ItemSelected(UITabBar tabbar, UITabBarItem item)
		{
			Title = item.Title;
		}

		void CreateTabs()
		{
			var viewControllers = new UIViewController[]{
				//CreateTab("All Appointments", UITabBarSystemItem.Search, ViewModel.ListAppointmentsViewModel),
				//CreateTab("This Week", UITabBarSystemItem.MostRecent, ViewModel.ThisWeekAppointmentsViewModel)
			    CreateTab("All Appointments", "ic-search-", ViewModel.ListAppointmentsViewModel),
				CreateTab("This Week", "ic-calendar-", ViewModel.ThisWeekAppointmentsViewModel)
			};

			ViewControllers = viewControllers;

			SelectedViewController = viewControllers[0];
			Title = SelectedViewController.Title;

			NavigationItem.Title = SelectedViewController.Title;

			ViewControllerSelected += (o, e) =>
			{
				NavigationItem.Title = TabBar.SelectedItem.Title;
			};

		}

        UIViewController CreateTab
			(string title, string imageName, IMvxViewModel viewModel)
		{
			var viewController =
				this.CreateViewControllerFor(viewModel) as UIViewController;
			viewModel.Start();

			UpdateTabBar(viewController, title, imageName);

			return viewController;
		}

		UIViewController CreateTab(string title, UITabBarSystemItem iconType, IMvxViewModel viewModel)
		{
			var viewController = this.CreateViewControllerFor(viewModel) as UIViewController;
			viewModel.Start();

			UpdateTabBar(viewController, title, iconType);

			return viewController;
		}

        void UpdateTabBar(UIViewController viewController, string title, string imageName)
		{
			viewController.Title = title;

			viewController.TabBarItem = new UITabBarItem(
				title,
				UIImage.FromBundle(imageName + "normal.png").ImageWithRenderingMode(UIImageRenderingMode.Automatic),
				_tabsCreatedSoFar)
			{
				SelectedImage = UIImage.FromBundle(imageName + "active.png")
				                       .ImageWithRenderingMode(UIImageRenderingMode.Automatic)
			};

			_tabsCreatedSoFar++;
		}

		void UpdateTabBar(UIViewController viewController, string title, UITabBarSystemItem iconType)
		{
			viewController.Title = title;

			viewController.TabBarItem = new UITabBarItem(iconType, _tabsCreatedSoFar);

			viewController.TabBarItem.Title = title;

			_tabsCreatedSoFar++;
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
		}

		public override void ViewWillDisappear(bool animated)
		{
			base.ViewWillDisappear(animated);
		}

		public override void ViewDidDisappear(bool animated)
		{
			base.ViewDidDisappear(animated);
		}
	}
}