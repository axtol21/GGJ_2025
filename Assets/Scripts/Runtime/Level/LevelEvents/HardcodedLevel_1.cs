using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "HardcodedLevel_1", menuName = "Scriptable Objects/Levels/HardcodedLevel_1")]
public class HardcodedLevel_1 : _LevelEvent
{
    [SerializeField] private GameObject bubblePrefab;

    public override IEnumerator RunEvent()
    {
        yield return new WaitForSeconds(1);

        for (int i = 0; i < 10; i++)
        {
            SpawnBubble(bubblePrefab, 1, 10, Random.Range(2f, 3f), 0, 10, 15);
            yield return new WaitForSeconds(1.5f);
        }

        for (int i = 0; i < 10; i++)
        {
            SpawnBubble(bubblePrefab, 1, 10, Random.Range(2f, 3f), 0, 10, 15);
            SpawnBubble(bubblePrefab, 1, 10, Random.Range(2f, 3f), 0, 10, 15);
            yield return new WaitForSeconds(2);
        }
    }
}
