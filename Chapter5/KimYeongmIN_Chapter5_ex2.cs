using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimYeongmIN_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "73";
        int a = int.Parse(userInput);

        if (a >= 50)
        {
            Debug.Log($"50 이상");
        }
        else
        {
            Debug.Log("50 이하");
        }
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
