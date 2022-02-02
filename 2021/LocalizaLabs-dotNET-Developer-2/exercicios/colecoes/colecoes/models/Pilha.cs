namespace colecoes.models {
    public class Pilha {
        public static void PrintStack(Stack<string> stack) {
            System.Console.WriteLine("\nQuantidade de elementos: {0}", stack.Count);
            for (int i = 0; stack.Count > 0; i++) {
                System.Console.WriteLine("{0}. {1}", i + 1, stack.Pop());
            }
        }

        public static void TestStack() {
            Stack<string> stack = new Stack<string>();
            
            stack.Push("Vinicius");
            stack.Push("Paula");
            stack.Push("Pedro");

            PrintStack(stack);

            System.Console.WriteLine("Pessoas restantes: " + stack.Count);
        }
    }
}