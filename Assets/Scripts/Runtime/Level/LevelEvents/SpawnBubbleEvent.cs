using System.Collections;
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
        if (bubblePrefab.GetComponent<Bubble>() == null)
        {
            Debug.LogWarning($"Invalid bubble {bubblePrefab}.");
        }

        var bubbleObj = Instantiate(bubblePrefab);
        var bubble = bubbleObj.GetComponent<Bubble>();

        // set bubble health/etc;
        // spawn bubble randomly within screen, randomize direction;

        bubble.health = health;
        bubble.damageToDeal = damageToDeal;
        bubble.time = time;
        bubble.money = money;
        float scaleFactor = (GameBounds.Bounds.xMax - GameBounds.Bounds.xMin) / (GameBounds.Bounds.yMax - GameBounds.Bounds.yMin);
        bubble.transform.localScale = new Vector3(size / scaleFactor, size / scaleFactor, 1);
        bubble.transform.position = GameBounds.GetRandomPointInBounds(size/2);

        if (speed > 0)
        {
            bubble.rb.linearVelocity = Random.insideUnitCircle.normalized * speed;
        }

        yield break;
    }
}
