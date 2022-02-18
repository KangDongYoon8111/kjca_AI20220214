using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiMGyuRI_Chapter5_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // userInput 변수의 값은
        // 여러분들이 원하는 숫자를 입력하세요.
        string userInput1 = "100";
        string userInput2 = "23";
        string userInput3 = "*";

        int input1 = int.Parse(userInput1);
        int input2 = int.Parse(userInput2);
        int value = 0;


        switch (userInput3)
        {
            case "+":
                value = input1 + input2;

                break;

            case "-":
                value = input1 - input2;
                break;

            case "*":
                value = input1 * input2;
                break;

            case "/:":
                value = input1 / input2;
                break;

            case "%":
                value = input1 % input2;
                break;
        }
                    Debug.Log($"입력하신{input1}{userInput3}{input2}의 값은 {value}입니다");
                
        }





  

    // Update is called once per frame
    void Update()
    {
        
    }
}
