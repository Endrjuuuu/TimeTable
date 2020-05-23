using System;

namespace TimeTable
{
    public static class TransportEnumExtensions
    {
        public static char GetChar(this TransportEnum transport)
        {
            switch (transport)
            {
                case TransportEnum.CAR: return 'S';
                case TransportEnum.BUS: return 'B';
                case TransportEnum.SUBWAY: return 'S';
                case TransportEnum.BIKE: return 'R';
                case TransportEnum.WALK: return 'P';
                default: throw new Exception("Nieznany środek transportu");
            }
        }

        public static ConsoleColor GetColor(this TransportEnum transport)
        {
            switch (transport)
            {
                case TransportEnum.CAR: return ConsoleColor.Red;
                case TransportEnum.BUS: return ConsoleColor.DarkGreen;
                case TransportEnum.SUBWAY: return ConsoleColor.DarkMagenta;
                case TransportEnum.BIKE: return ConsoleColor.Blue;
                case TransportEnum.WALK: return ConsoleColor.DarkYellow;
                default: throw new Exception("Nieznany środek transportu");
            }
        }
    }
}