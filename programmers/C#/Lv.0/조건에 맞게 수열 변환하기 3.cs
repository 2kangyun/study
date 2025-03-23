// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181835


using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int k) {
        int[] answer = new int[] {}; // 정답 변수 선언
        
        if (k % 2 == 0) { // 짝수일 때
            answer = arr.Select(x => x + k).ToArray();
        }
        else { // 홀수일 때
            answer = arr.Select(x => x * k).ToArray();
        }
        
        return answer; // 정답 반환
    }
}