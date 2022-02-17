using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimMinSeo_Chapter3 : MonoBehaviour
{   
    void Start()
    {
        // 연습문제 1
        string a = "30";
        string b = "40";
        int x = int.Parse(a);
        int y = int.Parse(b);

        Debug.Log($"사각형의 너비는 {a}입니다");
        Debug.Log($"사각형의 높이는 {b}입니다");
        Debug.Log($"사각형의 넓이: {x * y}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
