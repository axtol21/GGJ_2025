using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static LevelManager Instance;

    public static int Round { get; private set; }
    public static int EndlessLoop { get; private set; }

    [SerializeField] private List<Level> levels;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void Reset()
    {
        Round = 0;
        EndlessLoop = 0;
    }
}
