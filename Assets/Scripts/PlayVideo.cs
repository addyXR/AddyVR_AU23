using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{

    [Tooltip("The Video Player that holds the video clip to play/stop")]
    [SerializeField] VideoPlayer Video;
    [Tooltip("The Button that will play/stop the video")]
    [SerializeField] TMP_Text ButtonText;
    [Tooltip("The text to display on the button when video is playing")]
    [SerializeField] string PlayingText;
    [Tooltip("The text to display on the button when video is stopped/paused")]
    [SerializeField] string StoppedText;
    [Tooltip("Toggle to switch between play and stop/pause state")]
    [SerializeField] bool toggle;


    private void Awake()
    {
        toggle = false;
    }
    // Start is called before the first frame update
    public void VideoPlayOrStop()
    {
        toggle = !toggle;

        if (toggle)
        {
            Video.Play();
            ButtonText.text = PlayingText;
        }
        else
        {
            Video.Stop();
            ButtonText.text = StoppedText;
        }
    }

    public void VideoPlayOrPause()
    {
        toggle = !toggle;

        if (toggle)
        {
            Video.Play();
            ButtonText.text = PlayingText;
        }
        else
        {
            Video.Pause();
            ButtonText.text = StoppedText;
        }
    }
}
