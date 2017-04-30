using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return null;
        EventManager.OnGameInit.Invoke();
    }
}
