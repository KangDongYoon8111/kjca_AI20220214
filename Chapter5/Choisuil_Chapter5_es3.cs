using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choisuil_Chapter5_es3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "21";
        int userScore = int.Parse(userInput);
        string score = "";

        if (userScore % 3 == 0) {
            Debug.Log("3�� ����Դϴ�.");
        }else
        Debug.Log("3�� ����� �ƴմϴ�.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
