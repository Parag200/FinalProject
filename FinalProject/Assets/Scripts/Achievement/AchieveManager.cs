using UnityEngine;
using System.Collections.Generic;


public class AchieveManager : MonoBehaviour
{
    [SerializeField]
    // Array of Achievement objects
    private Achievement[] achievements; 
   

    // Method to unlock an achievement
    public void UnlockAchievement(string achievementName)
    {
        Achievement achievement = System.Array.Find(achievements, a => a.Name == achievementName);
        if (achievement != null && !achievement.IsUnlocked)
            {
            achievement.IsUnlocked = true;
            Debug.Log($"Achievement Unlocked: {achievement.Name}\nDescription: {achievement.Description}");
        }
    }
}
