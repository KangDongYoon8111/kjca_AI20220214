using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yangchaeeun_Chapter4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1. i++은 i를 먼저 인식하고 연산을한다. ++i는 연산을 먼저하고 i를 인식한다.

        //2.
        int i = 1;
        Debug.Log(i = i + 1); // 답 : 1 = 2
        Debug.Log(i++); //답 : 2
        Debug.Log(++i); //답 : 4
        Debug.Log(i += 1); //답 : 5

        //3. ABC
        int a = 10;
        string b = a == 0 ? "가나다" : "ABC";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
