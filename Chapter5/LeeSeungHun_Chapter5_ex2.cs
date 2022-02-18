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
            Debug.Log($"입력하신 정수{number}은(는) 50이상입니다.");
        }
        else
        {
            Debug.Log($"입력하신 정수{number}은(는) 50미만입니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
