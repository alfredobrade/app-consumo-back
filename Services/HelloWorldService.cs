using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_consumo.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        public string GetHelloWorld()
        {
            return "Hello World!";
        }

     
    }
    

    public interface IHelloWorldService
    {
        string GetHelloWorld();
    }
    /* dice que crea un tipo de dato abstracto que mas adelante nos va
    a ayudar a inyectar mas facilmente las dependencias.
    
    dice que en la interfaz expone los metodos de la clase

    */
}