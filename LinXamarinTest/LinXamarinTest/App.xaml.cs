using LinXamarinTest.Data;
using LinXamarinTest.View;
using LinXamarinTest.ViewModel;
using Xamarin.Forms;

namespace LinXamarinTest
{
    public partial class App : Application
	{
        public static TodoItemManager TodoManager { get; private set; }

        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }

		public App ()
		{
            InitializeComponent();

            //MainPage = new TabbedPage {
            //    Children = {
            //        new HomePage(),
            //        new About("Hello!")
            //    }
            //};
            TodoManager = new TodoItemManager(new TodoItemRestService());
			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
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
