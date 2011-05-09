using FakerSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Linq.Expressions;

namespace FakerSharpTests
{
    
    
    /// <summary>
    ///This is a test class for AddressTest and is intended
    ///to contain all AddressTest Unit Tests
    ///</summary>
	[TestClass()]
	public class AddressTest
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
		///A test for City
		///</summary>
		[TestMethod()]
		public void CityTest()
		{
			string actual;
			actual = Address.City;
			Assert.IsTrue(actual.Split(' ').Length >= 1);
		}

		/// <summary>
		///A test for CityPrefix
		///</summary>
		[TestMethod()]
		public void CityPrefixTest()
		{
			string actual;
			actual = Address.CityPrefix;
			Assert.IsTrue(actual.Split(' ').Length == 1);
			Assert.IsTrue(FakerSharp.Properties.Strings.AddressCityPrefix.Contains(actual));
		}

		/// <summary>
		///A test for CitySuffix
		///</summary>
		[TestMethod()]
		public void CitySuffixTest()
		{
			string actual;
			actual = Address.CitySuffix;
			Assert.IsTrue(actual.Split(' ').Length == 1);
			Assert.IsTrue(FakerSharp.Properties.Strings.AddressCitySuffix.Contains(actual));
		}

		/// <summary>
		///A test for Country
		///</summary>
		[TestMethod()]
		public void CountryTest()
		{
			string actual;
			actual = Address.Country;
			Assert.IsTrue(FakerSharp.Properties.Strings.AddressCountry.Contains(actual));
		}

		/// <summary>
		///A test for Postcode
		///</summary>
		[TestMethod()]
		public void PostcodeTest()
		{
			string actual;
			actual = Address.Postcode;
			Assert.IsTrue(new Regex(@"^\d{5}(?:-\d{4})?$").IsMatch(actual));
		}

		/// <summary>
		///A test for SecondaryAddress
		///</summary>
		[TestMethod()]
		public void SecondaryAddressTest()
		{
			string actual;
			actual = Address.SecondaryAddress;
			Assert.IsTrue(actual.Contains("Apt.") || actual.Contains("Suite"));
		}

		/// <summary>
		///A test for State
		///</summary>
		[TestMethod()]
		public void StateTest()
		{
			string actual;
			actual = Address.State;
			Assert.IsTrue(FakerSharp.Properties.Strings.AddressState.Contains(actual));
		}

		/// <summary>
		///A test for StateAbbr
		///</summary>
		[TestMethod()]
		public void StateAbbrTest()
		{
			string actual;
			actual = Address.StateAbbr;
			Assert.IsTrue(FakerSharp.Properties.Strings.AddressStateAbbr.Contains(actual));
		}

		/// <summary>
		///A test for StreetAddress
		///</summary>
		[TestMethod()]
		public void StreetAddressTest()
		{
			string actual;
			actual = Address.StreetAddress;
			Assert.IsTrue(actual.Split(' ').Length > 1);
		}

		/// <summary>
		///A test for StreetAddressWithSecondary
		///</summary>
		[TestMethod()]
		public void StreetAddressWithSecondaryTest()
		{
			string actual;
			actual = Address.StreetAddressWithSecondary;
			Assert.IsTrue(actual.Contains("Apt.") || actual.Contains("Suite"));
		}

		/// <summary>
		///A test for StreetName
		///</summary>
		[TestMethod()]
		public void StreetNameTest()
		{
			string actual;
			actual = Address.StreetName;
			Assert.IsTrue(FakerSharp.Properties.Strings.AddressStreetSuffix.Split(',').Any(s => actual.Contains(s.Trim())));
		}

		/// <summary>
		///A test for StreetSuffix
		///</summary>
		[TestMethod()]
		public void StreetSuffixTest()
		{
			string actual;
			actual = Address.StreetSuffix;
			Assert.IsTrue(FakerSharp.Properties.Strings.AddressStreetSuffix.Contains(actual));
		}

		/// <summary>
		///A test for Zip
		///</summary>
		[TestMethod()]
		public void ZipTest()
		{
			string actual;
			actual = Address.Zip;
			Assert.IsTrue(new Regex(@"^\d{5}(?:-\d{4})?$").IsMatch(actual));
		}

		/// <summary>
		///A test for ZipCode
		///</summary>
		[TestMethod()]
		public void ZipCodeTest()
		{
			string actual;
			actual = Address.ZipCode;
			Assert.IsTrue(new Regex(@"^\d{5}(?:-\d{4})?$").IsMatch(actual));
		}
	}
}
