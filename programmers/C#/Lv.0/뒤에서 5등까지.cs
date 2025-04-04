// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181853


using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[5];
        
        Array.Sort(num_list); //오름차순 정렬
        
        answer = num_list.Take(5).ToArray();
        
        return answer;
    }
}