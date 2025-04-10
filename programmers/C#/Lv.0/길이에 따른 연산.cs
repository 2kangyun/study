// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181879


using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        
        answer = num_list.Length >= 11 ? num_list.Sum() : num_list.Aggregate((acc, x) => acc * x);
        
        return answer;
    }
}