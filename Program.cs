/*
ver: 1.3 date: 2021.04.07
autor: Mikhail625@protonmail.com
*/

using System;
using System.Globalization;

namespace Lesson_02
{
    class Programm
    {
        static void Main(string[] args)
        {
            {// Task №1 calculate avg temperature
                // block declare init vars
                string tmpStr;
                float fTmprtrMax; // temparature max
                float fTmprtrMin; // temparature min
                float  fTmprtrAvg; // temparature avg
                double dTmprtrAvg; // temparature avg

                Console.WriteLine("Run Task 1 Lesson2");
                Console.Write("What is MIN temparature? (centigrade? exmple -12.34):");
                tmpStr = Console.ReadLine();
                if (tmpStr == "")
                    { tmpStr = "-0.25"; }
                fTmprtrMin = float.Parse((tmpStr), CultureInfo.InvariantCulture.NumberFormat);

                Console.Write("What is MAX temparature? (centigrade? exmple 20.05):");
                tmpStr = Console.ReadLine();
                if (tmpStr == "")
                    { tmpStr = "17.25"; }
                fTmprtrMax = float.Parse(tmpStr, CultureInfo.InvariantCulture.NumberFormat);
                fTmprtrAvg = ((fTmprtrMin + fTmprtrMax)/2.00F);
                Console.WriteLine($" Average temperature: {fTmprtrAvg} ");
                Console.WriteLine(" ...........    end of  Task №1 calculate avg temperature");
                //Console.Clear();

            }//   end of  Task №1 calculate avg temperature

            { // Task №2 get name month
                {
                    Console.WriteLine ("Run Task 2 Lesson2");
                    // block declare init vars
                    string[] arrMonth = { "Что-то пошло не так. Попробуйте проверить."
                                              ,"Январь"
                                              ,"Февраль"
                                              ,"Март"
                                              ,"Апрель"
                                              ,"Май"
                                              ,"Июнь"
                                              ,"Июль"
                                              ,"Август"
                                              ,"Сентябрь"
                                              ,"Октябрь"
                                              ,"Ноябрь"
                                              ,"Декабрь"
                                             };
                    string strInput;
                    int numberMonth;
                    Console.Write("Enter number month:");
                    strInput = Console.ReadLine();
                    if (strInput == "")
                    {
                        numberMonth = 0;
                    }
                    else
                    {
                        numberMonth = Convert.ToInt32(strInput);
                    }

                    if (numberMonth < 0 | numberMonth > 12)
                    {
                        numberMonth = 0;
                    }

                    Console.WriteLine("        name {0} month:" + arrMonth[numberMonth], numberMonth);
                    Console.WriteLine(" ...........    end of  Task №2 get name month");
                    //Console.Clear();

                }

            }// end of  Task №2 get name month


            { // Task № 3 this number even or odd?
                Console.WriteLine("Run Task 3 Lesson2   Even or Odd ");
                string strInput = "";
                float number2;

                Console.Write("Enter any number:");

                strInput = Console.ReadLine();

                if (strInput  == "")
                {
                    number2 = 2;
                }
                else
                {
                //int number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToSingle(strInput);
                }

                if ((number2 % 2) == 0)
                {
                    Console.WriteLine(" Число {0} - чёт (even)", number2);
                }
                else
                {
                    Console.WriteLine(" Число {0} - НЕчёт (odd)" , number2);
                }

                Console.WriteLine(" ...........    Task № 3 this number even or odd?");
                //Console.Clear();

            }// end of  Task № 3


            { // Task № 4 output check
                Console.WriteLine("Run Task № 4 output check");
                // Init var block
                int iPos1 = 0; int iPos2 = 0;
                string str01 = "  планета:"; string str06 = " Татуин";
                string str02 = "космопорт:"; string str07 = " Мос-Эйсли";
                string str03 = " продавец:"; string str08 = " R2-D2";
                string str04 = "    товар:"; string str09 = " топливо";
                string str05 = "     цена:"; string str10 = " 101.25";
                // надо бы проверку на длинну строки и\или ширины чека, но , увы, время поджимает
                string str16 = str01 + str06;
                string str17 = str02 + str07;
                string str18 = str03 + str08;
                string str19 = str04 + str09;
                string str20 = str05 + str10;

                //разметка столбцов:           |- 00 -|  |- 01 -|  |- 02 -|  |- 03 -|  |- 04 -|  |- 05 -|  |- 06 -|  |- 07 -|  |- 08 -|  |- 09 -|  |- 10 -|  |- 11 -|  |- 12 -|  |- 13 -|  |- 14 -|  |- 15 -|  |- 16 -|  |- 17 -|  |- 18 -|  |- 19 -|  |- 20 -|  |- 21 -|  |- 22 -|  |- 23 -|  |- 24 -|  |- 25 -|  |- 26 -|  |- 27 -|  |- 28 -|  |- 29 -| ;
                char[] cLine010 = new char[] { '\u2554', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2557' };
                char[] cLine011 = new char[] { '\u2551', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u2551' };
                char[] cLine012 = new char[] { '\u255F', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u2562' };
                char[] cLine013 = new char[] { '\u2551', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2500', '\u2551' };
                char[] cLine014 = new char[] { '\u2551', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u2551' };
                char[] cLine015 = new char[] { '\u2551', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u2551' };
                char[] cLine016 = new char[] { '\u2551', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u2551' };
                char[] cLine017 = new char[] { '\u2551', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u0020', '\u2551' };
                char[] cLine018 = new char[] { '\u255A', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u2550', '\u255D' };

                char[] cText = new char[str16.Length];
                cText = str16.ToCharArray();
                iPos2 = 0;
                for (iPos1 = 2; iPos1 <= (1 + str16.Length); iPos1++)
                {
                    cLine011[iPos1] = cText[iPos2];
                    iPos2++;
                }

                // обнуление переменных . Здесь бы надо функцию, но  времени уж нет :(
                iPos2 = 0;
                Array.Resize(ref cText, 1);
                Array.Resize(ref cText, str17.Length);
                cText = str17.ToCharArray();
                for (iPos1 = 2; iPos1 <= (1 + str17.Length); iPos1++)
                {
                    cLine012[iPos1] = cText[iPos2];
                    iPos2++;
                }

                // обнуление переменных
                iPos2 = 0;
                Array.Resize(ref cText, 1);
                Array.Resize(ref cText, str18.Length);
                cText = str18.ToCharArray();
                for (iPos1 = 2; iPos1 <= (1 + str18.Length); iPos1++)
                {
                    cLine015[iPos1] = cText[iPos2];
                    iPos2++;
                }

                // обнуление переменных
                iPos2 = 0;
                Array.Resize(ref cText, 1);
                Array.Resize(ref cText, str19.Length);
                cText = str19.ToCharArray();
                for (iPos1 = 2; iPos1 <= (1 + str19.Length); iPos1++)
                {
                    cLine016[iPos1] = cText[iPos2];
                    iPos2++;
                }

                // обнуление переменных
                iPos2 = 0;
                Array.Resize(ref cText, 1);
                Array.Resize(ref cText, str20.Length);
                cText = str20.ToCharArray();
                for (iPos1 = 2; iPos1 <= (1 + str20.Length); iPos1++)
                {
                    cLine017[iPos1] = cText[iPos2];
                    iPos2++;
                }
                // вывод.отрисовка рамка + текст
                Console.WriteLine(string.Join("", cLine010));
                Console.WriteLine(string.Join("", cLine011));
                Console.WriteLine(string.Join("", cLine012));
                Console.WriteLine(string.Join("", cLine013));
                Console.WriteLine(string.Join("", cLine014));
                Console.WriteLine(string.Join("", cLine015));
                Console.WriteLine(string.Join("", cLine016));
                Console.WriteLine(string.Join("", cLine017));
                Console.WriteLine(string.Join("", cLine018));

                Console.WriteLine(" .....................end of  Task №  4 output check  ");
            }// end of  Task №  4 output check

        }
    }

}
