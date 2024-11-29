// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120822


using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = ""; // 정답 변수 선언
        
        answer += new string(my_string.Reverse().ToArray()); // 뒤집기
        
        return answer; // 정답 반환
    }
}