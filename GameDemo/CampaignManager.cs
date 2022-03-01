using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    public class CampaignManager
    {

        private List<Campaign> CampaignList { get;}

        public CampaignManager(Campaign campaign)
        {
            this.CampaignList = new List<Campaign>();
        }

        public Boolean Delete(Campaign campaign)
        {
            if (campaign == null)
            {
                return false;
            }
            CampaignList.Remove(campaign);
            return true;
        }

        public Boolean Add(Campaign campaign)
        {
            if (!CampaignList.Contains(campaign))
            {
                CampaignList.Add(campaign);
                return true;
            }
            return false;
        }

        public Campaign Update(int CampaignId)
        {
            foreach (Campaign campaign in CampaignList)
            {
                if(campaign.CampaignId == CampaignId)
                {
                    return campaign;
                }
            }
            return null;
        }
    }
}
