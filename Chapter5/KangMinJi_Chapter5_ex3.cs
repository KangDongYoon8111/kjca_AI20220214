using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangMinJi_Chapter5_ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "8";
        int number = int.Parse(userInput);
        Debug.Log(number % 3 == 0 ? "3�� ����Դϴ�." : "3�� ����� �ƴմϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
