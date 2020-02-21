using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Text healthDisplay;
    public float health;
    [SerializeField]
    public GameObject gameOver;
   // Update is called once per frame
    void Update()
    {
        healthDisplay.text = health.ToString();
      if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
    }
}
