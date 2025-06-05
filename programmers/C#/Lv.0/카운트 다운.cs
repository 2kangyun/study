// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181899


using System;
using System.Linq;

public class Solution {
    public int[] solution(int start_num, int end_num) {
        int[] answer = new int[] {};
        
        answer = Enumerable.Range(end_num, start_num - end_num + 1).Reverse().ToArray();
        
        return answer;
    }
}