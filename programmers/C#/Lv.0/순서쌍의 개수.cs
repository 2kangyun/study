// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120836?language=csharp


using System;
using System.Linq;

public class Solution {
    public int solution(int n) {
        int answer = 0; // 정답 변수 선언
        
        answer = Enumerable.Range(1, n).Count(x => n % x == 0);
        
        return answer; // 정답 반환
    }
}