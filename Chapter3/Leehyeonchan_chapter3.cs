using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leehyeonchan_chapter3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string mybyunsu = "30";
        string Mybyunsu = "40";

        string youbyunsu = "사각형의";
        string aa = "너비는";
        string bb = "높이는";
        string Youbyunsu = "입니다";

        string cc = "넓이는 :";
        string dd = "1200";

        Debug.Log($"{youbyunsu}{ aa}{ mybyunsu}{Youbyunsu}");
        Debug.Log($"{youbyunsu}{ bb}{ Mybyunsu}{Youbyunsu}");
        Debug.Log($"{youbyunsu}{ cc}{ dd}{Youbyunsu}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
