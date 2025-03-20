// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120905?language=csharp


using System;
using System.Linq;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        int[] answer = new int[] {}; // 정답 변수 선언
        
        answer = numlist.Where(x => x % n == 0).ToArray(); // 계산
        
        return answer; // 정답 반환
        
    }
}