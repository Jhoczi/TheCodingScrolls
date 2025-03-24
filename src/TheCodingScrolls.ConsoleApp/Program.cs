using System.Reflection;
using TheCodingScrolls.ConsoleApp.Problems;

Console.WriteLine("== The Coding Scrolls ==");

IProblem problem = new Problem001_TwoSum();
RunProblem(problem);

static void RunProblem(IProblem problem)
{
    Console.WriteLine($"\n--- {problem.Name} ---");
    problem.Run();
}

