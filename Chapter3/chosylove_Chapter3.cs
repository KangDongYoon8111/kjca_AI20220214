using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chosylove_Chapter3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string nurby = "30";
        string nopy = "40";
        int nurBY = int.Parse(nurby);
        int noPY = int.Parse(nopy);
        int nullby = nurBY * noPY;

        Debug.Log($"사각형의 너비는 {nurby}입니다.");
        Debug.Log($"사각형의 높이는 {nopy}입니다.");
        Debug.Log($"사각형의 넓이는 : {nullby}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
