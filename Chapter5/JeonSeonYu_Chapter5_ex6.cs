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
                Debug.Log("���� �ٽ� �Է����ּ���.");
                break;
        }

        Debug.Log($"�Է��Ͻ� {x}{userInput3}{y} �� ���� {result}�Դϴ�.");
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
