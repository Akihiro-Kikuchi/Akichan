using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraShaker
{
    public class CameraShake : MonoBehaviour
    {
        public GameManager Gamemanager;

        
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            int SFlag = Gamemanager.SinarioFlag;

            if (SFlag == 3)
            {

                Shake(0.05f, 0.1f);

            }
        }

        public void Shake(float duration, float magnitude)
        {
            StartCoroutine(DoShake(duration, magnitude));
        }

        private IEnumerator DoShake(float duration, float magnitude)
        {
            var pos = transform.localPosition;

            float elapsed = 0.00f;

            while (elapsed < duration)
            {
                var x = pos.x + Random.Range(-1f, 1f) * magnitude;
                var y = pos.y + Random.Range(-1f, 1f) * magnitude;

                transform.localPosition = new Vector3(x, y, pos.z);

                elapsed += Time.deltaTime;

                yield return null;
            }

            transform.localPosition = pos;
        }

    }
}
