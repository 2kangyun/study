// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181841?language=csharp


using System;

public class Solution {
    public string solution(string[] str_list, string ex) {
        string answer = ""; // 정답 변수 선언
        
        foreach(string s in str_list) {
            if (!s.Contains(ex)) { // ex를 포함하지 않는다면 추가
                answer += s;
            }
        }
        
        return answer; // 정답 반환
    }
}