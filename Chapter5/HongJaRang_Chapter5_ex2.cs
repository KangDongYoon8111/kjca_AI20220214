using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HongJaRang_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userinput = "55";
        int a = int.Parse(userinput);

        if (a >= 50) { Debug.Log("50 �̻��� ��"); }
        else { Debug.Log("50 �̸��� ��"); }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
