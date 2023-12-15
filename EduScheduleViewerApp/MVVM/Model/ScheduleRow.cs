namespace EduScheduleViewerApp.MVVM.Model
{
    public class ScheduleRow
    {
        public string Title { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public bool IsActive { get; set; } = false;

        public ScheduleRow( string title, string startTime, string endTime)
        {
            Title = title;
            StartTime = startTime;
            EndTime = endTime;
        }
        public ScheduleRow(string title, string startTime, string endTime, bool isActive)
        {
            Title = title;
            StartTime = startTime;
            EndTime = endTime;
            IsActive = isActive;
        }
    }
}
