using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeoSungGyu_Chapter5_ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "3";
        int b = int.Parse(userInput);

        if (b % 3 == 0)
        {
            Debug.Log($"�Էµ� �� {b}��(��) 3�� ��� �Դϴ�.");
        }
        else
        {
            Debug.Log($"�Էµ� �� {b}��(��) 3�� ����� �ƴմϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
