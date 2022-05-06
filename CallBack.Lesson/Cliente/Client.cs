using CallBack.Lesson.Banca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBack.Lesson.Cliente
{
    public class ClientBancaLocale : IClienteBancaLocale, IUtenteBancaEstera
    {
        int saldo = 1000;

        BancaLocale bancaLocale = new BancaLocale();
        BancaEstera bancaUK = new BancaEstera();
        TaskCompletedCallBack taskCompletedCallBack;


        public ClientBancaLocale()
        {
            taskCompletedCallBack = FeedBack;
        }
       
        // funzionalità di IClienteBancaLocale
        public void ShowFiscalData() { }
        public void PagaBolPostale() { }
        public void PagaBolloAuto() { }

        // funzionalità di IClienteBanca
        public void FeedBack(string message)
        {
            Console.WriteLine(message);
            
        }
        public void Preleva(int amount)
        {
            bancaLocale.Preleva(amount, this);
        }

        // funzionalità di Banca Estera
        public void PrelevaEstero(int amount)
        {
            bancaUK.Withdraw(amount, taskCompletedCallBack);
        }
       
    }
}
