using System.Reflection;
using TheCodingScrolls.ConsoleApp.Problems;

Console.WriteLine("== The Coding Scrolls ==");

//var problem = new Problem001_TwoSum();
var problem = new Problem002_AddTwoNumbers();
RunProblem(problem);

static void RunProblem(IProblem problem)
{
    Console.WriteLine($"\n--- {problem.Name} ---");
    problem.Run();
}

