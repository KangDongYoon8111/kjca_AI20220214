using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeoSungGyu_Chapter5_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "1";
        string userInput2 = "2";
        string userInput3 = "-";

        int a = int.Parse(userInput1);
        int b = int.Parse(userInput2);


        switch (userInput3)
        {
            case "+":
                Debug.Log($"입력하신{a} + {b} 는 {a + b}입니다." );

                break;
            case "-":
                Debug.Log($"입력하신{a} - {b} 는 {a - b}입니다.");

                break;
            case "*":
                Debug.Log($"입력하신{a} * {b} 는 {a * b}입니다.");

                break;
            case "/":
                Debug.Log($"입력하신{a} / {b} 는 {a / b}입니다.");

                break;
            default:
                Debug.Log("올바른 입력이 아닙니다.");
                break;
                
        }

            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
