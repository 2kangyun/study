// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181895


using System;

public class Solution {
    public int[] solution(int[] arr, int[,] intervals) {
        int size1 = intervals[0,1] - intervals[0,0] + 1; // 첫 번째 구간 길이
        int size2 = intervals[1,1] - intervals[1,0] + 1; // 두 번재 구간 길이
        int[] answer = new int[size1 + size2];
        
        Array.Copy(arr, intervals[0,0], answer, 0, size1); // 첫 구간 복사
        Array.Copy(arr, intervals[1,0], answer, size1, size2); // 두 번째 구간 복사
        
        return answer;
    }
}