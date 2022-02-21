using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimYeongMin_Chapter5_ex9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 0;

        for (int i = 1; i <= 10; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            else
            {
                Debug.Log(i);
                a += i;
            }
        }
        Debug.Log($"1~10중 3으로 나누어 떨어지지 않는 수의 합:{a}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
