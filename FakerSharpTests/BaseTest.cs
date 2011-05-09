using InfWeb.FakerSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace FakerSharpTests
{
    
    
    /// <summary>
    ///This is a test class for BaseTest and is intended
    ///to contain all BaseTest Unit Tests
    ///</summary>
	[TestClass()]
	public class BaseTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///A test for Numerify
		///</summary>
		[TestMethod()]
		[DeploymentItem("FakerSharp.dll")]
		public void NumerifyTest()
		{
			string numberString = "(###) ###-####";
			string actual = Base_Accessor.Numerify(numberString);
			Assert.IsTrue(new Regex(@"\(\d{3}\) \d{3}\-\d{4}").IsMatch(actual));
		}

		/// <summary>
		///A test for Letterify
		///</summary>
		[TestMethod()]
		[DeploymentItem("FakerSharp.dll")]
		public void LetterifyTest()
		{
			string letterString = "string to be replac?d";
			string actual;
			actual = Base_Accessor.Letterify(letterString);
			Assert.IsTrue(new Regex(@"string to be replac[\w]d").IsMatch(actual));
			Assert.IsFalse(actual.Contains("?"));
		}

		/// <summary>
		///A test for Bothify
		///</summary>
		[TestMethod()]
		[DeploymentItem("FakerSharp.dll")]
		public void BothifyTest()
		{
			string str = "10# Driveway, SomeC?ty";
			var expected = new Regex(@"10[\d] Driveway, SomeC[\w]ty");
			string actual;
			actual = Base_Accessor.Bothify(str);
			Assert.IsTrue(expected.IsMatch(actual));
		}

		/// <summary>
		///A test for Fetch
		///</summary>
		[TestMethod()]
		public void FetchTest()
		{
			Assert.Inconclusive("Implement this method");
		}
	}
}
