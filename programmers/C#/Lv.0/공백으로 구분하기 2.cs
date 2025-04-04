// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181868


using System;

public class Solution {
    public string[] solution(string my_string) {
        string[] answer = new string[] {};
        
        answer = my_string.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        return answer;
    }
}