using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerCheckManager : IGamerCheckManager
    {
        IGamerCheckManager _gamerCheckService;
        public bool Check(Gamer gamer)
        {
            _gamerCheckService = new MernisServiceAdapter();

            return _gamerCheckService.Check(gamer);
        }
    }
}
