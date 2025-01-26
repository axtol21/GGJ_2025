using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "HardcodedLevel_2", menuName = "Scriptable Objects/Levels/HardcodedLevel_2")]
public class HardcodedLevel_2 : _LevelEvent
{
    [SerializeField] private GameObject bubblePrefab;

    public override IEnumerator RunEvent()
    {
        yield return new WaitForSeconds(1);

        for (int i = 0; i < 10; i++)
        {
            SpawnBubble(bubblePrefab, 1, 10, Random.Range(1f, 2f), 0, 10, 20);
            yield return new WaitForSeconds(1.5f);
        }

        for (int i = 0; i < 10; i++)
        {
            SpawnBubble(bubblePrefab, 1, 10, Random.Range(1f, 2f), 0, 10, 20);
            SpawnBubble(bubblePrefab, 1, 10, Random.Range(1f, 3f), 0, 10, 20);
            yield return new WaitForSeconds(2);
        }
    }
}
