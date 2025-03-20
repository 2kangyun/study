// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120850


using System;
using System.Linq;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[] {};// 정답 변수 선언
        
        answer = my_string.Where(char.IsDigit).Select(x => x - '0').ToArray(); // 숫자로 변환 가능한 문자만 뽑아서 배열로 변환
        
        Array.Sort(answer); // 정렬
        
        return answer; // 정답 반환
    }
}