using System.Collections;
using System.Drawing;
using UnityEngine;

[CreateAssetMenu(fileName = "HardcodedLevel_0", menuName = "Scriptable Objects/Levels/HardcodedLevel_0")]
public class HardcodedLevel_0 : _LevelEvent
{
    [SerializeField] private GameObject bubblePrefab;

    public override IEnumerator RunEvent()
    {
        yield return new WaitForSeconds(1);

        for (int i = 0; i < 10; i++)
        {
            SpawnBubble(bubblePrefab, 1, 10, 3, 0, 10, 10);
            yield return new WaitForSeconds(1.5f);
        }

        for (int i = 0; i < 10; i++)
        {
            SpawnBubble(bubblePrefab, 1, 10, 3, 0, 10, 10);
            SpawnBubble(bubblePrefab, 1, 10, 3, 0, 10, 10);
            yield return new WaitForSeconds(2);
        }

        yield break;
    }
}
