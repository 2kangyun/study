// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120819


using System;

public class Solution {
    public int[] solution(int money) {
        int[] answer = new int[2]; // 정답 변수 선언
        
        answer[0] = money / 5500; // 아이스 아메리카노 잔 수
        answer[1] = money % 5500; // 남는 돈
        
        
        return answer; // 정답 반환
    }
}