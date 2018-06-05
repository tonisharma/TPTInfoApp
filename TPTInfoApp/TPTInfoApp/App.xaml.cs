using System;

using TPTInfoApp.Views;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace TPTInfoApp
{
	public partial class App : Application
	{

		public App ()
		{
			InitializeComponent();


            MainPage = new MainPage();
        }

		protected override void OnStart ()
		{
            AppCenter.Start("android=d54e8bc1-b128-4411-b66a-579202773998;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
