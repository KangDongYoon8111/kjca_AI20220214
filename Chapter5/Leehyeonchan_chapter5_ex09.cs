using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chapter5_ex09 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //   1. 1~10���� ���� �߿��� 3���� ������ �������� �ʴ� ����
        //����ϰ�, �� ������ ���� ���


        for (int i = 0; i < 11; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            Debug.Log($"{i}");

            
        }

        Debug.Log($"1~10�� 3���� ���� �������� �ʴ� ���� �� :{1+2+4+5+7+8+10}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
