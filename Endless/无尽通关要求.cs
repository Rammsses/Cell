using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class �޾�ͨ��Ҫ�� : MonoBehaviour
{
    public int[] ���� = new int[2] { Random.Range(5, 8), Random.Range(11, 14) };
    public int[] ���� = new int[2] { Random.Range(4, 6), Random.Range(8, 10) };
    public int[] ���� = new int[2] { Random.Range(2, 4), Random.Range(6, 8) };
    public int[] ���� = new int[2] { Random.Range(0, 2), Random.Range(4, 6) };
    // Start is called before the first frame update
    void Start()
    {
        if (EndLessGameManager.GameManager_Ins)
        {
            EndLessGameManager.GameManager_Ins.�޾�ͨ��Ҫ�� = this;
        }
    }

}
