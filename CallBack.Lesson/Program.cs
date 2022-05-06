using CallBack.Lesson.Cliente;
using System;

namespace CallBack.Lesson
{
    internal class Program
    {          
        static void Main( string[] args)
        {

            ClientBancaLocale clientBancaLocale = new ClientBancaLocale();
            clientBancaLocale.Preleva(100);
            clientBancaLocale.PrelevaEstero(100);
        }
       
    }
}
