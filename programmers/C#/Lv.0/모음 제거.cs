// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120849


using System;

public class Solution {
    public string solution(string my_string) {
        string answer = ""; // 정답 변수 선언
        string vowel = "aeiou"; // 모음 배열
        
        foreach (char c in my_string) { // 정답 계산
            if (!vowel.Contains(c)) {
                answer += c;
            }
        }
            
        return answer; // 정답 반환
    }
}