using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuHyeonwoo_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "53";
        int userScore = int.Parse(userInput);
        
        if(userScore>= 50)
        {
            Debug.Log("50 이상의 수");
        }
        else
        {
            Debug.Log("50 미만의 수");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
