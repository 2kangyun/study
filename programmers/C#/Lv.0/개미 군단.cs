// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120837


using System;

public class Solution {
    public int solution(int hp) {
        int answer = 0; // 정답 변수 선언
        int attack = 5; // 공격력
        
        while (hp > 0) {
            answer += hp / attack;
            hp = hp % attack;
            attack -= 2;
        }
        
        
        return answer; // 정답 반환
    }
}