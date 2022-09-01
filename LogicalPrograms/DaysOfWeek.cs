using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class DaysOfWeek
    {
        public static void Days()
        {
            bool day1 = true;

            while (day1)
            {
                Console.WriteLine("Enter Month");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Day");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Year");
                int y = Convert.ToInt32(Console.ReadLine());

                int y0 = y - (14 - m) / 12;
                int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                int m0 = m + 12 * ((14 - m) / 12) - 2;
                int d0 = (d + x + 31 * m0 / 12) % 7;
                bool c = 0 <= d0 && d0 <= 6;
                string b = "";
                if (c)
                {
                    b = "Sunday";
                }
                else
                {
                    if (c)
                    {
                        b = "monday";
                    }
                    else
                    {
                        if (c)
                        {
                            b = "Tueseday";
                        }
                        else
                        {
                            if (c)
                            {
                                b = "Wednesday";
                            }
                            else
                            {
                                if (c)
                                {
                                    b = "Thursday";
                                }
                                else
                                {
                                    if (c)
                                    {
                                        b = "Friday";
                                    }
                                    else
                                    {
                                        if (c)
                                        {
                                            b = "saturday";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                Console.WriteLine("The day of week is " + b);

            }
        }
    }
}
