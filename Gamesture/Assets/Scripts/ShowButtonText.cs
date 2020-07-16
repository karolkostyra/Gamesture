using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowButtonText : MonoBehaviour
{
    [SerializeField] private GameObject text;
    [SerializeField] private Button showTextButton;
    [SerializeField] private float displayTime = 3f;

    public void ShowText()
    {
        StartCoroutine(ShowTextCoroutine());
    }

    private IEnumerator ShowTextCoroutine()
    {
        TextSetup(true);
        ButtonSetup(false);
        yield return new WaitForSeconds(displayTime);
        TextSetup(false);
        ButtonSetup(true);
    }

    private void TextSetup(bool isActive)
    {
        text.SetActive(isActive);
    }

    private void ButtonSetup(bool isActive)
    {
        showTextButton.interactable = isActive;
    }
}
