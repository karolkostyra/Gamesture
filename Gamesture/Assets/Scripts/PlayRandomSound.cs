using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayRandomSound : MonoBehaviour
{
    [SerializeField] private Text soundButtonText;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private List<AudioClip> sounds = new List<AudioClip>();
    
    private ToggleSettings toggleSettings;


    private void Awake()
    {
        toggleSettings = FindObjectOfType<ToggleSettings>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (CanPlaySound())
        {
            soundButtonText.text = "Play sound";
        }
        else
        {
            soundButtonText.text = "Select sound first";
        }
    }

    private void PlayRandom()
    {
        if (CanPlaySound() && !audioSource.isPlaying)
        {
            AudioClip randomClip = sounds[GetRandomNumber()];
            audioSource.PlayOneShot(randomClip);
        }
    }

    private bool CanPlaySound()
    {
        return GetListOfActiveToggle().Count > 0;
    }
    
    private int GetRandomNumber()
    {
        var list = GetListOfActiveToggle();
        return list[Random.Range(0, list.Count)];
    }

    public List<int> GetListOfActiveToggle()
    {
        return toggleSettings.CheckStatusOfToggle();
    }
}
