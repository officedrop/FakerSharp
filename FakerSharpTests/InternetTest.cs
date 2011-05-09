using FakerSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace FakerSharpTests
{
    
    
    /// <summary>
    ///This is a test class for InternetTest and is intended
    ///to contain all InternetTest Unit Tests
    ///</summary>
	[TestClass()]
	public class InternetTest
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
		///A test for GetEmail
		///</summary>
		[TestMethod()]
		public void GetEmailTest()
		{
			string actual;
			actual = Internet.GetEmail();
			Assert.IsTrue(actual.Contains("@"));
			Assert.IsTrue(actual.Contains("."));
		}

		/// <summary>
		///A test for GetEmail
		///</summary>
		[TestMethod()]
		public void GetEmailTest1()
		{
			string name = "Rodolfo Carvalho";
			
			string actual;
			actual = Internet.GetEmail(name);
			Assert.IsTrue(actual.Contains("rodolfo"));
			Assert.IsTrue(actual.Contains("carvalho"));
			Assert.IsTrue(actual.Contains("@"));
			Assert.IsTrue(actual.Contains("."));
		}

		/// <summary>
		///A test for GetFreeEmail
		///</summary>
		[TestMethod()]
		public void GetFreeEmailTest()
		{
			string name = "Rodolfo Carvalho";
			string actual;
			actual = Internet.GetFreeEmail(name);
			Assert.IsTrue(actual.Contains("rodolfo"));
			Assert.IsTrue(actual.Contains("carvalho"));
			Assert.IsTrue(FakerSharp.Properties.Strings.InternetFreeEmail.Split(',').Any(s => s.Trim() == actual.Split('@')[1]));
		}

		/// <summary>
		///A test for GetFreeEmail
		///</summary>
		[TestMethod()]
		public void GetFreeEmailTest1()
		{
			string expected = string.Empty;
			string actual;
			actual = Internet.GetFreeEmail();
			Assert.IsTrue(FakerSharp.Properties.Strings.NameFirstName.Split(',').Any(s => actual.Contains(s.Trim().ToLower())));
			Assert.IsTrue(FakerSharp.Properties.Strings.InternetFreeEmail.Split(',').Any(s => s.Trim() == actual.Split('@')[1]));
		}

		/// <summary>
		///A test for GetUserName
		///</summary>
		[TestMethod()]
		public void GetUserNameTest()
		{
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			actual = Internet.GetUserName();
			Assert.IsTrue(FakerSharp.Properties.Strings.NameFirstName.Split(',').Any(n => actual.Contains(n.Trim().ToLower())));
		}

		/// <summary>
		///A test for GetUserName
		///</summary>
		[TestMethod()]
		public void GetUserNameTest1()
		{
			string name = "Rodolfo Carvalho";
			string actual;
			actual = Internet.GetUserName(name);
			Assert.IsTrue(actual.Contains("rodolfo"));
			Assert.IsTrue(actual.Contains("carvalho"));
			Assert.IsFalse(actual.Contains("lambert"));
		}

		/// <summary>
		///A test for DomainName
		///</summary>
		[TestMethod()]
		public void DomainNameTest()
		{
			string actual;
			actual = Internet.DomainName;
			Assert.IsTrue(FakerSharp.Properties.Strings.InternetDomainSuffix.Contains(actual.Split('.').Last()));
		}

		/// <summary>
		///A test for DomainSuffix
		///</summary>
		[TestMethod()]
		public void DomainSuffixTest()
		{
			string actual;
			actual = Internet.DomainSuffix;
			Assert.IsTrue(FakerSharp.Properties.Strings.InternetDomainSuffix.Contains(actual));
		}

		/// <summary>
		///A test for DomainWord
		///</summary>
		[TestMethod()]
		public void DomainWordTest()
		{
			string actual;
			actual = Internet.DomainWord;
			Assert.IsFalse(actual.Contains(" "));
		}

		/// <summary>
		///A test for IPv4Address
		///</summary>
		[TestMethod()]
		public void IPv4AddressTest()
		{
			string actual;
			actual = Internet.IPv4Address;
			Assert.IsTrue(new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$").IsMatch(actual));
		}

		/// <summary>
		///A test for IPv6Address
		///</summary>
		[TestMethod()]
		public void IPv6AddressTest()
		{
			string actual;
			actual = Internet.IPv6Address;
			Assert.IsTrue(new Regex(@"^[0-9A-F]{1,4}:[0-9A-F]{1,4}:[0-9A-F]{1,4}:[0-9A-F]{1,4}:[0-9A-F]{1,4}:[0-9A-F]{1,4}:[0-9A-F]{1,4}:[0-9A-F]{1,4}$").IsMatch(actual));
		}
	}
}
