using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangMinJi_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "2";
        int number = int.Parse(userInput);
        Debug.Log(number >= 50 ? "50 �̻��� ��" : "50 �̸��� ��");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
