using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";
        
        int x= int.Parse (a);
        int y= int.Parse (b);

        Debug.Log($"사각형의 너비는 {x}입니다.");
        Debug.Log($"사각형의 높이는 {y}입니다.");
        Debug.Log($"사각형의 넓이는 {x * y}입니다.");





    }

    // Update is called once per frame
    void Update()
    {

    }
}
