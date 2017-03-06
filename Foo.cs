using System;

namespace Multitarget
{
    public class Foo
    {
#if DESKTOP
        public static void Test()
        {
            Console.WriteLine(new Bar());
        }
#endif
    }
}
