namespace ReliabilityOptimizationCalc.BLL.Models;

public class MapModel
{
    public List<MapModel> Chains { get; set; } = new List<MapModel>();
    
    public List<NodeModel> Nodes { get; set; } = new List<NodeModel>();

    public decimal MinTimeToLive
    {
        get
        {
            var items = Nodes.Select(x => x.TimeToLive).ToList();
            return items.Min();
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