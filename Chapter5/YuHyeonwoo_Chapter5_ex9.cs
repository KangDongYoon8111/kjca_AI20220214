using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuHyeonwoo_Chapter5_ex9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { int sum = 0; 
        for (int i = 1; i< 11; i++)
        {
            if (i % 3 != 0)
            {
                sum += i;
                Debug.Log(i);
            }
                
            
        }
       Debug.Log($"1~10중 3으로 나누어 떨어지지 않은 수의 합:{sum}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
