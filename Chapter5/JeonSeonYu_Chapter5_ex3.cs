using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeonSeonYu_Chapter5_ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "33";
        int num = int.Parse(userInput);

        if (num % 3 == 0)
        {
            Debug.Log($"입력하신 숫자 {num}은(는) 3의 배수입니다.");
        }
        else
        {
            Debug.Log($"입력하신 숫자 {num}은(는) 3의 배수가 아닙니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
