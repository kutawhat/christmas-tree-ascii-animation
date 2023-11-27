﻿using System.Threading;
using System.Text;
using System.IO;
using System;

namespace christmas_tree
{
    internal class Program
    {
        static ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
        

        public static void PrintTreeAnimatedDemo1(string tree)
        {
            while (1 == 1)
            {
                Thread.Sleep(1200);

                for (int i = 0; i < tree.Length; i++)
                {
                    if (tree[i] == '*')
                    {
                        Console.ForegroundColor = colors[8];
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == 'o')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == Convert.ToChar(39))
                    {
                        Console.ForegroundColor = colors[14];
                        Console.Write(tree[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = colors[8];
                        Console.Write(tree[i]);
                    }
                }

                Thread.Sleep(1200);
                
                for (int i = 0; i < tree.Length; i++)
                {
                    if (tree[i] == '*')
                    {
                        Console.ForegroundColor = colors[4];
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == 'o')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == Convert.ToChar(39))
                    {
                        Console.ForegroundColor = colors[7];
                        Console.Write(tree[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = colors[8];
                        Console.Write(tree[i]);
                    }
                }
            }
        }
        
        public static void PrintTreeAnimatedDemo2(string tree)
        {
            while (1 == 1)
            {
                Thread.Sleep(700);

                for (int i = 0; i < tree.Length; i++)
                {
                    if (tree[i] == '*')
                    {
                        Console.ForegroundColor = colors[8];
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == 'o')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == '&')
                    {
                        Console.ForegroundColor = colors[14];
                        Console.Write(tree[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = colors[8];
                        Console.Write(tree[i]);
                    }
                }

                Thread.Sleep(700);
                
                for (int i = 0; i < tree.Length; i++)
                {
                    if (tree[i] == '*')
                    {
                        Console.ForegroundColor = colors[4];
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == 'o')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == '&')
                    {
                        Console.ForegroundColor = colors[8];
                        Console.Write(tree[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = colors[8];
                        Console.Write(tree[i]);
                    }
                }
            }
        }
        public static void PrintTreeAnimated(string tree)
        {
            while (!Console.KeyAvailable)
            {
                Thread.Sleep(700);

                for (int i = 0; i < tree.Length; i++)
                {
                    if (tree[i] == '*')
                    {
                        Console.ForegroundColor = colors[8];
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == '"')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == 'o')
                    {
                        Console.ForegroundColor = colors[4];
                        Console.Write(tree[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = colors[7];
                        Console.Write(tree[i]);
                    }
                }

                Thread.Sleep(700);
                
                for (int i = 0; i < tree.Length; i++)
                {
                    if (tree[i] == '*')
                    {
                        Console.ForegroundColor = colors[14];
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == '"')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == 'o')
                    {
                        Console.ForegroundColor = colors[8];
                        Console.Write(tree[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = colors[7];
                        Console.Write(tree[i]);
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            string path = "/Users/ku/Documents/coding/archive/csh/christmas_tree/tree.txt";
            string tree = File.ReadAllText(path);

            PrintTreeAnimated(tree);
        }
    }
}