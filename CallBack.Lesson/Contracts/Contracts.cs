using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBack.Lesson
{
    public delegate void TaskCompletedCallBack(string taskResult);

    public interface IClienteBanca
    {
        void Preleva(int amount);
        void FeedBack(string message);
    }
    public interface IClienteBancaLocale : IClienteBanca
    {
        void ShowFiscalData();
        void PagaBolPostale();
        void PagaBolloAuto();
    }
    public interface IUtenteBancaEstera : IClienteBanca
    {      

    }

}
