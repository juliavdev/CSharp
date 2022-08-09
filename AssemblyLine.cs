namespace Exercitando;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed < 1) {
            return 0.00;
        }
        if(speed >= 1 && speed < 5) {
            return 1.00;
        }
        if(speed < 9) {
            return 0.90;
        }
        if(speed < 10) {
            return 0.80;
        } else {
            return 0.77;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double sucessRate = AssemblyLine.SuccessRate(speed);

        return (221 * speed * sucessRate);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double productionRatePerHour = AssemblyLine.ProductionRatePerHour(speed);
        return (int)Math.Round(productionRatePerHour / 60, MidpointRounding.ToNegativeInfinity);
    }
}
