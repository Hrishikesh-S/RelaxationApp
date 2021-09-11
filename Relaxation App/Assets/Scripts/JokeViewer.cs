using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JokeViewer : MonoBehaviour
{
    public Image renderer;
    public Sprite[] jokeSheets;
    public int index = 0;
    private void Update()
    {
        renderer.sprite = jokeSheets[index];
    }

    public void NextJoke()
    {
        index++;
        if (index >= jokeSheets.Length)
        {
            index = 0;
        }
    }
}
