using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject Player;
    private List<GameObject> _player = new();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            // 생성
            GameObject p = Instantiate(Player);
            _player.Add(p);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (_player.Count == 0)
            {
                return;
            }

            // 파괴
            GameObject p = _player[_player.Count - 1];
            _player.RemoveAt(_player.Count - 1) ;
            Destroy(p);
        }
    }
}
