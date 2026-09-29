using System;
using Unity.VisualScripting;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    EventHook eventHook;
    Action<EmptyEventArgs> OnWaveEnded;
    Action<EmptyEventArgs> OnEnemyDied;

    private void Start()
    {
        EventBus.Register(eventHook, OnWaveEnded);
        EventBus.Register(eventHook, OnEnemyDied);
    }

    private void OnDestroy()
    {
        EventBus.Unregister(eventHook, OnWaveEnded);
        EventBus.Unregister(eventHook, OnEnemyDied);
    }
}