using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using Microsoft.EntityFrameworkCore;
using SamuraiDB.Models;

namespace SamuraiDB.Data
{
    internal class DataAccess
    {

        public void Seed()
        {
            using (Context context = new Context())
            {
                try
                {
                    var rnd = new csSeedGenerator();

                    List<Samurai> samuraiList = new List<Samurai>();
                    List<Battle> battleList = new List<Battle>();

                    for (int i = 0; i < 50; i++)
                    {
                        Samurai seededSamurai = new Samurai();
                        seededSamurai.FirstName = rnd.FirstName;
                        seededSamurai.LastName = rnd.LastName;
                        seededSamurai.Hairstyle = rnd.FromEnum<enHairstyle>();
                        samuraiList.Add(seededSamurai);
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        Battle seededBattle = new Battle();
                        seededBattle.Name = rnd.City();
                        seededBattle.Description = "Some rand desc";
                        seededBattle.wasBrutal = rnd.Bool;
                        seededBattle.StartDate = rnd.DateAndTime(1200, 1400);
                        seededBattle.EndDate = rnd.DateAndTime(1500, 1600);
                        battleList.Add(seededBattle);
                    }


                    int samuraiIndex = 0;

                    // Iterate through the battle list
                    while (samuraiList.Count > 0)
                    {
                        foreach (Battle battle in battleList)
                        {
                            if (samuraiList.Count == 0)
                            {
                                break; // Break if there are no more samurai left
                            }

                            // Add one samurai to the current battle
                            battle.Samurais.Add(samuraiList[0]);
                            samuraiList.RemoveAt(0); // Remove the added samurai from the samurai list
                        }
                    }

                    context.SaveChanges();


                    foreach (Battle battle in battleList)
                    {
                        Console.WriteLine($"Battle: {battle.Name}");
                        Console.WriteLine($"Samurais:");
                        foreach (Samurai samurai in battle.Samurais)
                        {
                            Console.WriteLine($"{samurai.FirstName} {samurai.LastName}");
                        }
                        Console.WriteLine();

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saving changes: {ex.Message}");
                }



            }
        }
    }
}
