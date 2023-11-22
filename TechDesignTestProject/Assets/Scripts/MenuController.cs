using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject menu;

    void OnMouseDown()
    {
        menu.SetActive(menu.activeSelf ^ true); // Update menu presence on mouse click
    }
}
