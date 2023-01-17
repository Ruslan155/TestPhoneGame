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
                Debug.Log("Touch number 1");
            });
        }

        if (btn2 != null)
        {
            btn2.onClick.RemoveAllListeners();
            btn2.onClick.AddListener(() =>
            {
                Debug.Log("Touch number 2");
            });
        }

        if (btn3 != null)
        {
            btn3.onClick.RemoveAllListeners();
            btn3.onClick.AddListener(() =>
            {
                Debug.Log("Touch number 3");
            });
        }
        
        if (btn4 != null)
        {
            btn4.onClick.RemoveAllListeners();
            btn4.onClick.AddListener(() =>
            {
                Debug.Log("Touch number 4");
            });
        }
        
        if (btn5 != null)
        {
            btn5.onClick.RemoveAllListeners();
            btn5.onClick.AddListener(() =>
            {
                Debug.Log("Touch number 5");
            });
        }
        
        if (btn6 != null)
        {
            btn6.onClick.RemoveAllListeners();
            btn6.onClick.AddListener(() =>
            {
                Debug.Log("Touch number 6");
            });
        }
        
        if (btn7 != null)
        {
            btn7.onClick.RemoveAllListeners();
            btn7.onClick.AddListener(() =>
            {
                Debug.Log("Touch number 7");
            });
        }
        
        if (btn8 != null)
        {
            btn8.onClick.RemoveAllListeners();
            btn8.onClick.AddListener(() =>
            {
                Debug.Log("Touch number 8");
            });
        }
        
        if (btn9 != null)
        {
            btn9.onClick.RemoveAllListeners();
            btn9.onClick.AddListener(() =>
            {
                Debug.Log("Touch number 9");
            });
        }
        
    }
}
