// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120817


using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer = 0; // 정답 변수 선언
        double sum = 0; // 평균 계산을 위한 합계
        
        for (int i = 0; i < numbers.Length; i++) { // 합계 계산
            sum += numbers[i];
        }
        answer = sum / numbers.Length; // 평균 계산
        
        return answer; // 정답 반환
    }
}