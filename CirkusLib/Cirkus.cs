using System.Collections.Generic;
using System.Diagnostics;

namespace CirkusLib
{
    public class Cirkus
    {
      public string Name;
        private Dictionary<Artist, int> artistdictionary = new Dictionary<Artist, int>();
        

        public Cirkus(string name)
        {
            this.Name = name;
        }

      

        public void Anställ(Artist artist)
        {
            artistdictionary.Add(artist, 0);
        }

        public void ArtistUppträdande(Artist artist)
        {
            //
            artistdictionary[artist]++;
        }

        public override string ToString()
        {
            var message =$"Cirkus {this.Name} har {this.AntalArtister} artister.";
            //foreach (var item in artistdictionary)
            //{
            //    string gånger = "gång";
            //    if (item.Value>1)
            //    {
            //        gånger += "er";
            //        message += $"item.Key.Name";
            //    }
            //    Debug.WriteLine(message);
            //}
            return message;
        }
        public int AntalArtister
        {
            get
            {
                return this .artistdictionary.Count;
            }
        }
    }
}
