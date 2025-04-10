// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181885


using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        string[] answer = new string[] {};
        
        
        answer = todo_list.Where((x, i) => !finished[i]).ToArray();
        
        return answer;
    }
}