using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiyhounghwa_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //���� �� ���� �Է¹޾Ƽ�, 
        // �� ���� 50 �̻��� ������
        //50�̸��� ������
        //�Ǵ��ϴ� ���α׷��� ����� �ּ���.

        string userinput = "53";

        int number = int.Parse(userinput);


        if (number > 50)
        {
            Debug.Log("50�̻��Ǽ�");
        }

      

       

        else { Debug.Log("50�̸��Ǽ�"); }


      



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
