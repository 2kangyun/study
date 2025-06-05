// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181909


using System;
using System.Linq;

public class Solution {
    public string[] solution(string my_string) {
        string[] answer = new string[] {};
        
        answer = Enumerable.Range(0, my_string.Length).Select(s => my_string.Substring(s)).ToArray();
        
        Array.Sort(answer);
        
        return answer;
    }
}