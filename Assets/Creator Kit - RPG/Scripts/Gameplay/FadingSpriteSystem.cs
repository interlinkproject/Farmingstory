using System.Collections.Generic;
using UnityEngine;

namespace RPGM.Gameplay
{
    /// <summary>
    /// A system for batch animation of fading sprites.
    /// </summary>
    public class FadingSpriteSystem : MonoBehaviour
    {
        /*
        void Start()
        {
            DontDestroyOnLoad(this.gameObject); // 게임 오브젝트 파괴금지
        }*/

        void Update()
        {
            foreach (var c in FadingSprite.Instances)
            {
                if (c.gameObject.activeSelf)
                {
                    c.alpha = Mathf.SmoothDamp(c.alpha, c.targetAlpha, ref c.velocity, 0.1f, 1f);
                    c.spriteRenderer.color = new Color(1, 1, 1, c.alpha);
                }
            }
        }
    }
}