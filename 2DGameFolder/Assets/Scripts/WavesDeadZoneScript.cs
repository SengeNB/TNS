using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneScript : MonoBehaviour
{
    public LogicScript logic;
    public BelugaScript beluga;
    public float deadZoneSpeed;
    public Rigidbody2D myThirdRigidbody;
    private GameObject destroyedGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myThirdRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        myThirdRigidbody.AddForce(transform.right * deadZoneSpeed, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Ocean Waves 1"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 1");
            Destroy(destroyedGameObject.gameObject);
        }
        else if (collision.gameObject.name.Equals("Ocean Waves 2"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 2");
            Destroy(destroyedGameObject.gameObject);
        }
        else if (collision.gameObject.name.Equals("Ocean Waves 3"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 3");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 4"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 4");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 5"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 5");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 6"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 6");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 7"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 7");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 8"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 8");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 9"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 9");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 10"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 10");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 11"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 11");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 12"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 12");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 13"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 13");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 14"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 14");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 15"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 15");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 16"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 16");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 17"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 17");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 18"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 18");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 19"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 19");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 20"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 20");
            Destroy(destroyedGameObject.gameObject);
        }
        else if (collision.gameObject.name.Equals("Ocean Waves 21"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 21");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 22"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 22");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 23"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 23");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 24"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 24");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 25"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 25");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 26"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 26");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 27"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 27");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 28"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 28");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 29"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 29");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 30"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 30");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 31"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 31");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 32"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 32");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 33"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 33");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 34"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 34");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 35"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 35");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 36"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 36");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 37"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 37");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 38"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 38");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 39"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 39");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 40"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 40");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 41"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 41");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 42"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 42");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 43"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 43");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 44"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 44");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 45"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 45");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 46"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 46");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 47"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 47");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 48"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 48");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 49"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 49");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 50"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 50");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 51"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 51");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 52"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 52");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 53"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 53");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 54"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 54");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 55"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 55");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 56"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 56");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 57"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 57");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 58"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 58");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 59"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 59");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 60"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 60");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 61"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 61");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 62"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 62");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 63"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 63");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 64"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 64");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 65"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 65");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 66"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 66");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 67"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 67");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 68"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 68");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 69"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 69");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 70"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 70");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 71"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 71");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 72"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 72");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 73"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 73");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 74"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 74");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 75"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 75");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 76"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 76");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 77"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 77");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 78"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 78");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 79"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 79");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 80"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 80");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 81"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 81");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 82"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 82");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 83"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 83");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 84"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 84");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 85"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 85");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 86"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 86");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 87"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 87");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 88"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 88");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 89"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 89");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 90"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 90");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 91"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 91");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 92"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 92");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 93"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 93");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 94"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 94");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 95"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 95");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 96"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 96");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 97"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 97");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 98"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 98");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 99"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 99");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 100"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 100");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 101"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 101");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 102"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 102");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 103"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 103");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 104"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 104");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 105"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 105");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 106"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 106");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 107"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 107");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 108"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 108");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 109"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 109");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 110"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 110");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 111"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 111");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 112"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 112");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 113"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 113");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 114"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 114");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 115"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 115");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 116"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 116");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 117"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 117");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 118"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 118");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 119"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 119");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 120"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 120");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 121"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 122");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 123"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 123");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 124"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 124");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 215"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 125");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 126"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 126");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 127"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 127");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 128"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 128");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 129"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 129");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 130"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 130");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 131"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 131");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 132"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 132");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 133"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 133");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 134"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 134");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 135"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 135");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 136"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 136");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 137"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 137");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 138"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 138");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 139"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 139");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 140"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 140");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 141"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 141");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 142"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 142");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 143"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 143");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 144"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 144");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 145"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 145");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 146"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 146");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 147"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 147");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 148"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 148");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 149"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 149");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 150"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 150");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 151"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 151");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 152"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 152");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 153"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 153");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 154"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 154");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 155"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 155");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 156"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 156");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 157"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 157");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 158"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 158");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 159"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 159");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 160"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 160");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 161"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 161");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 162"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 162");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 163"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 163");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 164"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 164");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 165"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 165");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 166"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 166");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 167"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 167");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 168"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 168");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 169"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 169");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 170"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 170");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 171"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 171");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 172"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 172");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 173"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 173");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 174"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 174");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 75"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 75");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 176"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 176");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 177"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 177");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 178"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 178");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 179"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 179");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 180"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 180");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 181"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 181");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 182"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 182");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 183"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 183");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 184"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 184");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 185"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 185");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 186"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 186");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 187"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 187");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 188"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 188");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 189"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 189");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 190"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 190");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 191"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 191");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 192"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 192");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 193"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 193");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 194"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 194");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 195"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 195");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 196"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 196");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 197"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 197");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 198"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 198");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 199"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 199");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 200"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 200");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 201"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 201");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 202"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 202");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 203"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 203");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 204"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 204");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 205"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 205");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 206"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 206");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 207"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 207");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 208"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 208");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 209"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 209");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 210"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 210");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 211"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 211");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 212"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 212");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 213"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 213");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 214"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 214");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 215"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 215");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 216"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 216");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 217"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 217");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 218"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 218");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 219"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 219");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 220"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 220");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 221"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 222");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 223"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 223");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 224"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 224");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 225"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 225");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 226"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 226");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 227"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 227");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 228"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 228");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 229"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 229");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 230"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 230");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 231"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 231");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 232"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 232");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 233"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 233");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 234"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 234");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 235"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 235");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 236"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 236");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 237"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 237");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 238"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 238");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 239"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 239");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 240"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 240");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 241"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 241");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 242"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 242");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 243"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 243");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 244"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 244");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 245"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 245");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 246"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 246");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 247"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 247");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 248"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 248");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 249"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 249");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 250"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 250");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 251"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 251");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 252"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 252");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 253"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 253");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 254"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 254");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 255"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 255");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 256"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 256");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 257"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 257");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 258"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 258");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 259"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 259");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 260"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 260");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 261"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 261");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 262"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 262");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 263"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 263");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 264"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 264");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 265"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 265");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 266"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 266");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 267"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 267");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 268"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 268");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 269"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 269");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 270"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 270");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 271"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 271");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 272"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 272");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 273"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 273");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 274"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 274");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 275"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 275");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 276"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 276");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 277"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 277");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 278"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 278");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 279"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 279");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 280"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 280");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 281"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 281");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 282"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 282");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 283"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 283");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 284"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 284");
            Destroy(destroyedGameObject.gameObject);
        }

        else if (collision.gameObject.name.Equals("Ocean Waves 285"))
        {
            GameObject destroyedGameObject = GameObject.Find("Ocean Waves 285");
            Destroy(destroyedGameObject.gameObject);
        }

    }
}
