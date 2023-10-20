using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class timer : MonoBehaviour
{
    public int Timer = 10; // The initial value of the countdown timer
    private int InitialTimer;
    public Image image; 
    public UnityEvent onTimerEnd; // UnityEvent to be invoked when the timer ends
    private void Awake()
    {
        InitialTimer = Timer;
    }
    void Start()
    {
        StartCoroutine(Countdown());
        StartCoroutine(FillImage());
    }

    IEnumerator Countdown()
    {
        while (Timer > 0)
        {
            if (Timer > InitialTimer * 0.6)
            {
                image.color = Color.green;
            }
            else if (Timer <= InitialTimer * 0.6 && Timer > InitialTimer * 0.3)
            {
               image.color = Color.yellow;
            }
            else
            {
                image.color = Color.red;
            }

            yield return new WaitForSeconds(1f);
            Timer--;

        }
        onTimerEnd.Invoke();
    }

    IEnumerator FillImage()
    {
        float fillDuration = Timer; // Duration to fill the image in seconds
        float elapsedTime = 0f;
        float startFillAmount = image.fillAmount; // Store the initial fill amount

        while (elapsedTime < fillDuration)
        {
            elapsedTime += Time.deltaTime;
            float normalizedTime = elapsedTime / fillDuration;
            image.fillAmount = Mathf.Lerp(startFillAmount, 0f, normalizedTime);
            yield return null;
        }

        image.fillAmount = 0f; // Ensure the image is completely filled
    }
}
