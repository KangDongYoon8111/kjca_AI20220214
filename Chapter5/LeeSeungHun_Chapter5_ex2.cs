using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeeSeungHun_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userinput = "50";

        int number = int.Parse(userinput);

        if (50 >= number)
        {
            Debug.Log($"�Է��Ͻ� ����{number}��(��) 50�̻��Դϴ�.");
        }
        else
        {
            Debug.Log($"�Է��Ͻ� ����{number}��(��) 50�̸��Դϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
