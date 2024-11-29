// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120806


using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0; // 결과 저장 변수
        
        answer = (int) ((float) num1 / num2 * 1000); // 나누기 계산
        
        return answer; // 결과 반환
    }
}