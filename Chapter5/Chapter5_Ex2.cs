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
            Debug.Log($"�Է��Ͻ� ���� {userScore}��" + $" 50�̻��� ��");
        }
        else if (userScore < 50)
        {
            Debug.Log($"�Է��Ͻ� ���� {userScore}��" + $" 50�̸��� ��");
        }

       

    }

    // Update is called once per frame
    void Update()
    {

    }
}
