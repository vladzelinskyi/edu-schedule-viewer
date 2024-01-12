using EduScheduleViewerApp.Core;
using EduScheduleViewerApp.MVVM.ViewModel.SettingsPagesViewModel;

namespace EduScheduleViewerApp.MVVM.ViewModel
{
    class SettingsViewModel : ObservableObject
    {
        public ScheduleSettingsViewModel ScheduleSettingsVM { get; set; }

        private object _currentSettingsTab;

        public object CurrentSettingsTab
        {
            get { return _currentSettingsTab; }
            set
            {
                _currentSettingsTab = value;
                OnPropertyChanged();
            }
        }

        public SettingsViewModel()
        {
            ScheduleSettingsVM = new ScheduleSettingsViewModel();
            CurrentSettingsTab = ScheduleSettingsVM;
        }
    }
}
