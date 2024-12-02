// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120908


using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 0; // 결과 변수 저장
        
        answer = str1.Contains(str2) ? 1 : 2; // 결과 계산
        
        return answer; // 결과 반환
    }
}