using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuHyeonwoo_Chapter5_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "10";
        string userInput2 = "2";
        string userInput3 = "/";
        int a = int.Parse(userInput1);
        int b = int.Parse(userInput2);
       
        switch (userInput3)
        {
            case "+":
                Debug.Log($"입력하신 {userInput1}/{userInput2}의 값은 {a + b}");
                break;
            case "-":
                Debug.Log($"입력하신 {userInput1}/{userInput2}의 값은 {a - b}");
                break;
            case "*":
                Debug.Log($"입력하신 {userInput1}/{userInput2}의 값은 {a * b}");
                break;
            case "/":
                Debug.Log($"입력하신 {userInput1}/{userInput2}의 값은 {a / b}");
                break;
        }
       
    }
        
        
    // Update is called once per frame
    void Update()
    {
        
    }
}
