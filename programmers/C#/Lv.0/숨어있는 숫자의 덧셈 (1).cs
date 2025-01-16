// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120851


using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0; // 정답 변수 선언
        int temp = 0; // 임시 변수
        
        foreach(char ch in my_string) {
            answer += int.TryParse(ch.ToString(), out temp) ? temp : 0; // 자연수이면 덧셈
        }
        
        return answer; // 정답 반환
    }
}