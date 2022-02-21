using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGyuRi_Chapter5_ex9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int add = 0;

        for(int i = 0; i<=10; i++)
        {
            if(i%3==0)
            {
                continue;
            }
            Debug.Log(i);

            add += i;

            Debug.Log($"1~10까지 정수 중에서 3으로 나누어 떨어지지 않는 수의 합:{add}");


        }











    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
