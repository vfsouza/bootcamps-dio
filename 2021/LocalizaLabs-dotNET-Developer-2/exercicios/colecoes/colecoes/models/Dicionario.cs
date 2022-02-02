namespace colecoes.models {
    public class Dicionario {
        public static void PrintDictionary(Dictionary<int, string> dictionary) {
            System.Console.WriteLine("\nQuantidade de elementos: {0}", dictionary.Count);
            foreach (KeyValuePair<int, string> item in dictionary) {
                System.Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }

        public static void TestDictionary() {
            Dictionary<int, string> nomes = new Dictionary<int, string>();
            
            nomes.Add(0, "Vinicius");
            nomes.Add(1, "Paula");
            nomes.Add(2, "Pedro");

            PrintDictionary(nomes);

            nomes[2] = "Joao";

            System.Console.WriteLine("\nValor da chave 2 atualizado");
            PrintDictionary(nomes);
            
            nomes.Remove(2);
            
            System.Console.WriteLine("\nChave 2 removida");
            PrintDictionary(nomes);
        }
    }
}