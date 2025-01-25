using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnRandomWeightedPoolEvent", menuName = "Scriptable Objects/SpawnRandomWeightedPoolEvent")]
public class SpawnRandomWeightedPoolEvent : _LevelEvent
{
    [SerializeField] private List<WeightedEvent> events;
    [SerializeField] private float totalWeight;

    public override IEnumerator RunEvent()
    {
        float w = (float)LevelManager.Random.NextDouble() * totalWeight;

        foreach (var weightedEvent in events)
        {
            w -= weightedEvent.weight;

            if (w <= 0)
            {
                yield return weightedEvent.levelEvent.RunEvent();
                break;
            }
        }
    }

    private void OnValidate()
    {
        totalWeight = 0;

        if (events != null)
        {
            foreach (var weightedEvent in events)
            {
                totalWeight += weightedEvent.weight;
            }
        }
    }
}

[Serializable]
public class WeightedEvent
{
    public float weight;
    public _LevelEvent levelEvent;
}