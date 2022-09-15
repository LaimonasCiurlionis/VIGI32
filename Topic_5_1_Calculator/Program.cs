//Suskleisti methodus => ctrl + m + o
//Atskleisti => ctrl + m +l

string[] validOperators = { "+", "-", "*", "/" };

Init();

void Init() 
{
    while (true) 
    {
        Console.Clear();
        double firstNum = GetNumberFromConsole();
        double secondNum = GetNumberFromConsole();
        string operatorValue = GetOperatorFromConsole();

        double result = PerformCalculation(firstNum, secondNum, operatorValue);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}

double PerformCalculation(double firstNum, double secondNum, string operation) 
{
    double result = 0;

    switch (operation) 
    {
        case "+":
            result = Add(firstNum, secondNum);
            break;
        case "-":
            result = Minus(firstNum, secondNum);
            break;
        case "*":
            result = Multiply(firstNum, secondNum);
            break;
        case "/":
            result = Divide(firstNum, secondNum);
            break;
            default:
            result = 0;
            break;
    }

    return result;
}

double GetNumberFromConsole() 
{
    bool isCorrectNumber = false;
    double argumentValue = 0;

    while (!isCorrectNumber) 
    {
        Console.WriteLine("Enter a number or Q to exit app");
        string userInputValue = Console.ReadLine();

        CheckAppplicationExit(userInputValue);

        if (double.TryParse(userInputValue, out argumentValue))
        {
            isCorrectNumber = true;
        }
        else 
        {
            Console.WriteLine("Please enter a valid number");
        }
    }

    return argumentValue;
}

string GetOperatorFromConsole() 
{
    bool isCorrectOperator = false;
    string operatorValue = string.Empty;

    while (!isCorrectOperator) 
    {
        Console.WriteLine($"Enter an operator or Q to exit. Allowed operators: {string.Join(", ", validOperators)}");

        string userInputValue = Console.ReadLine();

        CheckAppplicationExit(userInputValue);

        if (IsOpretatorValid(userInputValue))
        {
            operatorValue = userInputValue;
            isCorrectOperator = true;
        }
        else 
        {
            Console.WriteLine("Please enter a valid operator");
        }
    }

    return operatorValue;
}

bool IsOpretatorValid(string userInputValue) 
{
    return validOperators.Contains(userInputValue);
}

double Add(double firstNum, double secondNum) 
{
    //var result = firstNum + secondNum;
    //return result;

    return firstNum + secondNum;
}

double Minus(double firstNum, double secondNum)
{
    return firstNum - secondNum;
}

double Multiply(double firstNum, double secondNum)
{
    return firstNum * secondNum;
}

double Divide(double firstNum, double secondNum)
{
    return firstNum / secondNum;
}

void CheckAppplicationExit(string input) 
{
    if (input.Equals("q", StringComparison.OrdinalIgnoreCase)) 
    {
        CloseApplication();
    }
}

void CloseApplication() 
{
    Console.WriteLine("Goodbey, thank you for using our Caculator app");
    Console.WriteLine("Press any key to close application");
    Environment.Exit(0);
}

