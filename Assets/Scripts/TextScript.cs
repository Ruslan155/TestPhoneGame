using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextScript 
{
     #region Singleton

     public static TextScript Instance
     {
          get{
               if (_instance == null)
               {
                    _instance = new TextScript();
               }

               return _instance;
          }
     }

     private static TextScript _instance;

     #endregion

     public void EnterNumber(int numb, Text text)
     {
          if (text.text == "Номер")
          {
               FirstNumber(numb, text);
          }
          else
          {
               NextNumber(numb,text);
          }
     }
     
     public void FirstNumber(int numb, Text text)
     {
          text.text = numb.ToString();
     }

     public void NextNumber(int numb, Text text)
     {
          text.text += numb.ToString();
     }
}
