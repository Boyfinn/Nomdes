# Nomdes
Luo tyhjästä yksinkertaisia saamenkielen sanoja käyttämällä yksinkertaisia kielellisiä ohjeita:

![Kieliasu](/IMG/kieliasu0.png)

Alkuosa (vihreä) ja jälkiosa (punainen) esiintyvät jokaisessa sanassa eivätkä esiinny koskaan yksinään. Näiden kaikki variaatiot ovat keskenään yhteenopivia, taikka muodostaa myös kokonaisen sanan. Vihreän alkuosan edellä ei voi esiintyä muita tavuja.

Liitäntäosa (keltainen) esiintyy punaisen tavun konsonantin edellä. Keltaisen tavun jälkimmäisen konsonantin tulee vastata punaisen tavun ensimmäistä konsonanttia.

Tavulisä (Violetti) esiintyy vihreän ja keltaisen, tai vohreän ja punaisen tavun välille. Tavulisän vokaaliosa määräytyy sen mukaan mihin aiemman  tai jälkimmäisen tavun vokaali päättyy.

Päätejohtimet (Turkoosi) tulee punaisen päätetavun jälkeen.

![Kieliasu](/IMG/kieliasu0.png)

## Käyttö
Ennen käyytöä tulee tehdä ohjesanasto, johon ohjelma viittaa sanojen muodostamiseksi tavuista.
Esimerkki ohjetiedostosta:
```
[Vihreä]a,i,e,y,vo,vö,aŋ,iŋ,voŋ,vöŋ,ca,ce,co,cä,cö,ča,če,čö,čä,čö,ta,te,to,ty,tä,dja,dje,ja,je
[Punainen]i,ŋa,ŋi,ca,ci,co,cä,ča,či,čo,čä,da,di,dä,ta,ti,dja,dji,hi,ja,ji,ka,ki,ko,kä,la,li,ma,mi,na,ni,nä,njä,nji,pa,pe,pi,pä,ra,ri,sa,si,sä,ša,ši,šä,va,ve,vi,ža,že,ži,žo,žä,žö
[Keltainen]mc,nc,mč,nč,čk,dk,hk,lk,ŋk,rk,sk,šk,tk,dj,lj,nj,dv,lv,hš,kš,mš,nš,pš,rš,hs,ks,ŋs,ps,rs2,hn,šn,ht,kt,mt,nt,pt,ŋt,št,pd,vd,hl,kl,lm,rm,lŋ,hv,lv,rv,hp,mp,pp,rp,hr,pž
[Violetti]ŋa,ŋi,da,di,dä,hi,ji,ki,ma,mi,sa,si,ša,ši
[Syaani]ka,kož,k,lo,lož,ra,r,
```
Tallenna tämä nimellä `tavut.nom` samaan kansioon kuin sovellus.

Avaa sovellus, ja määritä generoitavien sanojen määrä, sekä tavujen minimi ja maksimimäärä. Ennen sanojen luomista voi myös valita mahdolliset isot alkukirjaimet, sekä edellisen kappaleen kuvan mukainen väritys. Tekstin voi kopioida leikepöydälle taikka tallentaa. Tekstin kokoa voi säätää `koko`- kentällä.
