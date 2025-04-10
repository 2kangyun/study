// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181884


using System;

public class Solution {
    public int solution(int[] numbers, int n) {
        int answer = 0;
        int index = 0;
        
        while(answer <= n) {
            answer += numbers[index++];
        }
        
        return answer;
    }
}