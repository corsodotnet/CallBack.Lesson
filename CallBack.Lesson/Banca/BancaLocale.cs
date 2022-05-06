using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallBack.Lesson.Cliente;

namespace CallBack.Lesson.Banca
{
    public class BancaLocale
    {
        public void Preleva(int amount, IClienteBancaLocale cliente)
        {
            cliente.FeedBack($"Ciao {cliente.GetType().Name}, Perlievo di {amount} eseguito!" );
        }
    }
}
