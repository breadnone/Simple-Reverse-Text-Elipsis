using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TruncateText : MonoBehaviour
{
    public Text texts;
    public int maxSize = 30;
    public bool reverseTruncate = false;
    void OnEnable()
    {
        if(!reverseTruncate)
        {
            if (texts.text.Length > maxSize)
            {
                texts.text = texts.text.Substring(0, maxSize) + "...";
            }
        }
        else
        {
            if (texts.text.Length > maxSize)
            {
                texts.text =  "..." + texts.text.Substring(texts.text.Length - maxSize, maxSize);
            }
        }
    }
}
