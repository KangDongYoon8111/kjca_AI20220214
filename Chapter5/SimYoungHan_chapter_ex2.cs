using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimYoungHan_chapter_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInpdt = "53";
        int userSocer = int.Parse(userInpdt);

        if (userSocer >= 50)
        {
            Debug.Log("50 이상의 수");
        }
        else
        {
            Debug.Log("50 미만의 수");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
