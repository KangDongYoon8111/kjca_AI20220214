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
            Debug.Log($"50�̻��� ��");
        }
        else if (userscore < 50)
        {
            Debug.Log($"50�̸��� ��");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
