using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "HardcodedLevel_8", menuName = "Scriptable Objects/Levels/HardcodedLevel_8")]
public class HardcodedLevel_8 : _LevelEvent
{
    [SerializeField] private GameObject bubblePrefab;

    public override IEnumerator RunEvent()
    {
        yield return new WaitForSeconds(1);

        for (int i = 0; i < 20; i++)
        {
            SpawnBubble(bubblePrefab, 50, 10, Random.Range(3f, 5f), Random.Range(4.5f, 7.5f), 10, 50);
            SpawnBubble(bubblePrefab, 50, 10, Random.Range(3f, 5f), Random.Range(4.5f, 7.5f), 10, 50);
            SpawnBubble(bubblePrefab, 20, 10, Random.Range(1f, 2f), Random.Range(0.5f, 1.5f), 10, 25);
            SpawnBubble(bubblePrefab, 20, 10, Random.Range(1f, 2f), Random.Range(0.5f, 1.5f), 10, 25);
            yield return new WaitForSeconds(8);
        }
    }
}
