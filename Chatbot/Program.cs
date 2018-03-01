using System;

namespace Aula03
{
    class Chatbot
    {
        static void Main(string[] args)
        {
            string question, response;

            Console.Write("Faz me uma pergunta qualquer!!!");
            question = Console.ReadLine();

           
            switch (question)
            {
                case "Es uma inteligencia artificial?":
                    response = "Mais inteligente que tu.";
                    break;
                case "Como te chamas?":
                    response = "Badjoras 1.0";
                    break;
                case "O que consegues fazer?":
                    response = "Tudo, se me fizeres uma sandes.";
                    break;
                case "Para que serves?":
                    response = "Para quando não tens amigos e queres fazer 1 de 4 perguntas.";
                    break;
                case "EXIT":
                    response = "Hasta la vista baby";
                    break;
                case "exit":
                    response = "Hasta la vista baby";
                    break;
                case "Exit":
                    response = "Hasta la vista baby";
                    break;
                default:
                    response = "Isto assim não dá com nada, instala a versão Badjoras 1.5";
                    break;
                
            }

            Console.WriteLine(response);
        }
    }
}
