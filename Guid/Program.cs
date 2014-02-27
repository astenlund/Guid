using System;
using System.Windows.Forms;

namespace Guid
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            var guid = System.Guid.NewGuid().ToString();
            Clipboard.SetText(guid);
            Console.WriteLine(guid);
        }
    }
}
