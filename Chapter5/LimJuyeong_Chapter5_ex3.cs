using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimJuyeong_Chapter5_ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "16";
        int userscore = int.Parse(userInput);

        if (userscore %3==0)
        {
            Debug.Log($"3�� ����Դϴ�.");
        }
        else
        {
            Debug.Log($"3�� ����� �ƴմϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
