namespace RWIAsn2;
/*
 Controller It’s the class that serves as a bridge between the user and the calculator. It contains
references to both the Parser and Calculator objects as well as the TextMenu class. Those are passed
as arguments to the Controller’s constructor. It uses Parser for input validation and splitting it into
tokens and Calculator for evaluating lexed expressions. The communication with a user is done through
the TextMenu class. The Run method of the Controller class contains an infinite loop that accepts user
input, interprets it and reacts accordingly by calling the methods of its subobjects.
 */
class Controller
{
    private ICalculator _calc;
    private IParser _parser;
    private IMenu _menu;
    public Controller(ICalculator calc, IParser parser, IMenu menu) { ...}
    // the main run loop that accepts user input in a loop
    public void Run()
    {
        Menu.ShowMenu();
        var input = string.Empty;
        do
        {
            Console.Write("> ");
            input = Console.ReadLine() ?? "quit";
            switch (input)
            {
                case "q":
                    break;
                case "h":
                    Menu.ShowHelp();
                    break;
                case "o":
                    Menu.ShowOperations();
                    break;
                default:
                    // an RPN expression is expected here
                    try
                    {
                        var split = Parser.Tokenize(input);
                        if (split.Count != 0)
                        {
                            var tokens = Parser.Lex(split);
                            var result = Calculator.Calculate(tokens);
                            Console.WriteLine($"\n {result}\n");
                        }
                    }
                    // if the input is not valid, an exception is thrown by calculator or parser
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
            }
        } while (!input.ToLower().Equals("q");
        Console.WriteLine("\n Calculator is quitting. Bye!");
    }
}
