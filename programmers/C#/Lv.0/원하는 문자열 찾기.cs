// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181878


using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        
        answer = myString.IndexOf(pat, StringComparison.OrdinalIgnoreCase) >= 0 ? 1 : 0;
        
        return answer;
    }
}