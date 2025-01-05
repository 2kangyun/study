// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120906


using System;

public class Solution {
    public int solution(int n) {
        int answer = 0; // 정답 변수 선언
        
        for (; n != 0; n /= 10) { // 계산
            answer += n % 10;
        }
        
        return answer; // 정답 반환
    }
}