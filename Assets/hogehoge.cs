using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hogehoge : MonoBehaviour
{
    //先ほど作成したクラス
    public SerialHandler serialHandler;
    [SerializeField] GameObject gameobject;

    void Start()
    {
        //信号を受信したときに、そのメッセージの処理を行う
        serialHandler.OnDataReceived += OnDataReceived;
    }

    //受信した信号(message)に対する処理
    void OnDataReceived(string message)
    {
        Debug.Log(message);
        if (int.Parse(message) == 1)
        {
            gameobject.transform.Translate(0.1f, 0, 0);
        }
        else
        {
            gameobject.transform.Translate(-0.1f, 0, 0);
        }
    }
}