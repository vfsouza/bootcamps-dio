namespace colecoes.models {
    public class LINQ {
        public static void TestLINQ() {
            int[] numeros = new int[] {3, 1, 5, 4, 7, 2, 8, 9, 6, 9, 6, 10};
            
            IEnumerable<int> query1 = 
                    from num in numeros 
                    where num % 2 == 0 
                    orderby num 
                    select num;

            System.Console.WriteLine("Query:");
            foreach (int num in query1) {
                System.Console.WriteLine(num);
            }

            IEnumerable<int> query2 = numeros.Where(num => num % 2 != 0).OrderBy(num => num).ToArray();
            
            System.Console.WriteLine("\nMethod:");
            foreach (int num in query2) {
                System.Console.WriteLine(num);
            }

            int min = numeros.Min();
            int max = numeros.Max();
            double avg = numeros.Average();
            
            System.Console.WriteLine($"\nMin: {min}, Max: {max}, Average: {avg}");

            int sum = numeros.Sum();
            System.Console.WriteLine($"Sum: {sum}");

            IEnumerable<int> distinct = numeros.Distinct();
            System.Console.WriteLine(string.Join(", ", distinct));
        }
    }
}