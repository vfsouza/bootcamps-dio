using System;
using arquivo.models;

namespace arquivo {
   class Program {
      public static void Main(string[] args) {
         string caminho = "C:\\Users\\vinif\\Documents\\Projetos\\bootcamps-dio\\2021\\LocalizaLabs-dotNET-Developer-2\\exercicios\\arquivo\\arquivo\\arquivos_texto\\";
         List<string> lista = new List<string> {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
         Console.WriteLine("\n\n\n\nSelecione uma das seguintes opções:");
         Console.WriteLine("1. Listar diretorios.\n2. Listar arquivos.\n3. Criar diretorio.\n4. Apagar diretorio.\n5. Criar arquivo txt.\n6. Criar arquivo txt com stream.");
         Console.WriteLine("7. Editar arquivo existente.\n8. Ler arquivo.\n9. Mover arquivo.\n10. Copiar arquivo.\n11. Deletar arquivo.");
         Console.Write(": ");

         int op = int.Parse(Console.ReadLine());
         System.Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");

         switch (op)
         {
            case 1:
               Arquivos.listarDiretorios(caminho);
               break;

            case 2:
               Arquivos.listarArquivos(caminho);
               break;

            case 3: 
               Arquivos.criarDiretorio(Path.Combine(caminho, "teste3", "subpasta_teste3"));
               break;

            case 4: 
               Arquivos.apagarDiretorio(Path.Combine(caminho, "teste3"));
               break;

            case 5: 
               Arquivos.criarTxt(Path.Combine(caminho, "teste.txt"), "Vinicius é lindo demais c ta doido");
               break;

            case 6: 
               Arquivos.criarTxtStream(Path.Combine(caminho, "teste1.txt"), lista);
               break;

            case 7: 
               Arquivos.addTxt(Path.Combine(caminho, "teste.txt"), "Vinicius é lindo demais c ta doido");
               Arquivos.addTxtStream(Path.Combine(caminho, "teste1.txt"), "Vinicius é lindo demais c ta doido");
               break;

            case 8: 

               break;

            case 9: 

               break;

            case 10: 

               break;

            case 11:

               break;
            
            default:
               Console.WriteLine("Opção inexistente!");
               break;
         }
      }
   }
}