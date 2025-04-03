// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181847


using System;

public class Solution {
    public string solution(string n_str) {
        string answer = "";
        
        answer = int.Parse(n_str).ToString(); // 정수로 변환하면 앞의 0은 다 날라감
        
        return answer;
    }
}