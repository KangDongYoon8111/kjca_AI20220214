using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGyuRi_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //���� �� ���� �Է¹޾Ƽ�,
        //�� ���� 50 �̻��� ������
        //50�̸��� ������
        //�Ǵ��ϴ� ���α׷��� ����� �ּ���.

       
            string userInput = "55";
        
        int num = int.Parse(userInput);

        string result = (50 <= num) ? "50�̻�" : "50�̸�";
        Debug.Log(result);

        if (50 <= num)
        {
            Debug.Log("50�̻�");
        }
        else
        {
            Debug.Log("50�̸�");
        }

















    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
