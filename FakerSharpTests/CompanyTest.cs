using FakerSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace FakerSharpTests
{
    
    
    /// <summary>
    ///This is a test class for CompanyTest and is intended
    ///to contain all CompanyTest Unit Tests
    ///</summary>
	[TestClass()]
	public class CompanyTest
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
		///A test for BS
		///</summary>
		[TestMethod()]
		public void BSTest()
		{
			string actual;
			actual = Company.BS;
			Assert.IsTrue(FakerSharp.Properties.Strings.CompanyBS1.Split(',').Any(s => actual.Contains(s.Trim())));
			Assert.IsTrue(FakerSharp.Properties.Strings.CompanyBS2.Split(',').Any(s => actual.Contains(s.Trim())));
			Assert.IsTrue(FakerSharp.Properties.Strings.CompanyBS3.Split(',').Any(s => actual.Contains(s.Trim())));
		}

		/// <summary>
		///A test for CatchPhrase
		///</summary>
		[TestMethod()]
		public void CatchPhraseTest()
		{
			string actual;
			actual = Company.CatchPhrase;
			Assert.IsTrue(FakerSharp.Properties.Strings.CompanyCatchPhrase1.Split(',').Any(s => actual.Contains(s.Trim())));
			Assert.IsTrue(FakerSharp.Properties.Strings.CompanyCatchPhrase2.Split(',').Any(s => actual.Contains(s.Trim())));
			Assert.IsTrue(FakerSharp.Properties.Strings.CompanyCatchPhrase3.Split(',').Any(s => actual.Contains(s.Trim())));
		}

		/// <summary>
		///A test for Name
		///</summary>
		[TestMethod()]
		public void NameTest()
		{
			string actual;
			actual = Company.Name;
			Assert.IsTrue(FakerSharp.Properties.Strings.NameLastName.Split(',').Any(s => actual.Contains(s.Trim())));
		}

		/// <summary>
		///A test for Suffix
		///</summary>
		[TestMethod()]
		public void SuffixTest()
		{
			string actual;
			actual = Company.Suffix;
			Assert.IsTrue(FakerSharp.Properties.Strings.CompanySuffix.Split(',').Any(s => actual.Contains(s.Trim())));
		}
	}
}
