using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_Ex6 : MonoBehaviour
{

    public int A;
    public string symbol;
    public int B;
    // Start is called before the first frame update
    void Start()
    {
        switch (symbol)
        {
            case "+":
                Debug.Log(($"입력하신 {A}+{B} 의 값은 {A+B}입니다"));
                break;
            case "-":
                Debug.Log(($"입력하신 {A}-{B} 의 값은 {A - B}입니다"));
                break;
            case "*":
                Debug.Log(($"입력하신 {A}*{B} 의 값은 {A * B}입니다"));
                break;
            case "/":
                Debug.Log(($"입력하신 {A}/{B} 의 값은 {A / B}입니다"));
                break;
            case "%":
                Debug.Log(($"입력하신 {A}%{B} 의 값은 {A % B}입니다"));
                break;

            default:
                Debug.Log($"{symbol}는(은) 기호가 아닙니다.");
                break;

        }
    }

}
