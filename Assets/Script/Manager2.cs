using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager2 : MonoBehaviour
{
    
    void Start()
    {
        //1. 1 ~10 ���� ���
        //for (int a = 1; a <=10; a++) //++�� ������� ��
        //{
        //    Debug.Log(a);
        //}

        ////2. 10 ~1 ���� ���
        //for (int b = 10; b > 0; b--) //--�� �����̶�� ��
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

        //3. 1���� 100���� ������ �հ� (��������)
        //int result = 0;

        //for (int c = 1; c <= 100; c++)
        //{
        //    result += c;
        //}
        //Debug.Log(result);

        //4. 10���� 50 ���� ���� ���
        //�հ� ���ϴ� ������ �״�� �����´�
        //int result = 0;
        //int count = 0;
        //for (int d = 10; d <= 50; d++)
        //{
        //    result += d;
        //    count++;
        //}
        //int average = result / count;
        //Debug.Log(average);

        //5. 1���� 100���� ���� �� 5�� ����� �հ�
        //int result = 0;
        //for (int e = 1; e <=100; e++) //1���� 100���� �����ϴ� �ݺ����̶�� ��
        //{
        //    // %��� ���� ������ ��� ���̴�
        //    if (e % 5 == 0) //5�� ����϶��� //==�� �������� 0�� �ɶ��� �̶�� ��
        //    {
        //        result += e;
        //    }

        //}
        //Debug.Log(result);

        //6. 1���� 100���� ���� �� 2�� ����� 3�� ����� �հ�
        // �����ؾ��Ұ� 2�� 3�� ����� �� �� ���� ���� ���� ��(ex:6) ���ļ� �ߺ� ���� �Ǿ�� �ȵȴ�.

        //int result = 0;

        //for (int f = 1; f <= 100; f++)
        //{

        //bool isTrue = false;

        //if (f % 2 == 0) // 2�� ���
        //{
        //    isTrue = true;
        //}

        //if (f % 3 == 0) // 3�� ���
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

        //7. 1���� 100���� ���� �� 7�� �Ҽ��� ����
        int count = 0;
        for (int g = 2; g <= 100; g++)
        {
            bool isTrue = true; //�Ҽ��ϰž�

            for (int x = 2; x < g; x++)  //�Ҽ��� ���ϱ� ���� x�� 5�϶� g�� x���� Ŀ���Ѵ�.
            {
                if (g % x == 0)
                {
                    isTrue = false; //�Ҽ��� �ƴϾ���
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