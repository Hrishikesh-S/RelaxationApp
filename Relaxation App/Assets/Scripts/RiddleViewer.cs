using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiddleViewer : MonoBehaviour
{
    public Image renderer;
    public Sprite[] riddleSheets;
    public Sprite[] answerSheets;
    public int index;
    bool answersShowing = false;

    private void Update()
    {
        ShowImage();
    }

    public void ShowImage()
    {
        if(!answersShowing)
            renderer.sprite = riddleSheets[index];
        else
            renderer.sprite = answerSheets[index];
    }
    public void Flip()
    {
            answersShowing = !answersShowing;
    }

    public void ChangeDifficulty(int index)
    {
        this.index = index;
    }
}