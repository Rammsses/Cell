using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 无尽通关要求 : MonoBehaviour
{
    public int[] 红球 = new int[2] { Random.Range(5, 8), Random.Range(11, 14) };
    public int[] 蓝球 = new int[2] { Random.Range(4, 6), Random.Range(8, 10) };
    public int[] 紫球 = new int[2] { Random.Range(2, 4), Random.Range(6, 8) };
    public int[] 黑球 = new int[2] { Random.Range(0, 2), Random.Range(4, 6) };
    // Start is called before the first frame update
    void Start()
    {
        if (EndLessGameManager.GameManager_Ins)
        {
            EndLessGameManager.GameManager_Ins.无尽通关要求 = this;
        }
    }

}
