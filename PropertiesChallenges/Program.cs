using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelsNstuff myHotel = new HotelsNstuff();

            myHotel.RoomNumber = 3;
            myHotel.IsAvailable = false;
            myHotel.NumBeds = 8;

            Console.WriteLine($"Your room number is {myHotel.RoomNumber}.");

            if (myHotel.IsAvailable == true)
            {
                Console.WriteLine($" Room {myHotel.RoomNumber} is available tonight.");
            }
            else
            {
                Console.WriteLine($"I'm sorry, room {myHotel.RoomNumber} is not available tonight.");
            }

            Netflix myShows = new Netflix();
            Netflix yourShows = new Netflix();
            Netflix herShows = new Netflix();

            myShows.Name = "Gilmore Girls";
            myShows.Genre = "RomCom";
            myShows.Rating = 5;

            yourShows.Name = "Agents of Sheild";
            yourShows.Genre = "Action";
            yourShows.Rating = 5;

            herShows.Name = "Once Upon a Time";
            herShows.Genre = "Medieval";
            herShows.Rating = 3;

            string GetStuggestion(int rating)
            {
                if (rating >= 3)
                {
                    return "You should definitely watch this show!";

                }
                else
                {
                    return "You probably shouldn't watch that show.";
                }
                
            }

            
            Console.WriteLine(GetStuggestion(herShows.Rating));
            
            Console.ReadLine();
        }
    }
}
