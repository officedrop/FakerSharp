using FakerSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FakerSharpTests
{
    
    
    /// <summary>
    ///This is a test class for NameTest and is intended
    ///to contain all NameTest Unit Tests
    ///</summary>
	[TestClass()]
	public class NameTest
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
		///A test for FirstName
		///</summary>
		[TestMethod()]
		public void FirstNameTest()
		{
			string actual;
			actual = Name.FirstName;
			Assert.IsTrue(actual.Split(' ').Length == 1);
		}

		/// <summary>
		///A test for FullName
		///</summary>
		[TestMethod()]
		public void FullNameTest()
		{
			string actual;
			actual = Name.FullName;
			Assert.IsTrue(actual.Split(' ').Length >= 2);
		}

		/// <summary>
		///A test for LastName
		///</summary>
		[TestMethod()]
		public void LastNameTest()
		{
			string actual;
			actual = Name.LastName;
			Assert.IsTrue(actual.Split(' ').Length == 1);
		}

		/// <summary>
		///A test for Prefix
		///</summary>
		[TestMethod()]
		public void PrefixTest()
		{
			string actual;
			actual = Name.Prefix;
			Assert.IsTrue(actual.Split(' ').Length == 1);
		}

		/// <summary>
		///A test for Suffix
		///</summary>
		[TestMethod()]
		public void SuffixTest()
		{
			string actual;
			actual = Name.Suffix;
			Assert.IsTrue(actual.Split(' ').Length == 1);
		}
	}
}
