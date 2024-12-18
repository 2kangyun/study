// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120825?language=csharp


using System;
using System.Linq;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = ""; // 결과 정보 저장
        
        answer = string.Concat(my_string.Select(c => new string(c, n))); // 결과 계산
        
        return answer; // 결과 반환
    }
}