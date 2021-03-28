using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{

    interface IOrderService
    {
        void Order(Game game, Gamer gamer);

        void CampaignOrder(Game game, Gamer gamer, Campaign campaign);
    
    }
}
