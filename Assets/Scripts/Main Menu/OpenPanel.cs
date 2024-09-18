using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject Panel;

    public void ShowPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }
}
