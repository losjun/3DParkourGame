using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public Constants.GameState GameState { get; set; }
    public bool boolCanSwip { get; set; }

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;

        }
    }

    protected GameManager()
    {
        GameState = Constants.GameState.Start;
        boolCanSwip = false;
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }

    }


    public void Die()
    {
        //UIManager.Instance.SetStatus(Constants.StatusDeadTapToStart);
        this.GameState = Constants.GameState.Dead;
    }

}
