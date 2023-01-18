using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class ButtonFunc : MonoBehaviour
{
    private int numb;
    
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

    [SerializeField] private GameObject PanelMonkey;
    [SerializeField] private GameObject PanelDog;
    [SerializeField] private GameObject numberPanel;

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
                ClickAnimation(btn1);
            });
        }

        if (btn2 != null)
        {
            btn2.onClick.RemoveAllListeners();
            btn2.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(2, textBar);
                ClickAnimation(btn2);
            });
        }

        if (btn3 != null)
        {
            btn3.onClick.RemoveAllListeners();
            btn3.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(3, textBar);
                ClickAnimation(btn3);
            });
        }
        
        if (btn4 != null)
        {
            btn4.onClick.RemoveAllListeners();
            btn4.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(4, textBar);
                ClickAnimation(btn4);
            });
        }
        
        if (btn5 != null)
        {
            btn5.onClick.RemoveAllListeners();
            btn5.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(5, textBar);
                ClickAnimation(btn5);
            });
        }
        
        if (btn6 != null)
        {
            btn6.onClick.RemoveAllListeners();
            btn6.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(6, textBar);
                ClickAnimation(btn6);
            });
        }
        
        if (btn7 != null)
        {
            btn7.onClick.RemoveAllListeners();
            btn7.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(7, textBar);
                ClickAnimation(btn7);
            });
        }
        
        if (btn8 != null)
        {
            btn8.onClick.RemoveAllListeners();
            btn8.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(8, textBar);
                ClickAnimation(btn8);
            });
        }
        
        if (btn9 != null)
        {
            btn9.onClick.RemoveAllListeners();
            btn9.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(9, textBar);
                ClickAnimation(btn9);
            });
        }

        if (btn0 != null)
        {
            btn0.onClick.RemoveAllListeners();
            btn0.onClick.AddListener(() =>
            {
                TextScript.Instance.EnterNumber(0, textBar);
                ClickAnimation(btn0);
            });
        }
        
        if(btnCall != null)
        {
            btnCall.onClick.RemoveAllListeners();
            btnCall.onClick.AddListener(() =>
            {
                ClickAnimation(btnCall);
                if (textBar.text.Length > 5)
                {
                    PanelsScript.Instance.OpenPanel(numberPanel, PanelMonkey, new Vector2(0,3));
                }

                if (textBar.text.Length < 5)
                {
                    PanelsScript.Instance.OpenPanel(numberPanel, PanelDog, new Vector2(0,3));
                }
            });
        }

        if (btnReset != null)
        {
            btnReset.onClick.RemoveAllListeners();
            btnReset.onClick.AddListener(() =>
            {
                ClickAnimation(btnReset);
                if (textBar.text.Length > 5)
                {
                    PanelsScript.Instance.ClosePanel(numberPanel, PanelMonkey, new Vector2(0, 8));
                    textBar.text = "Номер";
                }

                if (textBar.text.Length < 5)
                {
                    PanelsScript.Instance.ClosePanel(numberPanel, PanelDog, new Vector2(0, 8));
                    textBar.text = "Номер";
                }
            });
        }
        
    }
    
    private void ClickAnimation(Button btn)
    {
        DOTween.Sequence().Append(btn.transform.DOScale(new Vector3(0.9f, 0.9f, 0.9f), 0.3f))
            .Append(btn.transform.DOScale(new Vector3(1, 1, 1), 0.3f));
    }
}
