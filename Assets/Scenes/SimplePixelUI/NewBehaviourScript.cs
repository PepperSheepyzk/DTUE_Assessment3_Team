using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public Text tex;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        tex.text = "得分：" + i.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Gold"))
        {
            i++;
            tex.text = "得分：" + i.ToString();
            if (i >=20)
            {
                SceneManager.LoadScene(3);
            }
            Destroy(other.gameObject);

        }
    }
}
