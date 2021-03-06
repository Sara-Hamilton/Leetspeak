using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Leetspeak;

namespace Leetspeak.Tests
{
  [TestClass]
  public class LeetspeakTest
  {
    [TestMethod]
    public void Leetspeak_EToThree_LeetspeakTranslation()
    {
      LeetspeakGenerator testLeetspeak = new LeetspeakGenerator();
      Assert.AreEqual("ch33r", testLeetspeak.Leetspeak("cheer"));
    }

    [TestMethod]
    public void Leetspeak_OToZero_LeetspeakTranslation()
    {
      LeetspeakGenerator testLeetspeak = new LeetspeakGenerator();
      Assert.AreEqual("g30rg3", testLeetspeak.Leetspeak("gEOrge"));
    }

    [TestMethod]
    public void Leetspeak_CapitalIToOne_LeetspeakTranslation()
    {
      LeetspeakGenerator testLeetspeak = new LeetspeakGenerator();
      Assert.AreEqual("1ndiana", testLeetspeak.Leetspeak("Indiana"));
    }

    [TestMethod]
    public void Leetspeak_TToSeven_LeetspeakTranslation()
    {
      LeetspeakGenerator testLeetspeak = new LeetspeakGenerator();
      Assert.AreEqual("i7ch", testLeetspeak.Leetspeak("itch"));
    }

    [TestMethod]
    public void Leetspeak_SToZ_LeetspeakTranslation()
    {
      LeetspeakGenerator testLeetspeak = new LeetspeakGenerator();
      Assert.AreEqual("az", testLeetspeak.Leetspeak("as"));
    }

    [TestMethod]
    public void Leetspeak_LowerFirstSUnchanged_LeetspeakTranslation()
    {
      LeetspeakGenerator testLeetspeak = new LeetspeakGenerator();
      Assert.AreEqual("sazzy", testLeetspeak.Leetspeak("sassy"));
    }

    [TestMethod]
    public void Leetspeak_CapitalFirstSUnchanged_LeetspeakTranslation()
    {
      LeetspeakGenerator testLeetspeak = new LeetspeakGenerator();
      Assert.AreEqual("Sazzy", testLeetspeak.Leetspeak("Sassy"));
    }
  }
}
