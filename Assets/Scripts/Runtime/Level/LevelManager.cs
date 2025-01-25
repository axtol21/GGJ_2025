using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static LevelManager Instance;

    public static int Round { get; private set; }
    public static int EndlessLoop { get; private set; }
    public static int TotalBubbleCount { get; set; }

    [SerializeField] private List<Level> levels;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }

    public static void Reset()
    {
        Round = 0;
        EndlessLoop = 0;
    }

    public static void ClearCoroutines()
    {
        Instance.StopAllCoroutines();
    }

    public static void StartCoroutineStatic(IEnumerator routine)
    {
        Instance.StartCoroutine(routine);
    }

    public static void StartLevel()
    {
        Debug.Log($"Starting Level {Round} Loop {EndlessLoop}");

        if (Round >= Instance.levels.Count)
        {
            Round %= Instance.levels.Count;
            EndlessLoop++;
        }

        // Reset player time limit
        Instance.levels[Round].RunLevel();
    }

    public static void CompleteLevel()
    {
        Round++;

        // TODO: add player currency/unlocks to save
        // TODO: open shop UI
    }
}
