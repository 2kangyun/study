// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120814


using System;

public class Solution {
    public int solution(int n) {
        int answer = 0; // 정답 변수 선언
        
        answer = (int)Math.Ceiling(n / 7.0); // 계산
        
        return answer; // 정답 반환
    }
}