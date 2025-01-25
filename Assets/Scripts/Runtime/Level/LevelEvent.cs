using System;
using System.Collections;
using UnityEngine;

[Serializable]
public abstract class LevelEvent : ScriptableObject
{
    public abstract IEnumerator RunEvent();
}
