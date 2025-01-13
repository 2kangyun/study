// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120823?language=csharp


using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int n = Int32.Parse(s[0]);
        string txt = "*";
        for (int i = 1; i <= n; i++) {
            Console.WriteLine(txt);
            txt += "*";
        }
    }
}