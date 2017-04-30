using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static UnityEvent OnGameInit = new UnityEvent();
    public static UnityEvent OnUnloadScene = new UnityEvent();

    private void OnDisable()
    {
        OnGameInit.RemoveAllListeners();
        OnUnloadScene.RemoveAllListeners();
    }
}
