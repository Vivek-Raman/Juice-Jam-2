using System;
using UnityEngine;

namespace wannaB.Gameplay.Player
{
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f;

    private Rigidbody2D _rb;

    private const float FRAMERATE_MODIFIER = 60f;

    public bool CanMove { private get; set; }

    private void Awake()
    {
        this._rb = this.GetComponent<Rigidbody2D>();
        GameManager.Player.RegisterPlayer(this);
    }

    private void Update()
    {
        if (!CanMove) return;

        float xInput = Input.GetAxis("Horizontal");
        this._rb.AddForce(Time.deltaTime * FRAMERATE_MODIFIER * movementSpeed * xInput * Vector2.right);
    }
}
}
