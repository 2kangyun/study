// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120903


using System;
using System.Linq;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0; // 정답 변수 선언
        
        answer = s1.Count(x => s2.Contains(x)); // 계산
        
        return answer; // 결과 반환
    }
}