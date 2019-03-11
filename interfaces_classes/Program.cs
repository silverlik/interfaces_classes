using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_classes
{      interface IUndo
        {
            void WriteName();
        };
    public class TextBox : IUndo
    {
        public virtual void  WriteName()
        {
            Console.WriteLine("TextBox: WriteName");
        }
        
    };
    public class RichTextBox : TextBox,IUndo
    {
        public  new void  WriteName()
        {
            Console.WriteLine("RichTextBox: WriteName");
        }
    };
    class Program
    {
       
        static void Main(string[] args)
        {
            RichTextBox r = new RichTextBox();
            r.WriteName();
            ((IUndo)r).WriteName();
            ((TextBox)r).WriteName();
            TextBox t = new TextBox();
            t.WriteName();
            Console.ReadKey();
        }
    }
}
