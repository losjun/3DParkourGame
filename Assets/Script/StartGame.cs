using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {

    public Button buttonStraight;
    public Button buttonRotated;

    void Start()
    {
        Button btn = buttonStraight.GetComponent<Button>();
        btn.onClick.AddListener(StraightLevelClick);

        btn = buttonRotated.GetComponent<Button>();
        btn.onClick.AddListener(RotatedLevelClick);
    }


    public void StraightLevelClick()
    {  
        SceneManager.LoadScene("straightPathsLevel");
    }

    public void RotatedLevelClick()
    {
        SceneManager.LoadScene("rotatedPathsLevel");
    }
}
