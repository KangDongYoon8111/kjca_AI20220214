using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class byenhyenmin_Chater5_ex3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ///���� �� ���� �Է¹޾Ƽ�,
        ///�� ���� 3�� ������� �Ǵ��ϴ�
        string user = "90";
        int userscore = int.Parse(user);
        if (userscore % 3 == 0)
        {
            Debug.Log($"3�ǹ��");
        }
        else
        {
            Debug.Log($"3�ǹ���ƴ�");
        }

    }

    // Update is called once per frame
    void Update()
    {
        



    }
}
