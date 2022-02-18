using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class byenhyenmin_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ///정수 한 개를 입력받아서
        ///그 수가 50 이상의 수인지
        ///50미만의 수인지 판단하는 프로그램을 만들어
        string userinput = "30";
        int userScore = int.Parse(userinput);
        if(userScore>49)
        {
            Debug.Log($"50이상");
        }
        else
        {
            Debug.Log($"50이하");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
