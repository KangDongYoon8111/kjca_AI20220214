using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class byenhyenmin_Chater5_ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ///정수 한 개를 입력받아서,
        ///그 수가 3의 배수인지 판단하는
        string user = "90";
        int userscore = int.Parse(user);
        if (userscore % 3 == 0)
        {
            Debug.Log($"3의배수");
        }
        else
        {
            Debug.Log($"3의배수아님");
        }

    }

    // Update is called once per frame
    void Update()
    {
        



    }
}
