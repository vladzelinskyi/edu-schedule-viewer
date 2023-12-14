namespace EduScheduleViewerApp.MVVM.Model
{
    public class ScheduleRow
    {
        public string Title { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public ScheduleRow( string title, string startTime, string endTime)
        {
            Title = title;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
