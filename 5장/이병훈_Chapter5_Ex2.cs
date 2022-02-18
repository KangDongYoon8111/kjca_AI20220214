using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_Ex2 : MonoBehaviour
{
    void Start()
    {
        string userInput = "53";
        int userScore = int.Parse(userInput);

        if (userScore >= 50)
        {
            Debug.Log($"입력하신 점수 {userScore}은" + $" 50이상의 수");
        }
        else if (userScore < 50)
        {
            Debug.Log($"입력하신 점수 {userScore}은" + $" 50미만의 수");
        }

       

    }

    // Update is called once per frame
    void Update()
    {

    }
}
