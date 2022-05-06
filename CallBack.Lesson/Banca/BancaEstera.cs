using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallBack.Lesson.Cliente;

namespace CallBack.Lesson.Banca
{
    public class BancaEstera
    {  
        public void Withdraw(int importo, TaskCompletedCallBack utente)
        {
            utente($"Ciao {utente.GetType().Name}, Prelievo di {importo} presso banca UK eseguito! ");
        } 
    }
}
