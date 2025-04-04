// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181856


using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = 0;
        
        // 길이 비교
        answer = arr1.Length > arr2.Length ? 1 : -1;
        
        // 합 비교
        if (arr1.Length == arr2.Length) {
            answer = arr1.Sum() > arr2.Sum() ? 1 : arr2.Sum() > arr1.Sum() ? -1 : 0;
            
        }
        
        return answer;
    }
}