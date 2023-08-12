public class MotionSensor : Device
{
    public event EventHandler<MotionDetectedEventArgs> MotionDetectedEvent;

    public MotionSensor(string name) : base(name)
    {
    }

    public void DetectMotion()
    {
        OnMotionDetected(new MotionDetectedEventArgs(Name, DateTime.Now));
    }

    protected virtual void OnMotionDetected(MotionDetectedEventArgs e)
    {
        MotionDetectedEvent?.Invoke(this, e);
    }
}