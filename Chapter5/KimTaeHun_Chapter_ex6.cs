using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimTaeHun_Chapter_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userinput = "100";
        string userinput2 = "40";
        int i = int.Parse(userinput);
        int j = int.Parse(userinput2);
        string userinput3 = "/";

        switch (userinput3)
        {
            case "+":
                Debug.Log(i + j);
                break;
            case "-":
                Debug.Log(i - j);
                break;
            case "/":
                Debug.Log(i / j);
                break;
            case "*":
                Debug.Log(i * j);
                break;
            case "%":
                Debug.Log(i % j);
                break;
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
