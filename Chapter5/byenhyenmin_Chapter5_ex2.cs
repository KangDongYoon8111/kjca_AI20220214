using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class byenhyenmin_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ///���� �� ���� �Է¹޾Ƽ�
        ///�� ���� 50 �̻��� ������
        ///50�̸��� ������ �Ǵ��ϴ� ���α׷��� �����
        string userinput = "30";
        int userScore = int.Parse(userinput);
        if(userScore>49)
        {
            Debug.Log($"50�̻�");
        }
        else
        {
            Debug.Log($"50����");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
