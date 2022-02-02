namespace colecoes.models {
    public class Fila {
        public static void PrintQueue(Queue<string> queue) {
            System.Console.WriteLine("\nQuantidade de elementos: {0}", queue.Count);
            for (int i = 0; queue.Count > 0; i++) {
                System.Console.WriteLine("{0}. {1}", i + 1, queue.Dequeue());
            }
        }

        public static void TestQueue() {
            Queue<string> queue = new Queue<string>();
            
            queue.Enqueue("Vinicius");
            queue.Enqueue("Paula");
            queue.Enqueue("Pedro");

            PrintQueue(queue);

            System.Console.WriteLine("Pessoas restantes: " + queue.Count);
        }
    }
}