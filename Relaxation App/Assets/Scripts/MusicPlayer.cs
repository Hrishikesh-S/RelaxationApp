using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    AudioSource source;
    public AudioClip[] clips;
    int clipIndex;
    public Text songName;
    public Slider progressBar;
    private bool stop = false;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
        StartAudio();
    }

    private void Update()
    {
        if (!stop)
        {
            progressBar.value += Time.deltaTime;
            if (progressBar.value >= source.clip.length)
            {
                clipIndex++;
                if (clipIndex >= clips.Length)
                    clipIndex = 0;
                StartAudio();
            }
        }    
    }

    public void StartAudio(int changeMusic = 0)
    {
        clipIndex += changeMusic;
        if (clipIndex >= clips.Length)
        {
            clipIndex = 0;
        }
        else if (clipIndex < 0)
        {
            clipIndex = clips.Length - 1;
        }

        if (source.isPlaying && changeMusic == 0)
            return;
        stop = false;

        source.clip = clips[clipIndex];
        songName.text = source.clip.name;
        progressBar.maxValue = source.clip.length;
        progressBar.value = 0;
        source.Play();
    }

    public void StopAudio()
    {
        source.Stop();
        stop = true;
    }
}