﻿using System;

namespace Project_OOP.TicTacToe
{
    public static class TicTacToeAdditions
    {
        public static char ChooseSign()
        {
            char sign = '\0';
            while (true)
            {
                Console.Write("Choose cross ( 'X' )  or  toe ( '0' ) --> ");
                try
                {
                    sign = Convert.ToChar(Console.ReadLine() ?? throw new InvalidOperationException());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.ToString());
                }

                if (sign == '0' || sign == 'X') break;
                Console.WriteLine("You can choose cross ( 'X' )  or  toe ( '0' ) only");
            }
            return sign;
        }

        public static char OppositeSign(char c)
        {
            return c is '0' ? 'X' : '0';
        }

        public static bool ChooseOrder()
        {
            int order = 0;
            while (true)
            {
                Console.Write("Choose order (type 1 or 2) --> ");
                try
                {
                    order = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You can type only 1 or 2");
                    Console.WriteLine(e.ToString());
                }
                if (order == 1 || order == 2) break;
                Console.WriteLine("Choose number 1 or 2");
            }
            return order == 1;
        }
        public static int CheckPosition(char[] row, char c)
        {
            int position = -1, count = 0, savePos = 0;
            for (int i = 0; i < row.GetLength(0); i++)
            {
                if (row[i] == c) count++;
                else savePos = i;
            }

            if (count == 2 && row[savePos] == ' ') return savePos + 1;

            return position;
        }
    }
}