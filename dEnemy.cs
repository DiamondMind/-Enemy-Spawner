using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dEnemy : MonoBehaviour
{
    private dUIManager _ui;
    public void OnEnable()
    {
        dSpawnManager.enemyCount++;
        Die();
        _ui = GameObject.Find("UIManager").GetComponent<dUIManager>();
        _ui.UpdatEnemyCount();
    }
    public void OnDisable()
    {
        dSpawnManager.enemyCount--;
        _ui.UpdatEnemyCount();
    }
   public void Die()
    {
        Destroy(this.gameObject, Random.Range(2, 6));
    }
}
