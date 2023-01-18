using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunc : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button btn1;
    [SerializeField] private Button btn2;
    [SerializeField] private Button btn3;
    [SerializeField] private Button btn4;
    [SerializeField] private Button btn5;
    [SerializeField] private Button btn6;
    [SerializeField] private Button btn7;
    [SerializeField] private Button btn8;
    [SerializeField] private Button btn9;
    [SerializeField] private Button btn0;
    [SerializeField] private Button btnCall;
    [SerializeField] private Button btnReset;

    [SerializeField] private Text textBar;

    private void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        if (btn1 != null)
        {
            btn1.onClick.RemoveAllListeners();
            btn1.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(1, textBar);
            });
        }

        if (btn2 != null)
        {
            btn2.onClick.RemoveAllListeners();
            btn2.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(2, textBar);
            });
        }

        if (btn3 != null)
        {
            btn3.onClick.RemoveAllListeners();
            btn3.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(3, textBar);
            });
        }
        
        if (btn4 != null)
        {
            btn4.onClick.RemoveAllListeners();
            btn4.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(4, textBar);
            });
        }
        
        if (btn5 != null)
        {
            btn5.onClick.RemoveAllListeners();
            btn5.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(5, textBar);
            });
        }
        
        if (btn6 != null)
        {
            btn6.onClick.RemoveAllListeners();
            btn6.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(6, textBar);
            });
        }
        
        if (btn7 != null)
        {
            btn7.onClick.RemoveAllListeners();
            btn7.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(7, textBar);
            });
        }
        
        if (btn8 != null)
        {
            btn8.onClick.RemoveAllListeners();
            btn8.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(8, textBar);
            });
        }
        
        if (btn9 != null)
        {
            btn9.onClick.RemoveAllListeners();
            btn9.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(9, textBar);
            });
        }

        if (btn0 != null)
        {
            btn0.onClick.RemoveAllListeners();
            btn0.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(0, textBar);
            });
        }
        
        if(btnCall != null)
        {
            btnCall.onClick.RemoveAllListeners();
            btnCall.onClick.AddListener(() =>
            {
                Debug.Log("Call");
            });
        }

        if (btnReset != null)
        {
            btnReset.onClick.RemoveAllListeners();
            btnReset.onClick.AddListener(() =>
            {
                Debug.Log("Reset");
            });
        }
        
    }
}
