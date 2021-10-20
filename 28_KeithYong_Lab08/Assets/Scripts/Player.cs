using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player instance;
    public GameObject ScoreText;
    public int Scorecount;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.GetComponent<Text>().text = "Score: " + Scorecount;

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0, verticalInput * speed * Time.deltaTime, 0);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
