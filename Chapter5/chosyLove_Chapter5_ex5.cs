using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chosyLove_Chapter5_ex5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "4";
        string userInput1 = "61";
        int sy = int.Parse(userInput);
        int score = int.Parse(userInput1);

        if (sy == 4)
        {
            if (score >= 70 && score <= 100)
                Debug.Log($"{sy}�г� {score}�� - �հ�");
            else if (score < 70 && score >= 0)
                Debug.Log($"{sy}�г� {score}�� - ���հ�");
            else
                Debug.Log($"{sy}�г� {score}�� - ��� �ٽ� �Է��ϼ���.");
        }
        else
        {
            if (score >= 60 && score <= 100)
                Debug.Log($"{sy}�г� {score}�� - �հ�");
            else if (score < 60 && score >= 0)
                Debug.Log($"{sy}�г� {score}�� - ���հ�");
            else
                Debug.Log($"{sy}�г� {score}�� - ��� �ٽ� �Է��ϼ���.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
