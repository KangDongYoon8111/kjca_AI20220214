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
                Debug.Log(($"�Է��Ͻ� {A}+{B} �� ���� {A+B}�Դϴ�"));
                break;
            case "-":
                Debug.Log(($"�Է��Ͻ� {A}-{B} �� ���� {A - B}�Դϴ�"));
                break;
            case "*":
                Debug.Log(($"�Է��Ͻ� {A}*{B} �� ���� {A * B}�Դϴ�"));
                break;
            case "/":
                Debug.Log(($"�Է��Ͻ� {A}/{B} �� ���� {A / B}�Դϴ�"));
                break;
            case "%":
                Debug.Log(($"�Է��Ͻ� {A}%{B} �� ���� {A % B}�Դϴ�"));
                break;

            default:
                Debug.Log($"{symbol}��(��) ��ȣ�� �ƴմϴ�.");
                break;

        }
    }

}
