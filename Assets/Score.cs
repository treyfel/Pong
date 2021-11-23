using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    private int _scoreRight;
    private int _scoreLeft;
    private Text _score;

    private void Start()
    {
        _scoreRight = _scoreLeft = 0;
        _score = gameObject.GetComponent<Text>();
    }

    private void Update() {
        
        _score.text = $"{_scoreLeft} : {_scoreRight}";
    }
    public void increase_right()
    {
        _scoreRight += 1;
    }
    public void increase_left()
    {
        _scoreLeft += 1;
    }

}
