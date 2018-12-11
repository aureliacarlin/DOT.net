using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public class Music
    {
        public virtual void AnnounceGreatMusic()
        {
            Console.WriteLine("It's impossible to argue that the greates music of all time comes from Michaell Bolton");
        }

        public void AnnounceGreatMusic(string name)
        {
            Console.WriteLine("Anything by {0} is the greates music", name);
        }

        public void AnnounceGeatMusic(string name, string album)
        {
            Console.WriteLine("{0} is the best in the world. Check out {1}.", name, album);
        }
    }
}
