using System.IO;

namespace arquivo.models
{
    public static class Arquivos
    {
        public static void listarDiretorios(string caminho) {
            string[] aux = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            for(int i = 0; i < aux.Length; i++) {
                aux[i] = aux[i].Replace(caminho, "");
                System.Console.WriteLine(aux[i]);
            }
        }

        public static void listarArquivos(string caminho) {
            string[] aux = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            for(int i = 0; i < aux.Length; i++) {
                aux[i] = aux[i].Replace(caminho, "");
                System.Console.WriteLine(aux[i]);
            }
        }

        public static void criarDiretorio(string caminho) {
            DirectoryInfo aux = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(aux.FullName);
        }

        public static void apagarDiretorio(string caminho) {
            try {
                Directory.Delete(caminho);
                System.Console.WriteLine($"Diretorio {caminho} deletado com sucesso!");
            } catch (Exception) {
                System.Console.WriteLine("Diretorio não pode ser apagado por não estar vazio. Deseja deletar mesmo assim? (S/N)");
                string resp = System.Console.ReadLine();
                if (resp == "S") {
                    Directory.Delete(caminho, true);
                    System.Console.WriteLine($"Diretorio {caminho} deletado com sucesso!");
                } else {
                    System.Console.WriteLine("Encerrando...");
                }
            }
        }

        public static void criarTxt(string caminho, string conteudo) {
            File.WriteAllText(caminho, conteudo);
        }

        public static void criarTxtStream(string caminho, List<string> conteudo) {
            StreamWriter txt = File.CreateText(caminho);

            foreach (string i in conteudo) {
                txt.WriteLine(i);
            }

            txt.Close();
        }

        public static void addTxt(string caminho, string conteudo) {
            File.AppendAllText(caminho, conteudo);
        }

        public static void addTxtStream(string caminho, string conteudo) {
            StreamWriter txt = File.AppendText(caminho);

            txt.Write(conteudo);

            txt.Close();
        }

        public static void lerTxt(string caminho) {
            string[] str = File.ReadAllLines(caminho);

            foreach (string linha in str) {
                System.Console.WriteLine(linha);
            }
        }

        public static void lerTxtStream(string caminho) {
            string linha = string.Empty;

            using(StreamReader stream = File.OpenText(caminho)) {
                while((linha = stream.ReadLine()) != null) {
                    System.Console.WriteLine(linha);
                }
            }
        }

        public static void moverArq(string caminho, string destino) {
            File.Move(caminho, destino);
        }

        public static void copiarArq(string caminho, string destino) {
            File.Copy(caminho, destino);
        }

        public static void deletarArq(string caminho) {
            File.Delete(caminho);
        }

    }
}