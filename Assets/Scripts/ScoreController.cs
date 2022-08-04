using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public Text kiriScore;
    public Text kananScore;
    public ScoreManager manager;

    private void Update()
    {
      kiriScore.text = manager.leftScore.ToString();
      kananScore.text = manager.rightScore.ToString();
    }

}
