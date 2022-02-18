using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeesoyiChapter5_ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userinput = "30";

        int number = int.Parse(userinput);
        if (number % 3 == 0) 
        {
            Debug.Log("3의 배수");
        }
        else
        {
            Debug.Log("3의 배수 아님");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
