using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeonSeonYu_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "53";
        int num = int.Parse(userInput);

        if (num >= 50)
        {
            Debug.Log($"�Է��Ͻ� ���� {num}��(��) 50 �̻��Դϴ�.");
        }
        else
        {
            Debug.Log($"�Է��Ͻ� ���� {num}��(��) 50 �̸��Դϴ�.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
