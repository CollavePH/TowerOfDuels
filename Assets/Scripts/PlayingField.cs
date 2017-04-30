using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayingField : MonoBehaviour
{
    [SerializeField]
    private Image playerImage;
    [SerializeField]
    private Image cpuImage;

    [SerializeField]
    private Sprite[] cpuSprites;

    private void Start()
    {
        EventManager.OnGameInit.AddListener(OnGameInit);
    }

    private void OnGameInit()
    {

    }

    public void ChangeImage(Sprite sprite, int cpuIndex, float delay = 0.15f)
    {
        StartCoroutine(ChangeImage_IEnum(sprite, cpuIndex, delay));
    }

    private IEnumerator ChangeImage_IEnum(Sprite sprite, int cpuIndex, float delay)
    {
        yield return null;
        playerImage.CrossFadeAlpha(0f, 0f, true);
        cpuImage.CrossFadeAlpha(0f, 0f, true);

        yield return new WaitForSeconds(delay);
        playerImage.CrossFadeAlpha(1f, delay, true);
        cpuImage.CrossFadeAlpha(1f, delay, true);
        playerImage.sprite = sprite;
        cpuImage.sprite = cpuSprites[cpuIndex];
    }
}
