using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "HardcodedLevel_7", menuName = "Scriptable Objects/Levels/HardcodedLevel_7")]
public class HardcodedLevel_7 : _LevelEvent
{
    [SerializeField] private GameObject bubblePrefab;

    public override IEnumerator RunEvent()
    {
        yield return new WaitForSeconds(1);

        for (int i = 0; i < 20; i++)
        {
            SpawnBubble(bubblePrefab, 50, 10, Random.Range(3f, 5f), 0, 10, 40);
            SpawnBubble(bubblePrefab, 10, 10, Random.Range(2f, 3f), Random.Range(0.5f, 3.5f), 10, 20);
            SpawnBubble(bubblePrefab, 10, 10, Random.Range(2f, 3f), Random.Range(0.5f, 3.5f), 10, 20);
            SpawnBubble(bubblePrefab, 10, 10, Random.Range(2f, 3f), Random.Range(0.5f, 3.5f), 10, 20);
            SpawnBubble(bubblePrefab, 10, 10, Random.Range(2f, 3f), Random.Range(0.5f, 3.5f), 10, 20);
            yield return new WaitForSeconds(8);
        }
    }
}
