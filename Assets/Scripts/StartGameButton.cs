using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
    {
        public void FixedUpdate()
        {
            transform.Rotate(1,1,1);
        }

        public void HoverStart()
        {
            transform.localScale = Vector3.one * 1.1f;
        }

        public void HoverEnd()
        {
            transform.localScale = Vector3.one;
        }

        public void ClickStart()
        {
            MeshRenderer mr = GetComponent<MeshRenderer>();
            mr.material.color = Color.grey;
        }

        public void EndClick()
        {
            MeshRenderer mr = GetComponent<MeshRenderer>();
            mr.material.color = Color.white;
        }

        public void Click()
        {

            SceneManager.LoadScene("GameScene");
        }
    }
