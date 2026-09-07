using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{

    [SerializeField] private float _speed = 2.5f;
    [SerializeField] private string _coinTag = "Coin";
    [SerializeField] private string _powerUp = "PowerUp";
    [SerializeField] private float _addSpeed = 1;

    private String _directCT = "DirectionC"; // direction C Tag
    private String _directBT = "DirectionB"; // direction B Tag
    private String _directAT = "DirectionA"; // direction C Tag

    private int _coins = 0;
    public int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // print("waddup");
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += (new Vector3(0, _speed, 0) * Time.deltaTime * _speed);
            transform.rotation = Quaternion.Euler(0, 270, 0);
            // transform.rotation = Quaternion.Euler(10, 0, 0);
            // transform.localScale = new Vector3(2, 2, 2);
        }

        if (Input.GetKey(KeyCode.A))
        {
            // print("ahoy");
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += (new Vector3(-_speed, 0, 0) * Time.deltaTime * _speed);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            // print("sup");
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += (new Vector3(0, -_speed, 0) * Time.deltaTime * _speed);
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            // print("dag");
            Vector3 position = new Vector3(0, 0, 0);
            transform.position += (new Vector3(_speed, 0, 0) * Time.deltaTime * _speed);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.)
    }

    */



    // collider? i hardly know her


    private void OnCollisionEnter2D(Collision2D collision)
    {
        CoinValue coinValue;
        if (collision.gameObject.CompareTag(_coinTag) && collision.gameObject.TryGetComponent<CoinValue>(out coinValue))
        {
            score += coinValue.GetScoreWorth();
            print("current score: " + score);



            Destroy(collision.gameObject);
            _coins++;
            print("You now have " + _coins + " coins, hell yeah!");
        }

        if (collision.gameObject.CompareTag(_directCT))
        {
            SceneManager.LoadScene("DirectC");
        }


        if (collision.gameObject.CompareTag(_directBT))
        {
            SceneManager.LoadScene("DirectB");
        }


        if (collision.gameObject.CompareTag(_directAT))
        {
            SceneManager.LoadScene("DirectA");
        }


        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("GameOver");
        }

    }

}
