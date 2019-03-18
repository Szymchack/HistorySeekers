using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistorySeekers.Models;

namespace HistorySeekers.DataLayer
{


    public static class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                Id = 1,
                Name = "Doctor Holley",
                Age = 35,
                Experience = Character.ExperienceLevel.Archeologist,
                JobTitle = Player.JobTitleName.MissionLeader,
                Health = 100,
                Lives = 3,
                ExperiencePoints = 0
            };

        }
        public static List<string> InitialMessages()
        {
            return new List<string>()
                {
                   "\tYou have been hired by the History Seekers Archeology Associates to participate in its latest endeavor, the NMC Project. Your mission is to  find the location of the James Becket Building and report back to the History Seekers.",
                "\tYou will begin by choosing a new location and using the Jedi Speeder Bike to travel to that point in the dig site.\n\tThe Speeder Bike will allow you to travel the dig sight at a faster speed.",
                };
        }

    }

}