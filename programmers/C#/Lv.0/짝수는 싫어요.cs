// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120813


using System;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        int[] answer = {}; // 결과 저장 변수
        
        answer = Enumerable.Range(1, n).Where(i => i % 2 == 1).ToArray(); // 결과 계산
        
        return answer; // 결과 반환
    }
}