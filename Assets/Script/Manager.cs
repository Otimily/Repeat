using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    void Start()
    {
        ////3����?
        //for (int m = 1; m < 10; m++)
        //{
        //    Debug.Log("3 x " + m + " = " + 3 * m);
        //}
        //������ 2~9�ܱ��� ��� ����Ϸ���?

        //for (int p = 2; p < 10; p++) //��ܺ��� ��������
        //{

        //    for (int o = 1; o < 10; o++) //�߰��� ������ ���Ұ�����
        //    {
        //        int result = p * o;

        //        Debug.Log(p + " x " + o + " = " + result);
        //    }

        //    Debug.Log("=======================");
        //}
        //�������� �Ͻ� 2~9�� �����?
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
