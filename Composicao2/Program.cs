using System;
using Composicao2.Entidades;

namespace Composicao2 {
    class Program {
        static void Main(string[] args) {

            Comentario c1 = new Comentario("Tenha uma boa viagem!!");
            Comentario c2 = new Comentario("Uau, que legal!!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Viajando para a Nova Zelandia",
                "Estou visitando esse maravilhoso pais!",
                12);

            p1.AddComentario(c1);
            p1.AddComentario(c2);

            Comentario c3 = new Comentario("Boa noite!!");
            Comentario c4 = new Comentario("Que a forca esteja com voce!!");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Boa noite pessoal",
                "Te vejo amanha!",
                12);

            p2.AddComentario(c3);
            p2.AddComentario(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
