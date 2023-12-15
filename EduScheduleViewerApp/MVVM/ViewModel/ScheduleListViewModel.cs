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

            Schedule.Add(new ScheduleRow("Урок 1", "08:00", "08:45"));
            Schedule.Add(new ScheduleRow("Урок 2", "08:55", "09:40"));
            Schedule.Add(new ScheduleRow("Урок 3", "09:50", "10:35"));
            Schedule.Add(new ScheduleRow("Урок 4", "10:45", "11:30", true));
            Schedule.Add(new ScheduleRow("Урок 5", "11:40", "12:25"));
            Schedule.Add(new ScheduleRow("Урок 6", "12:35", "12:20"));
            Schedule.Add(new ScheduleRow("Урок 7", "12:30", "13:15"));
            Schedule.Add(new ScheduleRow("Урок 8", "14:25", "15:10"));
        }
    }
}
