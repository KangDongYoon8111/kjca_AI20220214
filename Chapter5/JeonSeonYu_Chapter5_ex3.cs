using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeonSeonYu_Chapter5_ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "33";
        int num = int.Parse(userInput);

        if (num % 3 == 0)
        {
            Debug.Log($"�Է��Ͻ� ���� {num}��(��) 3�� ����Դϴ�.");
        }
        else
        {
            Debug.Log($"�Է��Ͻ� ���� {num}��(��) 3�� ����� �ƴմϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
