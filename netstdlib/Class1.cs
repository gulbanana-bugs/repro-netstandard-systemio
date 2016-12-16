using System.Diagnostics;
using System.IO;

namespace netstdlib
{
    public class Class1
    {
        public Class1()
        {
            using (var f = File.OpenRead("C:\\Windows\\win.ini"))
            {
                using (var r = new StreamReader(f))
                {
                    Debug.WriteLine(r.ReadToEnd());
                }
            }
        }
    }
}
