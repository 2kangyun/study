// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181875


using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = new string[] {};
        
        answer = strArr.Select((x, i) => i % 2 == 0 ? x.ToLower() : x.ToUpper()).ToArray();
        
        return answer;
    }
}