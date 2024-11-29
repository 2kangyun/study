// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120833


using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        int[] answer = {}; // 결과 변수 선언
        
        answer = numbers.Skip(num1).Take(num2 - num1 + 1).ToArray(); // 배열 자르기
        
        return answer; // 결과 반환
    }
}