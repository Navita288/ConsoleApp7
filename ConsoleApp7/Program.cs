using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        namespace DelegatesAndEvents
{
    // Navita Navita c0730283
    //Gagan Sidhu c0731555
    //CSD3354 Section 2
    //date 06 march 2019
    public delegate void MyDelegate();

    public class DelegateExercises
    {
        void Method3()
        {
            System.Console.WriteLine(MyDelegate.ToString());
        }
    }
    