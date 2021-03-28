using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
   public class Program
    {
        public static void Main(string[] args)

        { 

                GamerManager gamerManager = new GamerManager(new GamerCheckManager());
                Gamer gamer1 = new Gamer
                {
                    Id = 1,
                    DateOfBirth = new DateTime(1999, 06, 07),
                    FirstName = " Mislina ",
                    LastName = "  AYDIN ",
                    UserName = " MslnAydn ",
                    NationalityId = 1234567
                };

                Gamer gamer2 = new Gamer
                {
                    Id = 2,
                    DateOfBirth = new DateTime(1997, 09, 16),
                    FirstName = " Şeyda ",
                    LastName = " ÖZAY ",
                    UserName = " SYDOZY ",
                    NationalityId = 7654321
                };



                gamerManager.Add(gamer1);

                Console.WriteLine("----------------------------");

                CampaignManager campaingManager = new CampaignManager();
                Campaign campaign = new Campaign { Id = 1, CampaignName = "  %10 İNDİRİMLİ ", DiscountRate = 0.60M };
                Campaign campaign2 = new Campaign { Id = 2, CampaignName = "  %70 İNDİRİMLİ ", DiscountRate = 0.80M };
                campaingManager.Add(campaign);

                Console.WriteLine("----------------------------");

                GameManager gameManager = new GameManager();
                Game game1 = new Game { Id = 1, GameName = "GTA 3", GamePrice = 50 };
                Game game2 = new Game { Id = 2, GameName = "GTA 4  ", GamePrice = 190 };

                gameManager.Add(game2);
                gameManager.Update(game1);

                Console.WriteLine("----------------------------");

                OrderManager orderManager = new OrderManager();

                orderManager.CampaignOrder(game1, gamer1, campaign);
                orderManager.Order(game2, gamer2);








            }
        }
    }

