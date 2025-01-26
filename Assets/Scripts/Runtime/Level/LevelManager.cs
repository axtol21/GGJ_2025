using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Random = System.Random;

public class LevelManager : MonoBehaviour
{
    private static LevelManager Instance;

    public static Player PlayerInstance;

    [field: SerializeField] public static int Round { get; private set; }
    [field: SerializeField] public static int EndlessLoop { get; private set; }
    public static int TotalBubbleCount { get; set; }
    public static Random Random { get; private set; }

    [SerializeField] private List<Level> levels;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
        Random = new Random();
    }

    public static void Reset()
    {
        Round = 0;
        EndlessLoop = 0;
        Instance.StopAllCoroutines();
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

        Player.Instance.AddMoney(200 + (EndlessLoop * Instance.levels.Count + Round) * 50);
        GameUI.Instance.EnterShop();
    }
}
