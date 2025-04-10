// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181882


using System;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[arr.Length];
        
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] >= 50 && arr[i] % 2 == 0) { 
                answer[i] = arr[i] / 2;
            }
            else if (arr[i] < 50 && arr[i] % 2 == 1) {
                answer[i] = arr[i] * 2;
            }
            else {
                answer[i] = arr[i]; // 조건에 해당 안 하는 경우
            }
            
        }
        
        
        return answer;
    }
}