// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181886


using System;

public class Solution {
    public string[] solution(string[] names) {
        
        int answerLength = names.Length % 5 == 0 ? names.Length / 5 : names.Length / 5 + 1;
        string[] answer = new string[answerLength];
        
        for (int i = 0; i < answerLength; i++) {
            answer[i] = names[i * 5];
        }
        
        return answer;
    }
}