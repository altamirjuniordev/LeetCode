namespace LeetCode.Problems
{
    public static class ValidParentheses
    {
        public static bool Solution(string s)
        {
            Stack<char> pilha = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    pilha.Push(c);
                }
                else
                {
                    if (pilha.Count == 0)
                        return false;

                    var topo = pilha.Pop();
                    if ((c == ')' && topo != '(')
                        || (c == ']' && topo != '[')
                        || (c == '}' && topo != '{'))
                        return false;
                }
            }
            return pilha.Count == 0;
        }
    }
}