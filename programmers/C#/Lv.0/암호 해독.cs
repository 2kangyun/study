// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120892


using System;
using System.Linq;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = ""; // 정답 변수 선언
        
        answer = String.Concat(cipher.Where((x, i) => ((i + 1) % code == 0))); // 암호 해독
        
        return answer; // 정답 반환
    }
}