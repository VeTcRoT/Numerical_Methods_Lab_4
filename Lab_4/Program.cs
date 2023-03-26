using Lab_4;

double[,] systemMatrix =
{
    { 2, -1, -1 },
    { 3, 5, -1 }, 
    { 1, -4, 10 }
};

double[] freeMembersColumn = { -3, 1, 0 };

var iteration = new IterationMethod(systemMatrix, freeMembersColumn);

foreach (var item in iteration.GetResult())
{
    Console.WriteLine(item);
}

Console.WriteLine();

var seidel = new IterationMethod(systemMatrix, freeMembersColumn);

foreach (var item in seidel.GetResult())
{
    Console.WriteLine(item);
}