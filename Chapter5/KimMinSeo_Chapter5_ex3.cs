using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimMinSeo_Chapter5_ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "16";
        int a = int.Parse(userInput);

        if (a != 0 && a % 3 == 0)
        {
            Debug.Log("3의 배수입니다.");
        }
        else if (a == 0)
        {
            Debug.Log("0");
        }
        else
        {
            Debug.Log("3의 배수가 아닙니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
