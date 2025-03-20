// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120845


using System;

public class Solution {
    public int solution(int[] box, int n) {
        int answer = 1; // 정답 변수 선언(곱셈을 위해 1로 선언)
        
        foreach(int i in box) {
            answer *= i / n; // 상자의 길이를 모서리 길이로 나눈 값의 곱
        }
        
        return answer; // 정답 반환
    }
}