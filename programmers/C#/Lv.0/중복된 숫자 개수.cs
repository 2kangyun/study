// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120583


using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0; // 결과 저장 변수
        
        foreach (int i in array) { // 결과 계산
            if (i == n) {
                answer++;
            }
        }
        
        return answer; // 결과 반환
    }
}