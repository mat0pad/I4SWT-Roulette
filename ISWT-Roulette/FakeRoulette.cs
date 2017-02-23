using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteGame.Legacy;

namespace ISWT_Roulette
{
    public class FakeRoulette : IRoulette
    {
        public int CountGetResult { get; set; } = 0;
        public int CountSpin { get; set; } = 0;
        public Field GetResult()
        {
            CountGetResult++;
            return new Field(20,0);
        }

        public void Spin()
        {
            CountSpin++;
        }
    }
}
