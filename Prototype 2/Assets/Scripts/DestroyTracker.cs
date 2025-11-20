using System;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class DestroyTracker : MonoBehaviour
{
    private static int destroyedCount = 0; // Static to track across instances

    // Method to increment the counter when a GameObject is destroyed
    public static void IncrementDestroyedCount()
    {
        destroyedCount++;
    }

    // Optional: Access the count from other scripts
    public static int GetDestroyedCount()
    {
        return destroyedCount;
    }
}
