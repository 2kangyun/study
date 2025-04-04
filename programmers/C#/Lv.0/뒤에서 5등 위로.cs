// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181852


using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[] {};
        
        Array.Sort(num_list); // 오름차순으로 정렬
        
        answer = num_list.Skip(5).ToArray(); 
        
        return answer;
    }
}