using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody prb;
    public float forwardForce = 40f;

    private SwerveInput swerveInput;
    [SerializeField] private float swerveSpeed = 0.5f;
    [SerializeField] private float maxSwerve = 1f;
    private GameManager _gameManager;

    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
        swerveInput = GetComponent<SwerveInput>();
    }

    private void Update()
    {
        HandleInput();
        float swerveAmount = swerveInput.MoveFactorX * swerveSpeed * Time.deltaTime;
        swerveAmount = Mathf.Clamp(swerveAmount, -maxSwerve, maxSwerve);
        transform.Translate(swerveAmount, 0, 0);
    }

    private void FixedUpdate()
    {
        prb.AddForce(0, 0, forwardForce);
    }

    private void HandleInput()
    {
        if (prb.position.y < 4f)
        {
            _gameManager.EndGame();
        }
    }
}
