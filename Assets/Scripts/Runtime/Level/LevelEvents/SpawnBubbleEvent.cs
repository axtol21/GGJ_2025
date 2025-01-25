using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnBubbleEvent", menuName = "Scriptable Objects/Level Events/SpawnBubbleEvent")]
public class SpawnBubbleEvent : _LevelEvent
{
    [SerializeField] private GameObject bubblePrefab;
    [SerializeField] private float health;
    [SerializeField] private float size;
    [SerializeField] private float speed;

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
        bubble.transform.localScale = new Vector3(size, size, 1);
        bubble.transform.position = GameBounds.GetRandomPointInBounds(size);

        if (speed > 0)
        {
            bubble.rb.linearVelocity = Random.insideUnitCircle.normalized * speed;
        }

        yield break;
    }
}
