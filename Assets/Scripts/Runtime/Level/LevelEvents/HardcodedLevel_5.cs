using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "HardcodedLevel_5", menuName = "Scriptable Objects/Levels/HardcodedLevel_5")]
public class HardcodedLevel_5 : _LevelEvent
{
    [SerializeField] private GameObject bubblePrefab;

    public override IEnumerator RunEvent()
    {
        yield return new WaitForSeconds(1);

        for (int i = 0; i < 10; i++)
        {
            SpawnBubble(bubblePrefab, 20, 10, Random.Range(1f, 3f), Random.Range(0.5f, 1.5f), 10, 30);
            yield return new WaitForSeconds(1.5f);
        }

        for (int i = 0; i < 10; i++)
        {
            SpawnBubble(bubblePrefab, 20, 10, Random.Range(1f, 3f), 0, 10, 30);
            SpawnBubble(bubblePrefab, 20, 10, Random.Range(1f, 3f), 0, 10, 30);
            SpawnBubble(bubblePrefab, 20, 10, Random.Range(1f, 3f), Random.Range(0.5f, 1.5f), 10, 30);
            yield return new WaitForSeconds(3);
        }
    }
}
