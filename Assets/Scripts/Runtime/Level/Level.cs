using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "Scriptable Objects/Level")]
[Serializable]
public class Level : ScriptableObject
{
    [SerializeField] private List<LevelStep> levelEvents;

    public void RunLevel()
    {
        LevelManager.StartCoroutineStatic(LevelCoroutine());
    }

    private IEnumerator LevelCoroutine()
    {
        var levelStartTime = Time.time;

        foreach (var step in levelEvents)
        {
            yield return step.LevelStepRoutine();
        }

        while (LevelManager.TotalBubbleCount > 0)
        {
            yield return new WaitForSeconds(0.5f);
        }

        LevelManager.CompleteLevel();
    }
}

[Serializable]
public class LevelStep
{
    [SerializeField] private float time;
    [SerializeField] private _LevelEvent levelEvent;

    public IEnumerator LevelStepRoutine()
    {
        if (time > 0)
        {
            yield return new WaitForSeconds(time);
        }
        yield return levelEvent.RunEvent();
    }
}