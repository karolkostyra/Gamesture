using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSettings : MonoBehaviour
{
    [SerializeField] private Button[] buttons;

    public void SetButtonInteraction(bool isInteractable)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = isInteractable;
        }
    }
}
