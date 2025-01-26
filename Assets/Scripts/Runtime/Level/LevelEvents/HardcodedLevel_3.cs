using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "HardcodedLevel_3", menuName = "Scriptable Objects/Levels/HardcodedLevel_3")]
public class HardcodedLevel_3 : _LevelEvent
{
    [SerializeField] private GameObject bubblePrefab;

    public override IEnumerator RunEvent()
    {
        yield return new WaitForSeconds(1);

        for (int i = 0; i < 10; i++)
        {
            SpawnBubble(bubblePrefab, 15, 20, Random.Range(4f, 5f), 0, 20, 50);
            yield return new WaitForSeconds(0.5f);

            for (int j = 0; j < 3; j++)
            {
                SpawnBubble(bubblePrefab, 1, 5, Random.Range(1f, 2f), 0, 5, 15);
                yield return new WaitForSeconds(0.5f);
            }

            yield return new WaitForSeconds(2);
        }

        for (int i = 0; i < 10; i++)
        {
            SpawnBubble(bubblePrefab, 15, 20, Random.Range(4f, 5f), 0, 20, 50);
            SpawnBubble(bubblePrefab, 15, 20, Random.Range(4f, 5f), 0, 20, 50);

            yield return new WaitForSeconds(0.5f);

            for (int j = 0; j < 3; j++)
            {
                SpawnBubble(bubblePrefab, 1, 5, Random.Range(1f, 2f), 0, 5, 15);
                yield return new WaitForSeconds(0.5f);
            }

            yield return new WaitForSeconds(2);
        }
    }
}
