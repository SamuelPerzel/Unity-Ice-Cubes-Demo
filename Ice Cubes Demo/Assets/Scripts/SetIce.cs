using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetIce : MonoBehaviour
{
    [SerializeField]
    private new Rigidbody2D rigidbody;

    [SerializeField]
    private new Transform transform;

    void Start()
    {
        Vector2 randomForce = new Vector2(0f , Random.Range(-400f, -300f));

        rigidbody.rotation = Random.value * 360;
        rigidbody.AddForce(randomForce);

        transform.localScale *= Random.Range(0.85f, 1.15f);
    }
}
