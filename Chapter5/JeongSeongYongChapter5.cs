using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5 : MonoBehaviour
{
    void Start()
    {
        int sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            if (i % 3 != 0)
            {
                Debug.Log(i);
                sum += i;
            }
        }
        Debug.Log($"1~10 �� 3���� ������ �������� �ʴ� ���� �� : {sum}");
    }



