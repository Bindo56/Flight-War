using System;
using UnityEngine;

namespace FlightWar
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform player;
        [SerializeField] private float speed = 2f;

        private void Start() => transform.position = new Vector3(player.position.x, player.position.y, player.position.z);

        private void LateUpdate()
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }
}