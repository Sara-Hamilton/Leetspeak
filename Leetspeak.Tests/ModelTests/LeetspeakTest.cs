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
      Assert.AreEqual("ch33s3", testLeetspeak.Leetspeak("cheese"));
    }

    [TestMethod]
    public void Leetspeak_OToZero_LeetspeakTranslation()
    {
      LeetspeakGenerator testLeetspeak = new LeetspeakGenerator();
      Assert.AreEqual("g30rg3", testLeetspeak.Leetspeak("george"));
    }

  }
}
