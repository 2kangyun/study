// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181842


using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 0; // 정답 변수 선언
        
        answer = str2.Contains(str1) ? 1 : 0; // 부분 문자열이면 1 아니면 0
        
        return answer; // 정답 반환
    }
}