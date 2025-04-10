// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181891


using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length];
        
        
        Array.Copy(num_list, n, answer, 0, num_list.Length - n); // n 번째 이후 원소
        Array.Copy(num_list, 0, answer, num_list.Length - n, n); // n 번째 까지
        
        return answer;
    }
}