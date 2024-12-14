// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120910?language=csharp


using System;

public class Solution {
    public int solution(int n, int t) {
        int answer = 0; // 결과 저장 변수
        
        answer = n << t; // 결과 계산
        
        return answer; // 결과 반환
    }
}