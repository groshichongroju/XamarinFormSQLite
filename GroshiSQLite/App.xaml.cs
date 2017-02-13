using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GroshiSQLite
{
	public partial class App : Application
	{
		//groshi
		static DataAccess dbUtils;
		//groshi
		public App()
		{
			InitializeComponent();

			//MainPage = new GroshiSQLitePage();
			MainPage = new NavigationPage(new GroshiSQLitePage());
		}
		//groshi
		public static DataAccess DAUtil
		{
			get
			{
				if (dbUtils == null)
				{
					dbUtils = new DataAccess();
				}
				return dbUtils;
			}
		}
		//groshi
		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}
		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
