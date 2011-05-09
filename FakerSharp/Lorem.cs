using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace FakerSharp
{
	public class Lorem : Base<Lorem>
	{
		private static readonly string[] loremWords;

		static Lorem()
		{
			loremWords = (from w in Properties.Strings.LoremWords.Split(',')
						  where !string.IsNullOrWhiteSpace(w)
						  select w.Trim()).ToArray();
		}

		public static string[] GetWords() { return GetWords(3); }
		public static string[] GetWords(int num)
		{
			List<string> words = new List<string>();
			while (words.Count < num)
				words.Add(loremWords.Pick());
			return words.ToArray();
		}

		public static string GetSentence() { return GetSentence(4); }
		public static string GetSentence(int wordCount)
		{
			StringBuilder finalString = new StringBuilder();
			string actualString = string.Join(" ", GetWords(wordCount + random.Next(6)));
			return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(actualString);
		}

		public static string[] GetSentences() { return GetSentences(3); }
		public static string[] GetSentences(int sentenceCount)
		{
			List<string> sentences = new List<string>();
			while (sentences.Count < sentenceCount)
				sentences.Add(GetSentence());
			return sentences.ToArray();
		}

		public static string Paragraph() { return Paragraph(3); }
		public static string Paragraph(int sentenceCount)
		{
			return string.Join(" ", GetSentences(sentenceCount + random.Next(3)));
		}

		public static string[] Paragraphs() { return Paragraphs(3); }
		public static string[] Paragraphs(int paragraphCount)
		{
			List<string> paragraphs = new List<string>();
			while (paragraphs.Count < paragraphCount)
				paragraphs.Add(Paragraph());
			return paragraphs.ToArray();
		}
	}
}
