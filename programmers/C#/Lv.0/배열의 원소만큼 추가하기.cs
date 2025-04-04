// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181861


using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        
        answer = arr.SelectMany(n => Enumerable.Repeat(n, n)).ToArray();
        
        return answer;
    }
}