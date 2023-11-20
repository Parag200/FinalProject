using UnityEngine;
using System.Collections.Generic;


public class AchieveManager : MonoBehaviour
{
    //array is visible in the inspector
    [SerializeField]
    // Array of Achievement objects
    private Achievement[] achievements; 
   

    // Method to unlock an achievement
    public void UnlockAchievement(string achievementName)
    {
        //checks through the array for the matching name
        Achievement achievement = System.Array.Find(achievements, a => a.Name == achievementName);
        //if the achievement is not null and is not unlocked, unlock the achievement and out put the name and description of it
        if (achievement != null && !achievement.IsUnlocked)
            {
            achievement.IsUnlocked = true;
            //outputs the name of the achievement and its description in output log
            Debug.Log($"Achievement Unlocked: {achievement.Name}\nDescription: {achievement.Description}");
        }
    }
}
