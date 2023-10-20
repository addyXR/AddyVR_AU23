using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayAudio : MonoBehaviour
{

    [Tooltip("The Video Player that holds the audio clip to play/stop")]
    [SerializeField] AudioSource Audio;
    [Tooltip("The Button that will play/stop the audio")]
    [SerializeField] TMP_Text ButtonText;
    [Tooltip("The text to display on the button when audio is playing")]
    [SerializeField] string PlayingText;
    [Tooltip("The text to display on the button when audio is stopped/paused")]
    [SerializeField] string StoppedText;
    [Tooltip("Toggle to switch between play and stop/pause state")]
    [SerializeField] bool toggle;


    private void Awake()
    {
        toggle = false;
    }
    // Start is called before the first frame update
    public void AudioPlayOrStop()
    {
        toggle = !toggle;

        if (toggle)
        {
            Audio.Play();
            ButtonText.text = PlayingText;
        }
        else
        {
            Audio.Stop();
            ButtonText.text = StoppedText;
        }
    }

    public void AudioPlayOrPause()
    {
        toggle = !toggle;

        if (toggle)
        {
            Audio.Play();
            ButtonText.text = PlayingText;
        }
        else
        {
            Audio.Pause();
            ButtonText.text = StoppedText;
        }
    }
}