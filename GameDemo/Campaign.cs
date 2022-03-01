using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Ratio { get; set; }

        public Campaign(int campaignId, string name, string description)
        {
            CampaignId = campaignId;
            Name = name;
            Description = description;
        }

    }
}
