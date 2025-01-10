
using UnityEngine;

namespace FlightWar
{
    public class ParallaxController : MonoBehaviour
    {
        [SerializeField] private Transform[] bg;
        [SerializeField] private float smoothing;
        [SerializeField] private float multipler;

        private Transform cam;
        private Vector3 perviousCamPos;

        private void Awake() => cam = Camera.main.transform;

        private void Start() => perviousCamPos = cam.position;

        private void Update()
        {
            for (var i = 0; i < bg.Length; i++)
            {
                var parallax = (perviousCamPos.y - cam.position.y) * (i * multipler);
                var targetY = bg[i].position.y + parallax;
                
                var backgroundTarget = new Vector3(bg[i].position.x, targetY, bg[i].position.z);
                
                bg[i].position = Vector3.Lerp(bg[i].position, backgroundTarget, smoothing * Time.deltaTime);
            }
            perviousCamPos = cam.position;
        }
    }
}