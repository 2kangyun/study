// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120897


using System;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {}; // 정답 변수 선언
        
        answer = Enumerable.Range(1, n).Where(x => n % x == 0).ToArray(); // 약수 계산
        
        return answer; // 정답 반환
    }
}