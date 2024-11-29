// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120854


using System;

public class Solution {
    public int[] solution(string[] strlist) {
        int[] answer = new int[strlist.Length]; // 정답 변수 선언
        
        for (int i = 0; i < strlist.Length; i++) { // 정답 계산
            answer[i] = strlist[i].Length;
        }
        
        return answer; // 정답 반환
    }
}