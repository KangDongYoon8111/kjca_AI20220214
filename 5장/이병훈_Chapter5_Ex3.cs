using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_Ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "16";
        int userScore = int.Parse(userInput);

        if (userScore %3 == 0 )
        {
            Debug.Log($"3의 배수 입니다.");
        }
        else  
        {
            Debug.Log($"3의 배수가 아닙니다");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
