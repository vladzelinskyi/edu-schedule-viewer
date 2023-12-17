using EduScheduleViewerApp.Core;

namespace EduScheduleViewerApp.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ScheduleListViewModel ScheduleListVM { get; set; }
        public SettingsViewModel SettingsVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            ScheduleListVM = new ScheduleListViewModel();
            SettingsVM = new SettingsViewModel();


            CurrentView = SettingsVM;
        }

    }
}
