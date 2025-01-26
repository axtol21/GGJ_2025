using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "HardcodedLevel_9", menuName = "Scriptable Objects/Levels/HardcodedLevel_9")]
public class HardcodedLevel_9 : _LevelEvent
{
    [SerializeField] private GameObject bubblePrefab;

    public override IEnumerator RunEvent()
    {
        yield return new WaitForSeconds(1);

        SpawnBubble(bubblePrefab, 500, 10000, 10, 5, 120, 1000);

        yield return new WaitForSeconds(5);

        for (int i = 0; i < 10; i++)
        {
            SpawnBubble(bubblePrefab, 15, 20, Random.Range(4f, 5f), Random.Range(1.5f, 3.5f), 20, 50);
            yield return new WaitForSeconds(1);

            for (int j = 0; j < 3; j++)
            {
                SpawnBubble(bubblePrefab, 1, 5, Random.Range(1f, 2f), Random.Range(1.5f, 3.5f), 5, 15);
                yield return new WaitForSeconds(1);
            }

            yield return new WaitForSeconds(3);
        }
    }
}
