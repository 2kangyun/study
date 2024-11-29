// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120830


using System;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0; // 정답 변수 선언
        
        answer = n * 12000 + (k - n / 10) * 2000; // 정답 계산
        
        return answer; // 정답 반환
    }
}