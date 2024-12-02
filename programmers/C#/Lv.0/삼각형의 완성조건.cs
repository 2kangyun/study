// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120889


using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0; // 결과 저장 변수
        
        Array.Sort(sides); // 배열 정렬
        answer = sides[0] + sides[1] > sides[2] ? 1 : 2; // 결과 계산
        
        return answer; // 결과 반환
    }
}