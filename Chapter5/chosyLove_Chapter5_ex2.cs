using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chosyLove_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "60";
        int number = int.Parse(userInput);

        if (number >= 50)
        {
            if(number%3 == 0) //3�� ����� ��
                Debug.Log($"{number}��(��) 50�̻��� ���̸� 3�� ����Դϴ�.");
            else
                Debug.Log($"{number}��(��) 50�̻��� ���̸� 3�� ����� �ƴմϴ�.");
        }
            
        else
        {
            if (number % 3 == 0) //3�� ����� ��
                Debug.Log($"{number}��(��) 50�̸��� ���̸� 3�� ����Դϴ�.");
            else
                Debug.Log($"{number}��(��) 50�̸��� ���̸� 3�� ����� �ƴմϴ�.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
