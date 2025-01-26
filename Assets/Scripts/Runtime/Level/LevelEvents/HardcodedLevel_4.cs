using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "HardcodedLevel_4", menuName = "Scriptable Objects/Levels/HardcodedLevel_4")]
public class HardcodedLevel_4 : _LevelEvent
{
    [SerializeField] private GameObject bubblePrefab;

    public override IEnumerator RunEvent()
    {
        yield return new WaitForSeconds(1);

        SpawnBubble(bubblePrefab, 100, 10000, 10, 0, 120, 1000);

        yield return new WaitForSeconds(5);

        for (int i = 0; i < 10; i++)
        {
            SpawnBubble(bubblePrefab, 15, 20, Random.Range(4f, 5f), 0, 20, 50);
            yield return new WaitForSeconds(1);

            for (int j = 0; j < 3; j++)
            {
                SpawnBubble(bubblePrefab, 1, 5, Random.Range(1f, 2f), 0, 5, 15);
                yield return new WaitForSeconds(1);
            }

            yield return new WaitForSeconds(6);
        }
    }
}
