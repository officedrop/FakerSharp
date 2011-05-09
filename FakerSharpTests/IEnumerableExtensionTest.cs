using FakerSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

namespace FakerSharpTests
{
    
    
    /// <summary>
    ///This is a test class for IEnumerableExtensionTest and is intended
    ///to contain all IEnumerableExtensionTest Unit Tests
    ///</summary>
	[TestClass()]
	public class IEnumerableExtensionTest
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
		///A test for Pick
		///</summary>
		public void PickTestHelper<TResult>()
		{
			IEnumerable<TResult> collection = new TResult[10];
			
			TResult actual;
			actual = IEnumerableExtension.Pick<TResult>(collection);
			Assert.IsTrue(collection.Contains(actual));
		}

		[TestMethod()]
		public void PickTest()
		{
			PickTestHelper<GenericParameterHelper>();
		}

		/// <summary>
		///A test for Pick
		///</summary>
		[TestMethod()]
		public void PickTest1()
		{
			IEnumerable collection = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			object actual;
			actual = IEnumerableExtension.Pick(collection);
			Assert.IsTrue(collection.Cast<int>().Contains((int)actual));
		}
	}
}
