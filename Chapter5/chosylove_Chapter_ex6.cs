using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chosylove_Chapter_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "10";
        string userInput2 = "2";
        string userInput3 = "+";

        int number1 = int.Parse(userInput1);
        int number2 = int.Parse(userInput2);
        int value = 0; 

        switch (userInput3)
        {
            case "+":
                value = number1 + number2;        
                break;
            case "-":
                value = number1 - number2;                
                break;
            case "*":
                value = number1 * number2;                
                break;
            case "/":
                value = number1 / number2;               
                break;
            default:
                value = number1 % number2;                
                break;
        }
        Debug.Log($"�Է��Ͻ� {number1}{userInput3}{number2}�� ���� {value}�Դϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
