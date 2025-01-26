using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public abstract class _LevelEvent : ScriptableObject
{
    public abstract IEnumerator RunEvent();

    public static void SpawnBubble(GameObject bubblePrefab, float health, float damage, float size, float speed, float time, float money)
    {
        var bubbleObj = Instantiate(bubblePrefab);
        var bubble = bubbleObj.GetComponent<Bubble>();

        bubble.health = health;
        bubble.damageToDeal = damage;
        bubble.time = time;
        bubble.money = money;
        float scaleFactor = (GameBounds.Bounds.xMax - GameBounds.Bounds.xMin) / (GameBounds.Bounds.yMax - GameBounds.Bounds.yMin);
        bubble.transform.localScale = new Vector3(size / scaleFactor, size / scaleFactor, 1);
        bubble.transform.position = GameBounds.GetRandomPointInBounds(size / 2);

        if (speed > 0)
        {
            bubble.rb.linearVelocity = Random.insideUnitCircle.normalized * speed;
        }
    }
}
