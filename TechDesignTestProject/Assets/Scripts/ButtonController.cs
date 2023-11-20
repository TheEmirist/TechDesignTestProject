using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject button;

    void OnMouseDown()
    {
        button.SetActive(button.activeSelf ^ true); //Update button presence on mouse click
    }
}
