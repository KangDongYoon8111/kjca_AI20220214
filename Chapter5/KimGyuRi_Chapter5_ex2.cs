using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGyuRi_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //정수 한 개를 입력받아서,
        //그 수가 50 이상의 수인지
        //50미만의 수인지
        //판단하는 프로그램을 만들어 주세요.

       
            string userInput = "55";
        
        int num = int.Parse(userInput);

        string result = (50 <= num) ? "50이상" : "50미만";
        Debug.Log(result);

        if (50 <= num)
        {
            Debug.Log("50이상");
        }
        else
        {
            Debug.Log("50미만");
        }

















    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
