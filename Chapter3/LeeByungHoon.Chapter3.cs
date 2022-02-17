using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{

    int a = 30;
    int b = 40;

    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("사각형의 너비는:"+(a));
        Debug.Log("사각형의 높이는:"+(b));
        Debug.Log("사각형의 넓이:" + (a * b));

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))

        {

            Debug.Log("Hello, C# World!");

        }
        if (Input.GetKeyDown(KeyCode.F2))

        {

            Debug.Log("여러분, 안녕하세요?");
            Debug.Log("반갑습니다!");

        }
        if (Input.GetKeyDown(KeyCode.F3))

        {

            Debug.Log("C# 어렵지 않아요~");
            Debug.Log("우리 같이!");
            Debug.Log("익숙해져봅시다~");

        }
    }
}
