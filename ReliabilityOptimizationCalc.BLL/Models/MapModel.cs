namespace ReliabilityOptimizationCalc.BLL.Models;

public class MapModel
{
    public List<MapModel> Chains { get; set; } = new List<MapModel>();
    
    public List<NodeModel> Nodes { get; set; } = new List<NodeModel>();

    public NodeModel? MinReliabilityNode { get; private set; } = null;
    public decimal MinTimeToLive
    {
        get
        {
            var items = Nodes.ToList();
            
            decimal min = items.Select(x=>x.TimeToLive).Min();
            MinReliabilityNode = items.FirstOrDefault(x=>x.TimeToLive == min);
            
            for (var j = 0; j < items.Count; j++)
            {
                for (var xj = 0; xj < 1; xj++)
                {
                    var itemSum = items[j].TimeToLive + (items[j].TimeToLiveExtra * xj);
                    if (min > itemSum)
                    {
                        min = itemSum;
                        MinReliabilityNode = items[j];
                    }    
                }   
            }
            
            return min;
        }
    }
    
    public decimal MapMinTimeToLive
    {
        get
        {
            var items = Chains.Select(x => x.MinTimeToLive).ToList();
            return items.Max();
        }
    }
}