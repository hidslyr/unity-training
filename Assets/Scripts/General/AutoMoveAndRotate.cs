using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace /*UnityStandardAssets.Utility*/AuraAPI //Original from Unity, changed namespace to avoid conflicts when importing official packages
{
    public class AutoMoveAndRotate : MonoBehaviour
    {
        public Vector3andSpace moveUnitsPerSecond;
        public Vector3andSpace rotateDegreesPerSecond;
        public bool ignoreTimescale;
        private float m_LastRealTime;
        public bool canRandomRot;

        private float _timestamp;

        private void Start()
        {
            m_LastRealTime = Time.realtimeSinceStartup;
            _timestamp = Time.time;

            if (canRandomRot)
            {
                rotateDegreesPerSecond.value = new Vector3(Random.Range(-360, 360),
                                                           Random.Range(-360, 360),
                                                           Random.Range(-360, 360));
            }
        }


        // Update is called once per frame
        private void Update()
        {
            //if (GamePlay.Instance.gamePlayState == GamePlay.GamePlayState.Paused)
            //    return;

            float deltaTime = Time.deltaTime;
            //float deltaTime = Time.time - _timestamp;
            //_timestamp = Time.time;
            if (ignoreTimescale)
            {
                deltaTime = (Time.realtimeSinceStartup - m_LastRealTime);
                m_LastRealTime = Time.realtimeSinceStartup;
            }
            transform.Translate(moveUnitsPerSecond.value*deltaTime, moveUnitsPerSecond.space);
            transform.Rotate(rotateDegreesPerSecond.value*deltaTime, rotateDegreesPerSecond.space);
        }


        [Serializable]
        public class Vector3andSpace
        {
            public Vector3 value;
            public Space space = Space.Self;
        }
    }
}
