using UnityEngine;

public static class EntryPoint
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void MainLike()
    {
        Debug.Log("mẹo mày bé");
    }
}
