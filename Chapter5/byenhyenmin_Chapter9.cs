using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class byenhyenmin_Chapter9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //1. 1~10���� ���� �߿��� 3���� ������ �������� �ʴ� ����
        //����ϰ�, �� ������ ���� ���
        



            int �� = 0;
            for (int ���� = 1; ���� <= 10; ����++)
            {
                if (���� % 3 != 0)
                {
                    Debug.Log(����);
                    �� = �� + ����;
                }
            }
            Debug.Log($"1~10���� 3�� ����� ������ �������� ��: {��}");




            // Update is called once per frame
            void Update()
            {

            }
        }
    }
