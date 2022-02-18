using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeeSeungHun_Chapter5_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userinput1 = "10";
        string userinput2 = "5";
        string userinput3 = "/";

        int num1 = int.Parse(userinput1);
        int num2 = int.Parse(userinput2);

        switch(userinput3)
        {
            case "+":
                Debug.Log($"입력하신 {num1}{userinput3}{num2}의 값은{num1 + num2}입니다");
                break;
            case "-":
                Debug.Log($"입력하신 {num1}{userinput3}{num2}의 값은{num1 - num2}입니다");
                break;
            case "*":
                Debug.Log($"입력하신 {num1}{userinput3}{num2}의 값은{num1 * num2}입니다");
                break;
            case "/":
                Debug.Log($"입력하신 {num1}{userinput3}{num2}의 값은{num1 / num2}입니다");
                break;
            case "%":
                Debug.Log($"입력하신 {num1}{userinput3}{num2}의 값은{num1 % num2}입니다");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
