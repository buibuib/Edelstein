using System.Collections.Generic;

namespace Edelstein.Core.Distributed.Peers.Info
{
    public class TradeServiceInfo : ServerServiceInfo
    {
        public ICollection<byte> Worlds { get; set; }
        
        public int RegisterFeeMeso { get; set; }
        public int CommissionRate { get; set; }
        public int CommissionBase { get; set; }
        public int AuctionDurationMin { get; set; }
        public int AuctionDurationMax { get; set; }
    }
}