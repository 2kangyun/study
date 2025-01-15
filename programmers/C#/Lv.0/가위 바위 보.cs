// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120839


using System;
using System.Text;

public class Solution {
    public string solution(string rsp) {
        string answer = ""; // 정답 변수 선언
        
        StringBuilder sb = new StringBuilder(); // 문자열 저장 변수
        foreach (char c in rsp) {
            switch(c) {
                case '0': // 주먹일 때
                    sb.Append(5);
                    break;
                case '2': // 가위일 때
                    sb.Append(0);
                    break;
                case '5': // 보일 때
                    sb.Append(2);
                    break;
            }
        }
        answer = sb.ToString();
        
        return answer; // 정답 반환
    }
}