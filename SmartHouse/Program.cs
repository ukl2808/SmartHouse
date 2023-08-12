var smartHomeSystem = new SmartHomeSystem();

var livingRoomMotionSensor = new MotionSensor("Living Room");
var bedroomMotionSensor = new MotionSensor("Bedroom");

smartHomeSystem.RegisterMotionSensor(livingRoomMotionSensor);
smartHomeSystem.RegisterMotionSensor(bedroomMotionSensor);

smartHomeSystem.StartMonitoring();
