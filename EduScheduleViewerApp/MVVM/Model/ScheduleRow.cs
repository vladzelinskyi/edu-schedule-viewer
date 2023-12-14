namespace EduScheduleViewerApp.MVVM.Model
{
    class ScheduleRow
    {
        string Title { get; set; }
        string StartTime { get; set; }
        string EndTime { get; set; }

        public ScheduleRow( string title, string startTime, string endTime)
        {
            Title = title;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
