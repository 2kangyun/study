// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120911?language=csharp


using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = ""; // 정답 변수
        
        
        answer = new string(my_string.ToLower().OrderBy(ch => ch).ToArray()); // 소문자로 변환 후 정렬
        
        return answer; // 정답 반환
    }
}