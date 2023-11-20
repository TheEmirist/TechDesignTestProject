using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject button;

    void OnMouseDown()
    {
        if (button.activeSelf)
        {
            button.SetActive(false);
        }
        else
        {
            button.SetActive(true);
        }
    }
}
