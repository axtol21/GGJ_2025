using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "HardcodedLevel_6", menuName = "Scriptable Objects/Levels/HardcodedLevel_6")]
public class HardcodedLevel_6 : _LevelEvent
{
    [SerializeField] private GameObject bubblePrefab;

    public override IEnumerator RunEvent()
    {
        yield return new WaitForSeconds(1);

        for (int i = 0; i < 10; i++)
        {
            SpawnBubble(bubblePrefab, 30, 10, Random.Range(1f, 2f), 0, 10, 35);
            SpawnBubble(bubblePrefab, 30, 10, Random.Range(1f, 2f), 0, 10, 35);
            SpawnBubble(bubblePrefab, 30, 10, Random.Range(2f, 3f), Random.Range(0.5f, 3.5f), 10, 35);
            SpawnBubble(bubblePrefab, 30, 10, Random.Range(2f, 3f), Random.Range(0.5f, 3.5f), 10, 35);
            yield return new WaitForSeconds(7);
        }
    }
}
