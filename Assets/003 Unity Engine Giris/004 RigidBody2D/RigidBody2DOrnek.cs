using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBody2DOrnek : MonoBehaviour
{
    /*
                RigidBody2D 
    
    RigidBody Component'i, unity fizik motorunu kullanarak gercek dunyada oldugu gibi fiziksel hareketlerin taklit edilmesini saglar.

    Yercekimi yuzunden nesnelerin asagi dusmesi, yuvarlak objelerin yuvarlanmasi, koseli objelerin sabit kalmasi gibi hareketleri dusunebiliriz.
    Bu component sayesinde objelere gercekci sekilde hareket yetenegi verebiliyoruz.
    Ornegin bir araba modelinde, tekerlere dondurme kuvveti (tork) uygulayarak arabanin ilerlemesi saglanabilir ve rotasyonunu degistirerek saga sola hareket ettirebiliriz.
      
        Body Type :
    Dynamic : oyun nesneleri tamamiyle oyun motoru tarafindan(inputlarla) calistirilir. 
    Dynamic oyun nesnelerinin hareketi kuvvet hız ve benzeri faktorlerden etkilenir. Kullanim durumu : oyun karakterleri ya da hareketli oyun 
nesneleri.
    Kinematic : Kinematik oyun nesneleri tamamen komut dosyalari tarafindan yonlendirilir. Orn: MoveController. Bu nedenle hareket bolumunu manuel 
olarak ele almamiz gerekir. BURASI EKSİK!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

    Static : Objelere bagli hicbir gercek rigidBody bileseni yoktur. Bu nedenle fizik motoru onlari hareketli olarak gormez. Onlara hicbir carpisma 
uygulanmaz. OnTrigger ve OnCollision calismayacaktir!. Kullanim durumlari : zemin, duvarlar ve carpismasini istemedigimiz diger oyun objeleri 

        Simulated:
    Fizigi simule etmek. Tikli kalsin birak. 
        
        Use Auto Mass : 
    Objeye yanindaki nesnelere göre kutle verir.

        Mass : 
    RigidBody'nin kutlesini verdigimiz yer.

        Linear Drag : 
    Positional surtunmeyi belirliyor.

        Angular Drag : 
    Rotational surtunmeyi belirtir. 

        Gravity Scale :
    Objenin yercekiminden etkilenme katsayisi

        Collision Detection :
    Discrete : Bu secenegi sectigimizde rigidBodyleri ve collisionlari olan gameobjectler hareket ediyorsa fizik guncellemesi sirasinda ust uste 
gelebilir veya birbirinin icinden gecebilir .
    Continuous : Bu secenek secildiginde rigidBody'si ve collision'u olan objeler carpisma sirasinda birbirlerinin icerisinden gecmezler. Bunun yerine 
unity rigidBodylerden herhangi birinin ilk etki noktasini hesaplar ve gameObjecti oraya tasir . (bu secenek cpu yorar.) (maliyetli) Bu secenek biraz 
fazla cpu maliyeti gerektirir. 

        Sleeping Mode : Fizik islemlerinin ne zaman uygulanabilir hale gelmesini soyler. 
    Never Sleep : Oyun baslamamis dahi olsa calisir. 
    Start Awake : oyun baslamasiyla baslar
    Start Asleep : temas olmadikca uyur temas aninda uyanir. 


        Interpolate : 3d objelerde collisionlarla temas ettiginde sarsinti yasarlar bunu isaretledigimizde yumusatir. 3d'de gorecegiz.
Hareket GameObjenin onceki karelerdeki konumuna gore yumusatilir.
        Extrapolate : hareket sonraki karede konuma tahmine dayali calisir. 

        Freeze Position : x te ve y de fizigin islem yapmasini engelliyoruz 
        Freeze Rotation : bunda da acisal olarak hareket etmesini engelliyoruz.
     */
}