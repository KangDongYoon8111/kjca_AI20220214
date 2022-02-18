using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeonSeonYu_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "53";
        int num = int.Parse(userInput);

        if (num >= 50)
        {
            Debug.Log($"입력하신 숫자 {num}은(는) 50 이상입니다.");
        }
        else
        {
            Debug.Log($"입력하신 숫자 {num}은(는) 50 미만입니다.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
