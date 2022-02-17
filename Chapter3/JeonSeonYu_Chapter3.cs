using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeonSeonYu_Chapter3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";

        int w = int.Parse(a);
        int h = int.Parse(b);

        Debug.Log($"사각형의 너비는 {w}입니다.");
        Debug.Log($"사각형의 높이는 {h}입니다.");
        Debug.Log($"사각형의 넓이는 : {w * h}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
