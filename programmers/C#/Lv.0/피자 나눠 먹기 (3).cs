// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120816


using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 0; // 정답 변수 선언
        
        answer = (int)Math.Ceiling(n / (float)slice);
        
        return answer; // 정답 반환
    }
}