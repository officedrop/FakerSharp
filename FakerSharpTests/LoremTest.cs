using FakerSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FakerSharpTests
{
    
    
    /// <summary>
    ///This is a test class for LoremTest and is intended
    ///to contain all LoremTest Unit Tests
    ///</summary>
	[TestClass()]
	public class LoremTest
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
		///A test for GetSentence
		///</summary>
		[TestMethod()]
		public void GetSentenceTest()
		{
			int expected = 4;
			string actual;
			actual = Lorem.GetSentence();
			Assert.IsTrue(actual.Split(' ').Length >= expected);
		}

		/// <summary>
		///A test for GetSentence
		///</summary>
		[TestMethod()]
		public void GetSentenceTest1()
		{
			int wordCount = 3;
			int expected = 3;
			string actual;
			actual = Lorem.GetSentence(wordCount);
			Assert.IsTrue(expected <= actual.Split(' ').Length);
		}

		/// <summary>
		///A test for GetSentences
		///</summary>
		[TestMethod()]
		public void GetSentencesTest()
		{
			int sentenceCount = 4;
			string[] actual;
			actual = Lorem.GetSentences(sentenceCount);
			Assert.AreEqual(sentenceCount, actual.Length);
		}

		/// <summary>
		///A test for GetSentences
		///</summary>
		[TestMethod()]
		public void GetSentencesTest1()
		{
			int expected = 3;
			string[] actual;
			actual = Lorem.GetSentences();
			Assert.AreEqual<int>(expected, actual.Length);
		}

		/// <summary>
		///A test for GetWords
		///</summary>
		[TestMethod()]
		public void GetWordsTest()
		{
			int expected = 3;
			string[] actual;
			actual = Lorem.GetWords();
			Assert.AreEqual<int>(expected, actual.Length);
		}

		/// <summary>
		///A test for GetWords
		///</summary>
		[TestMethod()]
		public void GetWordsTest1()
		{
			int wordCount = 5;
			int expected = 5;
			string[] actual;
			actual = Lorem.GetWords(wordCount);
			Assert.AreEqual<int>(expected, actual.Length);
		}

		/// <summary>
		///A test for Paragraph
		///</summary>
		[TestMethod()]
		public void ParagraphTest()
		{
			int sentenceCount = 5;
			string actual;
			actual = Lorem.Paragraph(sentenceCount);
			Assert.IsTrue(actual.Split(' ').Length >= sentenceCount);
		}

		/// <summary>
		///A test for Paragraph
		///</summary>
		[TestMethod()]
		public void ParagraphTest1()
		{
			int expected = 3;
			string actual;
			actual = Lorem.Paragraph();
			Assert.IsTrue(expected <= actual.Split(' ').Length);
		}

		/// <summary>
		///A test for Paragraphs
		///</summary>
		[TestMethod()]
		public void ParagraphsTest()
		{
			int expected = 3;
			string[] actual;
			actual = Lorem.Paragraphs();
			Assert.AreEqual<int>(expected, actual.Length);
		}

		/// <summary>
		///A test for Paragraphs
		///</summary>
		[TestMethod()]
		public void ParagraphsTest1()
		{
			int paragraphCount = 5;
			int expected = 5; // TODO: Initialize to an appropriate value
			string[] actual;
			actual = Lorem.Paragraphs(paragraphCount);
			Assert.AreEqual<int>(expected, actual.Length);
		}
	}
}
