using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dUIManager : MonoBehaviour
{
    public Text activeEnemiesText;
    public void UpdatEnemyCount()
    {
        activeEnemiesText.text = "Active Enemies: " + dSpawnManager.enemyCount;
    }
}
