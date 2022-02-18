using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimJuyeong_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "53";
        int userscore = int.Parse(userInput);

        if (userscore >= 50)
        {
            Debug.Log($"50이상의 수");
        }
        else if (userscore < 50)
        {
            Debug.Log($"50미만의 수");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
