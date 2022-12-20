using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager2 : MonoBehaviour
{
    
    void Start()
    {
        //1. 1 ~10 까지 출력
        //for (int a = 1; a <=10; a++) //++는 증가라는 뜻
        //{
        //    Debug.Log(a);
        //}

        ////2. 10 ~1 까지 출력
        //for (int b = 10; b > 0; b--) //--는 증감이라는 뜻
        //{
        //    Debug.Log(b);
        //}
        //for(int b = 10; b >= 1; b--)
        //{
        //    Debug.Log(b);
        //}
        //for (int b = 1; b <= 10; b++)
        //{
        //    int result = 11 - b;
        //    Debug.Log(result);
        //}

        //3. 1에서 100까지 숫자의 합계 (등차수열)
        //int result = 0;

        //for (int c = 1; c <= 100; c++)
        //{
        //    result += c;
        //}
        //Debug.Log(result);

        //4. 10에서 50 까지 수의 평균
        //합계 구하는 로직을 그대로 가져온다
        //int result = 0;
        //int count = 0;
        //for (int d = 10; d <= 50; d++)
        //{
        //    result += d;
        //    count++;
        //}
        //int average = result / count;
        //Debug.Log(average);

        //5. 1에서 100까지 숫자 중 5의 배수의 합계
        //int result = 0;
        //for (int e = 1; e <=100; e++) //1부터 100까지 증가하는 반복문이라는 뜻
        //{
        //    // %라는 것은 나머지 라는 뜻이다
        //    if (e % 5 == 0) //5의 배수일때만 //==은 나머지가 0이 될때만 이라는 뜻
        //    {
        //        result += e;
        //    }

        //}
        //Debug.Log(result);

        //6. 1에서 100까지 숫자 중 2의 배수와 3의 배수의 합계
        // 주의해야할것 2와 3의 배수의 값 중 같은 것이 있을 때(ex:6) 겹쳐서 중복 합이 되어서는 안된다.

        //int result = 0;

        //for (int f = 1; f <= 100; f++)
        //{

        //bool isTrue = false;

        //if (f % 2 == 0) // 2의 배수
        //{
        //    isTrue = true;
        //}

        //if (f % 3 == 0) // 3의 배수
        //{
        //    isTrue = true;
        //}

        //if (isTrue == true)
        //{
        //    result += f;
        //}
        //    if (f % 2 == 0 || f % 3 == 0)
        //    {
        //        result += f;
        //    }
        //}
        //Debug.Log(result);

        //7. 1에서 100까지 숫자 중 7의 소수의 개수
        int count = 0;
        for (int g = 2; g <= 100; g++)
        {
            bool isTrue = true; //소수일거야

            for (int x = 2; x < g; x++)  //소수를 구하기 위해 x가 5일때 g는 x보다 커야한다.
            {
                if (g % x == 0)
                {
                    isTrue = false; //소수가 아니었네
                }
            }

            if (isTrue == true)
            {
                count++;  
            }
            
        }
        Debug.Log(count);
    }
}