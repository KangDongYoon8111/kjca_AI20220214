using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HongJaRang_Chapter5_ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userinput = "36";
        int a = int.Parse(userinput);

        if (a % 3 == 0) { Debug.Log("3의 배수입니다."); }
        else { Debug.Log("3의 배수가 아닙니다."); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
