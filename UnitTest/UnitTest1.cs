using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RouletteGame.Legacy;
using ISWT_Roulette;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
    
        [TestMethod]
        public void TestFakeSpin()
        {
            var RL = new FakeRoulette();
            RouletteGame.Legacy.RouletteGame RG = new RouletteGame.Legacy.RouletteGame(RL);
            RG.OpenBets();
            RG.PlaceBet(new ColorBet("player 1",100,Field.Black));
            RG.CloseBets();
            RG.SpinRoulette();
            Assert.AreEqual(1, RL.CountGetResult);
        }
    }
}
