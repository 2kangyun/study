// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120824


using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[2]; // 결과 변수 선언
        
        foreach (int i in num_list) {
            if (i % 2 == 0) { // 짝수일 때
                answer[0]++;
            }
            else { // 홀수일 때
                answer[1]++;
            }
        }
        
        return answer; // 결과 반환
    }
}