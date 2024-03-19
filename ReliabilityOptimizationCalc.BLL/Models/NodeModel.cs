using ReliabilityOptimizationCalc.BLL.Calculators;

namespace ReliabilityOptimizationCalc.BLL.Models;

public class NodeModel
{
    private decimal TimeToLiveConf;
    public decimal TimeToLive { get; }
    
    public decimal Cost { get; }

    public NodeModel(decimal timeToLiveConf, decimal cost)
    {
        Cost = cost;
        
        TimeToLiveConf = timeToLiveConf;
        TimeToLive = NodeTimeToLiveCalculator.GetTtl(TimeToLiveConf);
    }
}