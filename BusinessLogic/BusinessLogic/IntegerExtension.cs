using System;

[assembly: CLSCompliant(true)]
namespace BusinessLogic
{
    public static class IntegerExtension
    {
        public static int Add(this int i, int add) => i + add;
    }
}
