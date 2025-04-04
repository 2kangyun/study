// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181854


using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int[] answer = new int[] {};
        int startIndex = arr.Length % 2 == 0 ? 1 : 0;
        
        for(int i = startIndex; i < arr.Length; i += 2) {
            arr[i] += n;
        }
        
        answer = arr;
        
        return answer;
    }
}