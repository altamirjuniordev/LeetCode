
using LeetCode.Problems;

class Program
{
    static void Main(string[] args)
    {
        //TWO SUM
        // var resultado = TwoSum.Solution(new int[] { 1, 2, }, 9);
        // Console.WriteLine($"Resultado: {resultado[0]}, {resultado[1]}");


        // VALID PARENTHESES
        var resultado1 = ValidParentheses.Solution("({})");
        var resultado2 = ValidParentheses.Solution("(");
        var resultado3 = ValidParentheses.Solution("(]");

        Console.WriteLine($"resultado1: {(resultado1 ? "verdade" : "false")}, resultado2: {(resultado2 ? "verdade" : "false")}, resultado3: {(resultado3 ? "verdade" : "false")}");
    }
}