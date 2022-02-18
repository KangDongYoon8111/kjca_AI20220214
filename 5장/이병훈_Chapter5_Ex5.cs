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
            Debug.Log("경고!");
        }
       else if (Low > 100)
        {
            Debug.Log("경고!");
        }

        else if (Low >= 60)
        {
            Debug.Log("저학년 합격");
        }

        else if (Low < 60)
        {
            Debug.Log("저학년 불합격");
        }

        else if (Max >= 70)
        {
            Debug.Log("고학년 합격");
        }

        else if (Max < 70)
        {
            Debug.Log("고학년 불합격");
        }

       

    }

    // Update is called once per frame
    void Update()
    {

    }
}
