using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_Ex5 : MonoBehaviour
{
    public int Low;
    public int Max;


    // Start is called before the first frame update
    void Start()
    {
       if (Low < 1)
        {
            Debug.Log("���!");
        }
       else if (Low > 100)
        {
            Debug.Log("���!");
        }

        else if (Low >= 60)
        {
            Debug.Log("���г� �հ�");
        }

        else if (Low < 60)
        {
            Debug.Log("���г� ���հ�");
        }

        else if (Max >= 70)
        {
            Debug.Log("���г� �հ�");
        }

        else if (Max < 70)
        {
            Debug.Log("���г� ���հ�");
        }

       

    }

    // Update is called once per frame
    void Update()
    {

    }
}
