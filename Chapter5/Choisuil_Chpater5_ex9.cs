using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choisuil_Chpater5_ex9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1~10���� ���� �߿��� 3���� ������ �������� �ʴ� ����
        //����ϰ�, �� ������ ���� ���

        int result = 0;

        for(int i = 0; i < 11; i++) {
            if(i % 3 == 0) {
                continue;
            }
            Debug.Log($"{i}");
            result += i;
    }
        Debug.Log($"1~10�� 3���� ������ �������� �ʴ� ���� �� : {result}");

}

    // Update is called once per frame
    void Update()
    {
        
    }
}
