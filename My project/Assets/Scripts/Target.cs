using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int PointValue = 1;
    public float MinSpeed = 10;
    public float MaxSpeed = 20;
    public float MaxTorque = 10;

    private Rigidbody2D _targetRb;
    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _targetRb = GetComponent<Rigidbody2D>();
        _gameManager = GameObject.Find("Gay Manager").GetComponent<GameManager>();

        _targetRb.AddForce(Vector2.up * RandomizeForce(), ForceMode2D.Impulse);
        _targetRb.AddTorque(RandomizeTorque());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private float RandomizeForce()
    {
        return Random.Range(MinSpeed, MaxSpeed);
    }

    private float RandomizeTorque()
    {
        return Random.Range(-MaxTorque, MaxTorque);
    }

    private void OnMouseDown()
    {
        Debug.Log("you clicked on" + gameObject.name);
        _gameManager.Cumin(PointValue);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);

        if(!gameObject.CompareTag("Cum"))
        {
            //Debug.Log("Game Over");
            _gameManager.GameOver();
        }
    }
}