using System;

namespace LSPLibrary
{
    public class Alert
    {
        /*
            Este método no cumple con el polimorfismo porque tiene un bloque de código dedicado a cada valor del parámetro type
        
            Para cumplir con esto, podría recibir en lugar del string type, un tipo, por ejemplo IAlertSender. Y tendríamos 2
            implementaciones de ese tipo: 
            
            TrelloAlertSender: Encargado de publicar la alerta en trello
            ConsoleAlertSender: Encargado de mostrar la alerta por consola
        */ 
        public void Send(string type, string text)
        {
            if (type == "trello")
            {
                new TrelloCardCreator().CreateCard(text);
            }
            else if (type == "text") 
            {
                Console.WriteLine(text);
            }
        }
    }
}