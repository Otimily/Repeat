using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    void Start()
    {
        ////3단은?
        //for (int m = 1; m < 10; m++)
        //{
        //    Debug.Log("3 x " + m + " = " + 3 * m);
        //}
        //구구단 2~9단까지 모두 출력하려면?

        //for (int p = 2; p < 10; p++) //몇단부터 시작할지
        //{

        //    for (int o = 1; o < 10; o++) //중간에 무엇을 곱할것인지
        //    {
        //        int result = p * o;

        //        Debug.Log(p + " x " + o + " = " + result);
        //    }

        //    Debug.Log("=======================");
        //}
        //선생님이 하신 2~9단 출력은?
        for(int l = 2; l <= 9; l++)
        {
            for (int c =1; c<=9; c++)
            {
                int result = l * c;
                Debug.Log(l + " x " + c + " = " + result);
            }
            Debug.Log("=======================");
        }
    }

}
