// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120821


using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length]; // 정답 변수 선언
        
        for (int i = 0; i < num_list.Length; i++) { // 정답 계산
            answer[i] = num_list[num_list.Length - i - 1]; 
        }
        
        return answer; // 정답 반환
    }
}