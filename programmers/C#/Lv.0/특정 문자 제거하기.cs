// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120826


using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = ""; // 정답 변수 선언
        
        answer = my_string.Replace(letter, "");
        
        return answer; // 정답 반환
    }
}