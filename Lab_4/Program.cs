using Lab_4;

double[,] systemMatrix =
{
    { 2, -1, -1 },
    { 3, 5, -1 }, 
    { 1, -4, 10 }
};

double[] freeMembersColumn = { -3, 1, 0 };

Console.WriteLine(new string('-', 30) + "Iteration Method" + new string('-', 30));

var iteration = new IterationMethod(systemMatrix, freeMembersColumn);

double[] iterationresult = iteration.GetResult();

Console.WriteLine("\nResult: X = {0}, Y = {1}, Z = {2}\n", iterationresult[0], iterationresult[1], iterationresult[2]);

Console.WriteLine(new string('-', 30) + "Seidel Method" + new string('-', 30));

var seidel = new IterationMethod(systemMatrix, freeMembersColumn);

double[] seidelresult = seidel.GetResult();

Console.WriteLine("\nResult: X = {0}, Y = {1}, Z = {2}\n", seidelresult[0], seidelresult[1], seidelresult[2]);