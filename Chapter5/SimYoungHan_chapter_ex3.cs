using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimYoungHan_chapter_ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "16";
        int userSocer = int.Parse(userInput);

        if (userSocer % 3 == 0)
        {
            Debug.Log("3의 배수입니다.");

        }
        else
        {
            Debug.Log("3의 배수가 아닙니다.");
        }
        
      
        
         


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
