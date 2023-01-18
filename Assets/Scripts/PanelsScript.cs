using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine.UI;

public class PanelsScript 
{
    #region Singleton

    public static PanelsScript Instance
    {
        get{
            if (_instance == null)
            {
                _instance = new PanelsScript();
            }

            return _instance;
        }
    }

    private static PanelsScript _instance;

    #endregion

    public void OpenPanel(GameObject numberPanel, GameObject panel, Vector2 position)
    {
        panel.SetActive(true);
        panel.transform.DOMove(position, 1);
        numberPanel.SetActive(false);
    }

    public void ClosePanel(GameObject numberPanel, GameObject panel, Vector2 position)
    {
        panel.SetActive(false);
        panel.transform.DOMove(position, 1);
        numberPanel.SetActive(true);
    }
}
