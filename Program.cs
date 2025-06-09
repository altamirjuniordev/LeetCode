
using LeetCode.Problems;

class Program
{
    static void Main(string[] args)
    {
        //TWO SUM
        // var resultado = TwoSum.Solution(new int[] { 1, 2, }, 9);
        // Console.WriteLine($"Resultado: {resultado[0]}, {resultado[1]}");


        // VALID PARENTHESES
        // var resultado1 = ValidParentheses.Solution("({})");
        // var resultado2 = ValidParentheses.Solution("(");
        // var resultado3 = ValidParentheses.Solution("(]");

        // Console.WriteLine($"resultado1: {(resultado1 ? "verdade" : "false")}, resultado2: {(resultado2 ? "verdade" : "false")}, resultado3: {(resultado3 ? "verdade" : "false")}");

        // MERGE TWO SORTED LISTS
        var l1 = new MergeTwoSortedList.ListNode(1, new MergeTwoSortedList.ListNode(3, new MergeTwoSortedList.ListNode(5)));
        var l2 = new MergeTwoSortedList.ListNode(2, new MergeTwoSortedList.ListNode(4, new MergeTwoSortedList.ListNode(6)));

        var merged = MergeTwoSortedList.Solution(l1, l2);
        Console.Write("Lista mesclada: ");
        MergeTwoSortedList.PrintList(merged);
    }
}