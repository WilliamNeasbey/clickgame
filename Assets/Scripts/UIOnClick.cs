using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOnClick : MonoBehaviour
{
    public GameObject uiPanel;

    private void OnMouseDown()
    {
        uiPanel.SetActive(true);
    }
}
