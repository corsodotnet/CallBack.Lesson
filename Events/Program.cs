using System;

namespace Events
{
    #region EVENTS
    //delegate void MoveEventHandler(object source, MoveEventArgs e);
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Slider slider = new Slider();
    //        // register with the Move event
    //        slider.Move += new MoveEventHandler(slider_Move);
    //        slider.Position = 20;
    //        slider.Position = 60;
    //    }
    //    static void slider_Move(object source, MoveEventArgs e)
    //    {
    //        if (e.newPosition < 50)
    //            Console.WriteLine("OK");
    //        else
    //        {
    //            e.cancel = true;
    //            Console.WriteLine("Can't go that high!");
    //        }
    //    }

    //}
    //public class MoveEventArgs : EventArgs
    //{
    //    public int newPosition;
    //    public bool cancel;
    //    public MoveEventArgs(int newPosition)
    //    {
    //        this.newPosition = newPosition;
    //    }
    //}
    //class Slider
    //{
    //    int position;
    //    public event MoveEventHandler Move;       
    //    public int Position
    //    {
    //        get { return position; }
    //        set
    //        {
    //            if (position != value) // if position changed
    //            { 

    //                if (Move != null) // if delatete is not null 
    //                { 

    //                    MoveEventArgs args = new MoveEventArgs(value);
    //                    Move(this, args); // fire event

    //                    if (args.cancel)// Exit and let the old value
    //                        return;
    //                }
    //                position = value;// Let's set the new value
    //            }

    //        }

    //    }
    //}
    #endregion

    #region  Multicast Delegates 
    internal class Program
    {

        delegate void MyMethodInvoker();
        internal static void Main(string[] args)
        {
            new Test().Trigger(); // prints "Foo", "Goo"
        }
        class Test
        {
            MyMethodInvoker m = null;
            internal Test()
            {
               
                //m += new MethodInvoker(Foo);
                //m += new MethodInvoker(Goo);
            }
            void Foo()
            {
                Console.WriteLine("Foo"); 

            }
            void Goo()
            {
                Console.WriteLine("Goo");
            }
            internal void Trigger()
            {
                try
                {
                    m();
                }
                catch 
                {
                    throw new MyMethodInvokerException("Il mio delegate non funziona!");
                }
            }

        }
        class MyMethodInvokerException : Exception
        {
             public MyMethodInvokerException(string msg ):base(msg){ }    
        }
        #endregion

    }
}

