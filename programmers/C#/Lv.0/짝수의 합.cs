// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120831


using System;

public class Solution {
    public int solution(int n) {
        int answer = 0; // 정답 변수 선언
        
        for (int i = 0; i <= n; i += 2) { // 결과 계산
            answer += i;
        }
        
        return answer; // 결과 반환
    }
}