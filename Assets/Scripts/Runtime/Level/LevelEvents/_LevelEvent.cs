using System;
using System.Collections;
using UnityEngine;

[Serializable]
public abstract class _LevelEvent : ScriptableObject
{
    public abstract IEnumerator RunEvent();
}
