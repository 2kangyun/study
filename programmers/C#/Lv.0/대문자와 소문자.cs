// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120893


using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = ""; // 정답 변수 선언
        
        answer = new string(my_string.Select(ch => char.IsLower(ch) ? char.ToUpper(ch) : char.ToLower(ch)).ToArray()); // 대문자 -> 소문자, 소문자 -> 대문자자
        
        return answer; // 정답 반환
    }
}