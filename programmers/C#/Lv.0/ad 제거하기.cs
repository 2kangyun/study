// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181870


using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = new string[] {};
        
        answer = strArr.Where(x => !x.Contains("ad")).ToArray(); // ad를 포함하는 문자열 제거
        
        return answer;
    }
}