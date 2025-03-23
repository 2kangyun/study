// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181840


using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list, int n) {
        int answer = 0; // 정답 변수 선언
        
        if (num_list.Contains(n)) answer = 1; // n이 있을 경우 answer = 1
        
        return answer;1 // 정답 반환
    }
}