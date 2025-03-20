// 문제 링크 https://school.programmers.co.kr/learn/courses/30/lessons/120862


// 첫 번째 답안
using System;

public class Solution {
    public int solution(int[] numbers) {

        int answer = 0; // 정답 변수 선언
        int plus_max0 = 0; // 제일 큰 양수
        int plus_max1 = 0; // 두번째로 큰 양수
        int minus_min0 = 0; // 제일 작은 음수
        int minus_min1 = 0; // 두번째로 작은 음수

        foreach(int i in numbers) {
            if (i >= plus_max0) { // 가장 큰 수일 경우
                plus_max1 = plus_max0;
                plus_max0 = i;
            }
            else if(i > plus_max1) { // 두번째로 큰 수일 경우
                plus_max1 = i;
            }
            if (i <= minus_min0) { // 가장 작은 수일 경우
                minus_min1 = minus_min0;
                minus_min0 = i;
            }
            else if(i < minus_min1){ // 두번째로 작은 수일 경우
                minus_min1 = i;
            }
        }
        // 양수곱 음수곱 중 큰 수를 선택
        if(plus_max0 * plus_max1 > minus_min0 * minus_min1) { // 양수곱 음수곱 중 큰 수를 선택
            answer = plus_max0 * plus_max1;
        }
        else {
            answer = minus_min0 * minus_min1;
        }

        if(numbers.Length == 2) {
            answer = numbers[0] * numbers[1];
        }

        return answer; // 정답 반환
    }
}


// 두 번째 답안

using System;

public class Solution {
    public int solution(int[] numbers) {

        int answer = 0; // 정답 변수 선언
        
        Array.Sort(numbers); // 배열 정렬
        
        int min_mul = numbers[0] * numbers[1]; // 가장 작은 두 수의 곱(음수)
        int max_mul = numbers[numbers.Length - 1] * numbers[numbers.Length - 2]; // 가장 큰 두 수의 곱(양수)
        
        answer = min_mul > max_mul ? min_mul : max_mul; // 큰 수 저장

        return answer; // 정답 반환
    }
}