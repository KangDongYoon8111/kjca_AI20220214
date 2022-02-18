using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeonSeonYu_Chapter5_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "10";
        string userInput2 = "2";
        string userInput3 = "/";

        int x = int.Parse(userInput1);
        int y = int.Parse(userInput2);
        int result = 0;

        switch (userInput3)
        {
            case "+":
                result = x + y;
                break;
            case "-":
                result = x - y;
                break;
            case "*":
                result = x * y;
                break;
            case "/":
                result = x / y;
                break;
            default:
                Debug.Log("값을 다시 입력해주세요.");
                break;
        }

        Debug.Log($"입력하신 {x}{userInput3}{y} 의 값은 {result}입니다.");
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
