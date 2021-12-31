# Namespace
- Usados para organização de classes
- Para acessar outros namespaces usamos `using (nome do namespace)` ou colocarmos o namespace antes de chamarmos uma classe desse namespace, `System.Console.Readline()`

      namespace Namespace {
         class Class {
            public void Method() {
               // ...
            }
         }
      }

#

# Classes
Uma classe é um projeto, uma blueprint para se criar um objeto. Ela possui **atributos** e **métodos**, que são, respectivamente, características daquele objeto e ações que ele pode fazer. Um exemplo disso é uma pessoa. A pessoas possui atributos, como idade, nome e altura, e métodos, como andar, correr e falar.

      class Class {
         public string Atributo;

         public void Metodo() {
            // ...
         }
      }
#

# Interface
É um molde para as classes que a tiverem seguir. A classe deve implementar todos os métodos da interface.

      interface Interface {
         void Metodo();
      }

#

# Enum
É um grupo de constantes enumeradas s partir do 0 e aumentado de 1 em 1.

      enum Enum {
         Valor1, // index 0
         Valor2, // index 1
         Valor3  // index 2
      }