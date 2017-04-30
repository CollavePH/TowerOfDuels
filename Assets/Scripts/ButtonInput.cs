using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Random = System.Random;

public class ButtonInput : MonoBehaviour
{
    private ScoreManager scoreManager;
    private PlayingField playingField;

    public enum MoveType
    {
        Attack = 0,
        Defend,
        HighAttack,
        COUNT
    }

    [SerializeField]
    private MoveType moveType;
    [SerializeField]
    private MoveType beats;
    [SerializeField]
    private MoveType loseTo;

    private Random rng = new Random();
    private Sprite moveImage;

    private IEnumerator Start()
    {
        yield return null;
        scoreManager = FindObjectOfType<ScoreManager>();
        playingField = FindObjectOfType<PlayingField>();

        moveImage = GetComponent<Button>().spriteState.pressedSprite;
    }

    public void InputMove()
    {
        var cpuInput = rng.Next(0, (int)MoveType.COUNT);

        playingField.ChangeImage(moveImage, cpuInput, 0.1f);

        if (cpuInput == (int)beats)
        {
            scoreManager.IncreasePlayerScore();
            Debug.Log("YOU WIN");
        }
        else if (cpuInput == (int)loseTo)
        {
            scoreManager.IncreaseEnemyScore();
            Debug.Log("YOU LOSE");
        }
        else
            Debug.Log("DRAW");
    }
}