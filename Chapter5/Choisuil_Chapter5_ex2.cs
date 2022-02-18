using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choisuil_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string userInput = "49";
        int userScore = int.Parse(userInput);
        string score = "";

        if (userScore >= 50) {
            Debug.Log("50 이상의 수.");
        }else if(userScore < 50)
        Debug.Log("50 미만의 수.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
