using System;
using System.Collections;
using System.Collections.Generic;

class Test
{
    static void Main(string[] args)
    {
         fgCSVReader.LoadFromFile("sample.csv", new fgCSVReader.ReadLineDelegate(ReadLineTest));
    }

    static void ReadLineTest(int line_index, List<string> line)
    {
        Console.Out.WriteLine("\n==> Line {0}, {1} column(s)", line_index, line.Count);
        for (int i = 0; i < line.Count; i++)
        {
            Console.Out.WriteLine("Cell {0}: *{1}*", i, line[i]);
        }
    }
}
