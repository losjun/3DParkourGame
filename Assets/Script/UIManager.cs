using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    private static UIManager instance;
    private float score = 0;

    public Text ScoreText, StatusText;

    protected UIManager()
    {
        
    }

    public static UIManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new UIManager();
            }
            return instance;

        }
    }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }

    public void IncreaseScore(float num)
    {
        score += num;
        UpdateScoreText();
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        ScoreText.text = score.ToString();
    }


    public void SetStatus(string str)
    {
        StatusText.text = str;
    }
}
