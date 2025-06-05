// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181901


using System;
using System.Linq;

public class Solution {
    public int[] solution(int n, int k) {
        int[] answer = new int[] {};
        
            answer = Enumerable.Range(1, n).Where(i => i % k == 0).ToArray();
        
        return answer;
    }
}