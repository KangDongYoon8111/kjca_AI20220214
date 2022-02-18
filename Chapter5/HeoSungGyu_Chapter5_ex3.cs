using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeoSungGyu_Chapter5_ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "3";
        int b = int.Parse(userInput);

        if (b % 3 == 0)
        {
            Debug.Log($"입력된 수 {b}는(은) 3의 배수 입니다.");
        }
        else
        {
            Debug.Log($"입력된 수 {b}는(은) 3의 배수가 아닙니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
