using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    private int _score = 0;
    private int _scoreAdd = 10;
    public static Score _instance;
    // Start is called before the first frame update
    void Start()
    {
        if (_instance == null)
        {
            _instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = _score.ToString("d6");
    }
    public void ScoreAdd()
    {
        _score += _scoreAdd;
    }
}
