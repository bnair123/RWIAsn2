namespace RWIAsn2;
/*
 Parser The Parser class is responsible for parsing user input and validating it. It takes a List of
supported operators (e.g. ["+", "-", "sqrt"]) in its constructor. The Parser class has two methods of
interest: Tokenize and Lex. Tokenize takes a string and splits it into a List of string objects. Splitting
is done on whitespace characters. Lex takes a List of strings returned by Tokenize and validates them
by checking if each item is a either a number or a supported operator. If it is, it creates a Token and adds
it to a List of Token objects. This List of Token objects is returned by the Lex method.

 */
public class Parser
{
	public Parser() 
	{
	}
}
