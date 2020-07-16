using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSettings : MonoBehaviour
{
    [SerializeField] private Button playSoundButton;
    [SerializeField] private Toggle[] toggles;


    private void Awake()
    {
        SetToggleIsOn();
    }

    private void Update()
    {
        if (playSoundButton.interactable)
        {
            SetToggleInteraction(true);
        }
        else
        {
            SetToggleInteraction(false);
        }
    }

    private void SetToggleInteraction(bool isInteractable)
    {
        for (int i=0; i < toggles.Length; i++)
        {
            toggles[i].interactable = isInteractable;
        }
    }

    private void SetToggleIsOn()
    {
        for (int i=0; i < toggles.Length; i++)
        {
            toggles[i].isOn = true;
        }
    }

    public List<int> CheckStatusOfToggle()
    {
        List<int> list = new List<int>();

        for (int i=0; i < toggles.Length; i++)
        {
            if(toggles[i].isOn == true) { list.Add(i); }
        }

        return list;
    }
}
