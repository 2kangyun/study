// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181887


using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        
        int[] odd = num_list.Where((x, i) => i % 2 == 1).ToArray(); 
        int[] even = num_list.Where((x, i) => i % 2 == 0).ToArray(); 
        int oddSum = odd.Sum();
        int evenSum = even.Sum();
        
        answer = oddSum > evenSum ? oddSum : evenSum; // 합 크기 비교
        
        return answer;
    }
}