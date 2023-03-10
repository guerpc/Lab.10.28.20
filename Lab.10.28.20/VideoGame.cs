using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._10._28._20
{
    class VideoGame
    {
        public string GameName { get; set; }
        public string Rating { get; set; }
        public double Price { get; set; }

        public VideoGame()
        {
            GameName = "No Game Name";
            Rating = "No Game Rating";
            Price = 0;
        }
    }
}
