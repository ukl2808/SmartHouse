public class SmartHomeSystem
{
    private List<MotionSensor> motionSensors = new List<MotionSensor>();

    public void RegisterMotionSensor(MotionSensor motionSensor)
    {
        motionSensors.Add(motionSensor);
    }

    public void HandleMotionDetected(object sender, MotionDetectedEventArgs e)
    {
        Console.WriteLine($"Motion detected at {e.Location} on {e.Time}");

        Console.WriteLine("Turning on the lights!");

        if (e.Location == "Bedroom")
        {
            Console.WriteLine("Playing soothing music in the Bedroom.");
        }
    }

    public void StartMonitoring()
    {
        foreach (var motionSensor in motionSensors)
        {
            motionSensor.MotionDetectedEvent += HandleMotionDetected;
        }

        foreach (var motionSensor in motionSensors)
        {
            motionSensor.DetectMotion();
        }
    }
}