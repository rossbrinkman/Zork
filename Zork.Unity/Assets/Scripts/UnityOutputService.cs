using System;
using Zork.Common;
using UnityEngine;
using TMPro;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    public void Write(object value)
    {
        throw new NotImplementedException();
    }

    public void WriteLine(object value)
    {
        TMP_Text newOutputText = Instantiate(OutputText);
        newOutputText.text = value.ToString();
        newOutputText.transform.SetParent(parent);

        if(parent.childCount > 60)
        {
            DestroyImmediate(parent.GetChild(0).gameObject);
        }
    }

    [SerializeField]
    private TMP_Text OutputText;

    [SerializeField]
    private RectTransform parent;
}
