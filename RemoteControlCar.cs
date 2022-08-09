namespace Exercitando;

public class RemoteControlCar
{
    private int travelledDistance;
    private int remainingBattery;

    public RemoteControlCar(int travelledDistance = 0, int remainingBattery = 100)
    {
        this.travelledDistance = travelledDistance;
        this.remainingBattery = remainingBattery;
    }
    
    public static RemoteControlCar Buy() => new RemoteControlCar();
    
    public string DistanceDisplay() => $"Driven {this.travelledDistance.ToString()} meters";

    public string BatteryDisplay() => this.remainingBattery>0?$"Battery at {this.remainingBattery.ToString()}%" : "Battery empty";

    public void Drive()
    {
        if (this.remainingBattery > 0) 
        {
            this.travelledDistance += 20;
            this.remainingBattery -= 1;
        }
    } 
}