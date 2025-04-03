// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181849


using System;

public class Solution {
    public int solution(string num_str) {
        int answer = 0;
        
        foreach(char ch in num_str) {
            answer += ch - '0';
        }
        
        return answer;
    }
}