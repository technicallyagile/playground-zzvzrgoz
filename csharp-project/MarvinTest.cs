using Answer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.IO;

namespace AI
{
    [TestClass]
    public class MarvinTest
    {

	[TestMethod]
	public void TalkToMarvin() 
	{
		Marvin marvin = new Marvin();
		string response = marvin.talk("Hello.");
		Assert.AreEqual ("Whatever.", response);
	}

	[TestCleanup()]
      	public void Cleanup()
      	{		

      	}

    }
}
