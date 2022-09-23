using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class EndLessGameManager : MonoBehaviour
{
    public static EndLessGameManager GameManager_Ins;


    [Header("Component")]
    public myCamera camera;
    public CheckTrigger checkTrigger;
    public 无尽通关要求 无尽通关要求;
    public 结算Text 结算text;


    [Header("Monitor")]
    public int currentLevelIndex;
    public bool isPlaying;
    public bool 可通关;
    [Header("跳关: 先设置int 然后打勾,切换完场景再取消勾选")]
    public bool temp我要切换;   //手动跳关用
    public int temp要去的场景;

    private void Awake()
    {
        #region Inst
        if (GameManager_Ins == null)
        {
            GameManager_Ins = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
        #endregion

        currentLevelIndex = 1;

        EventManager.Instance.AddEventListener(KeyStrings.check, 结算);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            EventManager.Instance.TriggerEventListener(KeyStrings.check);

        }

        if (temp我要切换)
        {
            if (可通关)
            {
                SceneManager.LoadScene(temp要去的场景);

            }
        }
    }

    void 结算()
    {
        if (isPlaying)
        {
            camera.play结算动画();
            结算text.showText();
            StartCoroutine(StartFlood());
            StartCoroutine(StartUI());
            可通关 = 通关检测();           //记得切换关卡后重置可通关=true、isplaying=true
            isPlaying = false;
        }

    }


    bool 通关检测()
    {
        if (无尽通关要求.红球[0] != 0)
        {
            if (checkTrigger.all红球s.Count >= 无尽通关要求.红球[0] && checkTrigger.all红球s.Count <= 无尽通关要求.红球[1])
            {

            }
            else
            {
                return false;
            }
        }

        if (无尽通关要求.蓝球[0] != 0)
        {
            if (checkTrigger.all蓝球s.Count >= 无尽通关要求.蓝球[0] && checkTrigger.all蓝球s.Count <= 无尽通关要求.蓝球[1])
            {

            }
            else
            {
                return false;
            }
        }


        if (无尽通关要求.黑球[0] != 0)
        {
            if (checkTrigger.all黑球s.Count >= 无尽通关要求.黑球[0] && checkTrigger.all黑球s.Count <= 无尽通关要求.黑球[1])
            {

            }
            else
            {
                return false;
            }
        }

        if (无尽通关要求.紫球[0] != 0)
        {
            if (checkTrigger.all紫球s.Count >= 无尽通关要求.紫球[0] && checkTrigger.all紫球s.Count <= 无尽通关要求.紫球[1])
            {
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    IEnumerator StartUI()
    {
        yield return new WaitForSeconds(5f);
        UIController.instance.OnFadeIn();
    }

    IEnumerator StartFlood()
    {
        yield return new WaitForSeconds(2f);
        LiquidController.instance.OnFloodIn();
    }
}
