using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update

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
