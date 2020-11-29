using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPGM.Gameplay
{
    /// <summary>
    /// A simple camera follower class. It saves the offset from the
    ///  focus position when started, and preserves that offset when following the focus.
    /// </summary>
    public class CameraController : MonoBehaviour
    {
        public Transform focus;
        public float smoothTime = 2;

        Vector3 offset;
        //카메라신바뀔때오류수정
        /*void Start()
        {
            DontDestroyOnLoad(this.gameObject); // 게임 오브젝트 파괴금지
        }*/

        void Awake()
        {
            offset = focus.position - transform.position;
        }

        void Update()
        {
            transform.position = Vector3.Lerp(transform.position, focus.position - offset, Time.deltaTime * smoothTime);
        }
    }
}