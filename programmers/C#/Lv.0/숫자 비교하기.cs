// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120807


using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0; // 결과 저장 변수
        
        answer = num1 == num2 ? 1 : -1; // 값 비교
        
        return answer; // 결과 반환
    }
}