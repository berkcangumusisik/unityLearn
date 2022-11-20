using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
     private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * Time.deltaTime;
        movement = new Vector3(x, 0f, z);
        transform.position += movement;
    }
}
/*
void Start(){
    Bu fonksiyon ilk kez çalıştırıldığında çalışır.
}
void Update(){
    Bu fonksiyon her frame çalışır.
}
print() komutu console üzerine yazı yazmayı sağlar.
* Kodlar yukarıdan aşağıya doğru okunur.

DEĞİŞKENLER
* Değişkenler verdiğmiz bilgileri depolamamızı, değiştirmemize ve bu bilgiere erişmeye olanak sağlar.
* Her değişkenin bir tipi vardır.
* Her değişkenin bir ismi vardır.
* Her değişkenin bir değeri vardır.
* Her değişkenin bir erişim belirleyicisi vardır.

Erişim Belirleyicileri
* public: Her yerden erişilebilir.
* private: Sadece bu script içerisinden erişilebilir.
* null: Sadece bu script içerisinden erişilebilir.

Veri Tipleri
* int: Tam sayılar için kullanılır.
* float: Ondalıklı sayılar için kullanılır.
* string: Metinler için kullanılır.
* bool: True/False değerler için kullanılır.

Değişken Tanımlama

erişim belirleyicisi veriTipi degiskenIsmi = deger;
public int sayi = 5;
public bool isTrue = true;
private string metin = "Merhaba Dünya";
private float ondalikliSayi = 5.5f;

VEKTÖRLER
* Vektörler içinde yön belirten üç tane float değer tutar(x,y,z).
* Vektörlere değer atarken başına "new" yazılır.
* V harfi büyük olmalıdır.
* Vektörler bir değişkendir.
* private Vector3 vektor = new Vector3(1f,2f,3f);

* HideInInspector: public değişkeni inspector üzerinde gösterme.
* SerializeField: private değişkeni inspector üzerinde göster.

* Input.GetAxis("Horizontal");: Yatay hareket için kullanılır.
* Input.GetAxis("Vertical");: Dikey hareket için kullanılır.

Time.deltaTime: Bir frame'den diğerine geçen süreyi verir. Bu sayede sabit hızda hareket eder.

*/