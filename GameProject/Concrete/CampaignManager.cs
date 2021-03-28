using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+"Kampanya Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanya Silindi");
        }

        public void UpDate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanya Güncellendi");
        }
    }
}
