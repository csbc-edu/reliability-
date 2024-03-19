namespace ReliabilityOptimizationCalc.BLL.Calculators;

public static class NodeTimeToLiveCalculator
{
    public static decimal GetTtl(decimal timeToLiveConf)
    {
        return timeToLiveConf * 100;
    }
}