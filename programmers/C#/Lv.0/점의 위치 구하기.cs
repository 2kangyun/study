// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120841?language=csharp


using System;

public class Solution {
    public int solution(int[] dot) {
        int answer = 0; // 정답 변수 선언
        
        
        if (dot[0] < 0) { // 2 or 3 사분면
            if (dot[1] > 0) { 
                answer = 2;
            }
            else {
                answer = 3;
            }
        }
        else { // 1 or 4 사분면
            if (dot[1] > 0) {
                answer = 1;
            }
            else {
                answer = 4;
            }
        }
        
        return answer; // 정답 반환
    }
}