// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120899


using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[2]; // 결과 변수 선언
        
        answer[0] = array.Max(); // 가장 큰 수
        answer[1] = Array.IndexOf(array, answer[0]); // 가장 큰 수의 인덱스
        
        return answer; // 결과 반환
    }
}