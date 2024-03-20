using ReliabilityOptimizationCalc.BLL.Calculators;

namespace ReliabilityOptimizationCalc.BLL.Models;

public class NodeModel
{
    public int Id { get; }
    
    //backup
    public decimal TimeToLiveExtra { get; }
    
    //original
    public decimal TimeToLive { get; }
    
    public decimal Cost { get; }

    public NodeModel(int id, decimal timeToLive, decimal timeToLiveExtra, decimal cost)
    {
        Id = id;
        
        Cost = cost;
        
        TimeToLive = timeToLive;
        TimeToLiveExtra = timeToLiveExtra; //NodeTimeToLiveCalculator.GetTtl(TimeToLiveConf);
    }
}