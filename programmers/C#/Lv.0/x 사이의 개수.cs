// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181867


using System;
using System.Linq;

public class Solution {
    public int[] solution(string myString) {
        int[] answer = new int[] {};
        
        
        string[] xsplit_arr = myString.Split('x'); 
        
        answer = xsplit_arr.Select(x => x.Length).ToArray(); // 길이로 변환
        
        return answer;
    }
}