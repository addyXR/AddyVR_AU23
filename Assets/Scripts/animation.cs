using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class animation : MonoBehaviour
{
    public Animator animator;
    public TMP_Text buttonText;
    public bool toggle;

    public void PlayAnimation()
    {
        toggle = !toggle;

        if (toggle)
        {
            animator.SetBool("isOpened", true);
            buttonText.text = "Close";
        }

        else
        {
            animator.SetBool("isOpened", false);
            buttonText.text = "Open";
            
        }
    }
}
