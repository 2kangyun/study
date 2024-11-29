// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120829#


using System;

public class Solution {
    public int solution(int angle) {
        int answer = 0; // 결과 저장 변수
        
        answer = angle < 90 ? 1 : angle == 90 ? 2 : angle < 180 ? 3 : 4; // 결과 계산
        
        return answer; // 결과 반환
    }
}