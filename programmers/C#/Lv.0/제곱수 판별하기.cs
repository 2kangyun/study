// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120909


using System;

public class Solution {
    public int solution(int n) {
        int answer = 0; // 정답 변수 선언
        
        answer = Math.Sqrt(n) % 1 == 0 ? 1 : 2;
        
        return answer; // 정답 반환
    }
}