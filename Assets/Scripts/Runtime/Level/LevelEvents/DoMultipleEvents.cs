using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DoMultipleEvents", menuName = "Scriptable Objects/Level Events/DoMultipleEvents")]
public class DoMultipleEvents : _LevelEvent
{
    public List<_LevelEvent> levelEvents;

    public override IEnumerator RunEvent()
    {
        foreach (var levelEvent in levelEvents)
        {
            yield return levelEvent.RunEvent();
        }
    }
}
