// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/181844


using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        int[] answer = new int[] {}; // 정답 변수 선언
        
        answer = arr.Except(delete_list).ToArray(); // 중복 원소 삭제
        
        return answer; // 정답 반환
    }
}