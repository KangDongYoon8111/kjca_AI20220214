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
                Debug.Log($"�Է��Ͻ�{a} + {b} �� {a + b}�Դϴ�." );

                break;
            case "-":
                Debug.Log($"�Է��Ͻ�{a} - {b} �� {a - b}�Դϴ�.");

                break;
            case "*":
                Debug.Log($"�Է��Ͻ�{a} * {b} �� {a * b}�Դϴ�.");

                break;
            case "/":
                Debug.Log($"�Է��Ͻ�{a} / {b} �� {a / b}�Դϴ�.");

                break;
            default:
                Debug.Log("�ùٸ� �Է��� �ƴմϴ�.");
                break;
                
        }

            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
