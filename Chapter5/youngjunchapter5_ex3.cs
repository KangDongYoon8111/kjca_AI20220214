using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youngjunchapter5_ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "16";
        int useScore = int.Parse(userInput);

        if (useScore % 3 == 0)

        {
            Debug.Log("3�� ����Դϴ�.");
        }
        else
        {
            Debug.Log("3�� ����� �ƴմϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
