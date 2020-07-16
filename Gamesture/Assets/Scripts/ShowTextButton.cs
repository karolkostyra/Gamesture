using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextButton : MonoBehaviour
{
    [SerializeField] private GameObject text;
    [SerializeField] private float displayTime = 3f;

    private ButtonSettings buttonSettings;


    private void Awake()
    {
        buttonSettings = FindObjectOfType<ButtonSettings>();
    }

    public void ShowText()
    {
        StartCoroutine(ShowTextCoroutine());
    }

    private IEnumerator ShowTextCoroutine()
    {
        TextSetup(true);
        buttonSettings.SetButtonInteraction(false);
        yield return new WaitForSeconds(displayTime);
        TextSetup(false);
        buttonSettings.SetButtonInteraction(true);
    }

    private void TextSetup(bool isActive)
    {
        text.SetActive(isActive);
    }
}
