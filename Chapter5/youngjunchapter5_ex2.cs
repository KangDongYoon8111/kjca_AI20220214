using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youngjunchapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "53";
        int useScore = int.Parse(userInput);

        if (useScore >= 50)

        {
            Debug.Log("50 이상의 수");
        }
        else
        {
            Debug.Log("50 이하의 수");
        }
    }

    // Update is called once per frame
    void Update()
    {
     

    }
}
