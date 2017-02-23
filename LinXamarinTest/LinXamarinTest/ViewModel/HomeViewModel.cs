using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;
using System;
using LinXamarinTest.Model;
using LinXamarinTest.Models;

namespace LinXamarinTest.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class HomeViewModel : ViewModelBase
    {
        //private RelayCommand _navCommand;
        //private readonly INavigationService _navService;
        private string _searchTxt;

        public string SearchTxt {
            get
            {
                return _searchTxt;
            }
            set
            {
                if (Set(() => SearchTxt, ref _searchTxt, value))
                {

                    RaisePropertyChanged(() => All);
                }
            }
        }

        public const string ClickCountPropertyName = "ClickCount";

        private async void GetAllCountries()
        {
            _all = await App.TodoManager.GetTasksAsync();
            RaisePropertyChanged(() => All);
        }

        private List<CountryModel> _all;

        public List<CountryModel> All {
            get
            {
                var rs = new List<CountryModel>();

                if(_all != null && _all.Any())
                    rs = string.IsNullOrEmpty(_searchTxt) ? _all : _all.Where(x => x.name.IndexOf(_searchTxt, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                return rs;
            }
            set {
            }
        }


        /// <summary>
        /// Initializes a new instance of the HomeViewModel class.
        /// </summary>
        public HomeViewModel()//INavigationService navService)
        {
            GetAllCountries();

            //this._navService = navService;
            //_welcomeTitle = "Welcome to Lin Xamarin Test";
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }
        
        //private string _welcomeTitle;

        //public string WelcomeTitle {
        //    get {
        //        return _welcomeTitle;
        //    }
        //    set {
        //        Set(ref _welcomeTitle, value);
        //    }
        //}

        //private int _clickCount =1;

        //public int ClickCount {
        //    get
        //    {
        //        return _clickCount;
        //    }
        //    set
        //    {
        //        if (Set(() => ClickCount, ref _clickCount, value))
        //            RaisePropertyChanged(() => ClickCountFormated);

        //        //_clickCount = value;
        //        //RaisePropertyChanged("ClickCount");
        //    }
        //}

        //public string ClickCountFormated
        //{
        //    get
        //    {
        //        return string.Format("Clicked {0} time(s)", ClickCount);
        //    }
        //}

        //public RelayCommand NavCommand {
        //    get {
        //        return _navCommand ?? (_navCommand = new RelayCommand(
        //            ()=>_navService.NavigateTo(ViewModelLocator.AboutPageKey)
        //            ));
        //    }
        //}

        //private ICommand _incrementCommand;

        //public ICommand IncrementCommand
        //{
        //    get
        //    {
        //        return _incrementCommand ?? (_incrementCommand = 
        //            new RelayCommand(() => {
        //                ClickCount++;
        //            }));
        //    }
        //}

    }
}