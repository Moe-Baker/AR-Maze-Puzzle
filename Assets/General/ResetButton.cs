using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;
#endif

using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace Game
{
    [RequireComponent(typeof(Button))]
	public class ResetButton : MonoBehaviour
	{
        void Start()
        {
            GetComponent<Button>().onClick.AddListener(Click);
        }

        void Click()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}