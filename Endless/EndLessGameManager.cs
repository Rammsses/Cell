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
    public �޾�ͨ��Ҫ�� �޾�ͨ��Ҫ��;
    public ����Text ����text;


    [Header("Monitor")]
    public int currentLevelIndex;
    public bool isPlaying;
    public bool ��ͨ��;
    [Header("����: ������int Ȼ���,�л��곡����ȡ����ѡ")]
    public bool temp��Ҫ�л�;   //�ֶ�������
    public int tempҪȥ�ĳ���;

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

        EventManager.Instance.AddEventListener(KeyStrings.check, ����);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            EventManager.Instance.TriggerEventListener(KeyStrings.check);

        }

        if (temp��Ҫ�л�)
        {
            if (��ͨ��)
            {
                SceneManager.LoadScene(tempҪȥ�ĳ���);

            }
        }
    }

    void ����()
    {
        if (isPlaying)
        {
            camera.play���㶯��();
            ����text.showText();
            StartCoroutine(StartFlood());
            StartCoroutine(StartUI());
            ��ͨ�� = ͨ�ؼ��();           //�ǵ��л��ؿ������ÿ�ͨ��=true��isplaying=true
            isPlaying = false;
        }

    }


    bool ͨ�ؼ��()
    {
        if (�޾�ͨ��Ҫ��.����[0] != 0)
        {
            if (checkTrigger.all����s.Count >= �޾�ͨ��Ҫ��.����[0] && checkTrigger.all����s.Count <= �޾�ͨ��Ҫ��.����[1])
            {

            }
            else
            {
                return false;
            }
        }

        if (�޾�ͨ��Ҫ��.����[0] != 0)
        {
            if (checkTrigger.all����s.Count >= �޾�ͨ��Ҫ��.����[0] && checkTrigger.all����s.Count <= �޾�ͨ��Ҫ��.����[1])
            {

            }
            else
            {
                return false;
            }
        }


        if (�޾�ͨ��Ҫ��.����[0] != 0)
        {
            if (checkTrigger.all����s.Count >= �޾�ͨ��Ҫ��.����[0] && checkTrigger.all����s.Count <= �޾�ͨ��Ҫ��.����[1])
            {

            }
            else
            {
                return false;
            }
        }

        if (�޾�ͨ��Ҫ��.����[0] != 0)
        {
            if (checkTrigger.all����s.Count >= �޾�ͨ��Ҫ��.����[0] && checkTrigger.all����s.Count <= �޾�ͨ��Ҫ��.����[1])
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
