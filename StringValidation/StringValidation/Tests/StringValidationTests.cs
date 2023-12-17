using System;
namespace StringValidation.Tests

public class StringValidationTests
{
	public CheckUppercaseTest_Valid_ReturnTrue()
	{
		string input = "Valid Sentence";

		bool result = Program.CheckUppercase(input);

		Assert.IsTrue(result);
	}

	public void CheckUppercaseTest_Invalid_ReturnFalse()
	{
		string input = "invalid sentence";

		bool result = Program.CheckUppercase(input);

		Assert.IsFalse(result);
	}

	public void EvenQuotes_Valid_ReturnTrue()
	{
		string input = "Valid sentence with \"quotes\".";

		bool result = Program.EvenQuotes(input);

		Assert.IsTrue(result);
	}

	public void EvenQuotes_Invalid_ReturnFalse()
	{
		string input = "Invalid sentence with \"quotes.";

		bool result = Program.EvenQuotes(input);

		Assert.IsFalse(result);
	}

	public void EndOfSentence_Valid_ReturnTrue()
	{

		string input = "Sentence ends correctly.";

		bool result = Program.EndOfSentence(input);

		Assert.IsTrue(result);
	}

	public void EndOfSentence_Invalid_ReturnFalse()
	{
		string input = "Invalid sentence without terminator";

		bool result = Program.EndOfSentence(input);

		Assert.IsFalse(result);
	}

	public void NumberSpellOut_Valid_ReturnTrue()
	{

		string input = "Sentence with numbers above 13.";

		bool result = Program.NumberSpellOut(input);

		Assert.IsTrue(result);
	}

	public void NumberSpellOut_Invalid_ReturnFalse()
	{
		string input = "Sentence with numbers below 13.";

		bool result = Program.NumberSpellOut(input);

		Assert.IsFalse(result);
	}

	public void EndPeriod_Valid_ReturnTrue()
	{

		string input = "Sentence with a period at the end.";

		bool result = Program.EndPeriod(input);

		Assert.IsTrue(result);
	}

	public void EndPeriod_Invalid_ReturnFalse()
	{

		string input = "Sentence with a period in the middle.";

		bool result = Program.EndPeriod(input);

		Assert.IsFalse(result);
	}
}