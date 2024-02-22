using System;

namespace Fundamentos
{
    class TiposDeDatos
    {
        public static void Main (string[] args)
        {
            sbyte byteConSigno = sbyte.MaxValue;
            byte byteSinSigno = byte.MaxValue;
            short shortConSigno = short.MaxValue;
            ushort ushortConSigno = ushort.MaxValue;
            int intConSigno = int.MaxValue;
            uint uintConSigno = uint.MaxValue;
            long longConSigno = long.MaxValue;
            ulong ulongConSigno = ulong.MaxValue;
            float floatConSigno = float.MaxValue;
            double doubleValor = double.MaxValue;
            decimal decimalValor = decimal.MaxValue;

            Console.WriteLine("MAX[sbyte]: {0}", byteConSigno);
            Console.WriteLine("MAX[byte]: {0}", byteSinSigno);
            Console.WriteLine("Max[short]: {0}", shortConSigno);
            Console.WriteLine("Max[ushort]: {0}", ushortConSigno);
            Console.WriteLine("MAX[int]: {0}", intConSigno);
            Console.WriteLine("MAX[uint]: {0}", uintConSigno);
            Console.WriteLine("MAX[long]: {0}", longConSigno);
            Console.WriteLine("MAX[ulong]: {0}", ulongConSigno);
            Console.WriteLine("MAX[float]: {0}", floatConSigno);
            Console.WriteLine("MAX[double]: {0}", doubleValor);
            Console.WriteLine("MAX[decimal]: {0}", decimalValor);

        }
    }
}



