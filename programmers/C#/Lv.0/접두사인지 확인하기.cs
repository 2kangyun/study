// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181906


using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        int answer = 0;
        
        if (my_string.IndexOf(is_prefix) == 0) {
            answer = 1;
        }
        
        return answer;
    }
}