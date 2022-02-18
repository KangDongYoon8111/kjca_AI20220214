using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeoSungGyu_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 1;

        if (a >= 50)
        {
            Debug.Log($"입력된 수는 50이상입니다.");
        }
        else
        {
            Debug.Log($"입력된 수 {a}는(은) 50미만입니다.");
        }
    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
