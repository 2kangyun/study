// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120811


using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0; // 결과 저장 변수
        
        Array.Sort(array); // 배열 정렬
        answer = array[array.Length / 2]; // 결과 계산
        
        return answer; // 결과 반환
    }
}