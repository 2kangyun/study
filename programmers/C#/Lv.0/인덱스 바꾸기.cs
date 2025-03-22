// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120895


using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = ""; // 정답 변수 선언
        StringBuilder sb = new StringBuilder(my_string); // 값 교환을 위한 StringBuilder
        
        //값 교환
        sb[num1] = my_string[num2];
        sb[num2] = my_string[num1];
        
        answer = sb.ToString(); // string으로 변환
        
        return answer; // 정답 반환
    }
}