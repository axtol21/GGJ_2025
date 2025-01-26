using System.Collections;
using System.Drawing;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnBubbleEvent", menuName = "Scriptable Objects/Level Events/SpawnBubbleEvent")]
public class SpawnBubbleEvent : _LevelEvent
{
    [SerializeField] private GameObject bubblePrefab;
    [SerializeField] private float health;
    [SerializeField] private float size;
    [SerializeField] private float speed;
    [SerializeField] private float time = 1.0f;
    [SerializeField] private float money = 1.0f;
    [SerializeField] private float damageToDeal;

    public override IEnumerator RunEvent()
    {
        SpawnBubble(bubblePrefab, health, damageToDeal, size, speed, time, money);

        yield break;
    }
}
