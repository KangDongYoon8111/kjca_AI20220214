using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeoSungGyu_Chapter5_ex9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            if(i % 3 != 0)
            Debug.Log(i);
            sum += i;
        }
        Debug.Log($"1~10���� �� �߿��� 3���� ���������� �ʴ� ���� ���� {sum}�Դϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}