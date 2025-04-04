// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181863


using System;

public class Solution {
    public string solution(string rny_string) {
        string answer = "";
        
        answer = rny_string.Replace("m", "rn");
        
        return answer;
    }
}