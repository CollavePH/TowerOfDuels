using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private Text playerText;
    [SerializeField]
    private Text enemyText;

    private int playerScore = 0;
    private int enemyScore = 0;
    
    private void Start()
    {
        EventManager.OnGameInit.AddListener(OnGameInit);
    }

    private void OnGameInit()
    {
        playerScore = enemyScore = 0;
        playerText.text = playerScore.ToString();
        enemyText.text = enemyScore.ToString();
    }

    public void IncreasePlayerScore(int value = 1)
    {
        playerScore += value;
        playerText.text = playerScore.ToString();
    }

    public void IncreaseEnemyScore(int value = 1)
    {
        enemyScore += value;
        enemyText.text = enemyScore.ToString();
    }
}