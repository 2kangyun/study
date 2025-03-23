// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181839


using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0; // 정답 변수 선언
        
        if (a % 2 == 1 && b % 2 == 1) { // 모두 홀수
            answer = a * a + b * b;
        }
        else if (a % 2 == 1 || b % 2 == 1) { // 하나만 홀수
            answer = (a + b) * 2;
        }
        else { // 모두 짝수
            answer = Math.Abs(a - b); // 절댓값
        }
        
        return answer; // 정답 반환
    }
}