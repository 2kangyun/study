// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120847


using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        
        Array.Sort(numbers, (x, y) => y.CompareTo(x)); // 내림차순 정렬
        answer = numbers[0] * numbers[1]; // 가장 큰 두 수의 곱
        
        return answer; // 정답 반환
    }
}