using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimMinSeo_Chapter5_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "10";
        string userInput2 = "2";
        string userInput3 = "/";
        int a = int.Parse(userInput1);
        int b = int.Parse(userInput2);
        int v = 0;

        switch (userInput3)
        {
            case "+":
                v = a + b;
                break;
            case "-":
                v = a - b;
                break;
            case "/":
                v = a / b;
                break;
            case "%":
                v = a % b;
                break;
            case "*":
                v = a * b;
                break;
        }
        Debug.Log($"입력하신 {a}{userInput3}{b}의 값은{v}입니다");

    }
            

    // Update is called once per frame
    void Update()
    {
        
    }
}
