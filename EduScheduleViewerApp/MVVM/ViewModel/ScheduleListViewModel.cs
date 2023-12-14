using EduScheduleViewerApp.Core;
using EduScheduleViewerApp.MVVM.Model;
using System.Collections.ObjectModel;

namespace EduScheduleViewerApp.MVVM.ViewModel
{
    class ScheduleListViewModel
    {
        public ObservableCollection<ScheduleRow> Schedule { get; set; }

        public ScheduleListViewModel()
        {
            Schedule = new ObservableCollection<ScheduleRow>();

            Schedule.Add(new ScheduleRow("Урок 1", "8:00", "8:45"));
            Schedule.Add(new ScheduleRow("Урок 1", "8:00", "8:45"));
            Schedule.Add(new ScheduleRow("Урок 1", "8:00", "8:45"));
            Schedule.Add(new ScheduleRow("Урок 1", "8:00", "8:45"));
            Schedule.Add(new ScheduleRow("Урок 1", "8:00", "8:45"));
            Schedule.Add(new ScheduleRow("Урок 1", "8:00", "8:45"));
            Schedule.Add(new ScheduleRow("Урок 1", "8:00", "8:45"));
            Schedule.Add(new ScheduleRow("Урок 1", "8:00", "8:45"));
        }
    }
}
