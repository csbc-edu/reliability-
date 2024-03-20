using ReliabilityOptimizationCalc.BLL.Models;

namespace ReliabilityOptimizationCalc.BLL.Calculators;

public static class NodeTimeToLiveCalculator
{
    // public static decimal GetTtl(decimal timeToLiveConf)
    // {
    //     return timeToLiveConf * 100;
    // }

    public static decimal GetRes(MapModel map)
    {
        decimal maxRes = 0;
        map.Nodes.ForEach(x =>
        {
            
        });
        return maxRes;
    }
}