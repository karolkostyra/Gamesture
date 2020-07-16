using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupAnimation : MonoBehaviour
{
    [SerializeField] private Animator popupAnimator;


    public void ShowPopupAnim()
    {
        popupAnimator.SetTrigger("ShowPopupAnimation");
        //popupAnimator.SetBool("RunPopupAnimation", true);
    }

    public void HidePopupAnim()
    {
        popupAnimator.SetTrigger("HidePopupAnimation");
        //popupAnimator.SetBool("RunPopupAnimation", false);
    }
}
