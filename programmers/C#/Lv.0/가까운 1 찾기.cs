// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181898?language=csharp


using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr, int idx) {
        int answer = 0;
        
        answer = Array.FindIndex(arr, idx, x => x == 1);
        
        return answer;
    }
}