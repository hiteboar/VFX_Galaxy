using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TMPro.TextMeshProUGUI))]
public class setValue : MonoBehaviour
{

    TMPro.TextMeshProUGUI m_TextMeshProUGUI;

    // Start is called before the first frame update
    void Awake()
    {
        m_TextMeshProUGUI = GetComponent<TMPro.TextMeshProUGUI>();
    }

    public void SetValue(float value)
    {
        m_TextMeshProUGUI.SetText(value.ToString());
    }

}
