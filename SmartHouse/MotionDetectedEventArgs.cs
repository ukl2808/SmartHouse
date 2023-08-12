public class MotionDetectedEventArgs : EventArgs
{
    public string Location { get; }
    public DateTime Time { get; }

    public MotionDetectedEventArgs(string location, DateTime time)
    {
        Location = location;
        Time = time;
    }
}
