int CalculateFactorial(ref int number)
{
    int counter;
    var factorial = 1;

    for (counter = 1; counter <= number; counter++) factorial *= counter;

    return factorial;
}