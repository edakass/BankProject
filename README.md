# Banka_Otomasyonu_CSharp_DevExpress
C#(.Net Framework) Windows Form,DevExpress Components ile Banka Otomasyon Yapımı

 ->Dev Express
 
Açılımı Developer Express’tir.Program DevExpress .NET platformunun bir componenti’dir.Visual Studio ile birlikte çalışır.DevExpress bize Toolbars’ta(Ribbon Form, XtraReport, Gridler, Textler, Menüler, Temalar vb.) bir çok nesne sunar.DevExpress nesneleri DevExpressin özel “dll” lerini kullanır.

->5 tane Form Ekranı oluşturdum.Form1,FormGiris,FormMusteri,FormPersonel,FormYonetici.

->Form1 tüm formlarda olan Banka Otomasyonu yazan kısımdır.

 ->Sınıflarım;Banka,BireyselMusteri,TicariMusteri,Hesap,IBankaOzellikleri,IMusteriOzellikleri,Kisi,Muster,IRaporOzellikleri,Personel,Program,Rapor,
 
public interface IBankaOzellikleri,

Interface  IMusteriOzellikleri, 

interface IRaporOzellikleri, 

->Visual Studio da : kalıtımı bu şekilde demek.

![image](https://user-images.githubusercontent.com/61595808/136851040-d08b42c1-72af-4453-836c-1a904b445543.png)

->Metro Framework,Windows form uygulamarının görsel bir şekilde oluşturulmasını sağlayan bir programdır.

 ->BankaProject’e sağ tıkladıktan sonra gelen ekranda Manage NuGet Packages tıkladıktan sonra
 
->NuGet,geliştirme platformları için gerekli olan bir araç, geliştiricilerin yararlı kod oluşturma, paylaşma ve kullanma konusunda bir mekanizmadır. Bu tür kodlar genellikle derlenen kodu (dll 'Ler olarak) içeren "paketler" şeklinde paketlenmiştir ve bu paketleri kullanan projelerde gereken diğer içeriklerle birlikte paketlenir.

![image](https://user-images.githubusercontent.com/61595808/136851357-9fbe3eb4-c727-4409-a48b-ca9238df6f26.png)

->Browse kısmına tıklanıldıktan sonra MetroFrameWork yazdım.

![image](https://user-images.githubusercontent.com/61595808/136851384-475b9d0b-587f-4c38-9a08-6dfcaf7dbf23.png)

->Karşımıza çıkan Ekrandan install yapıyoruz.

![image](https://user-images.githubusercontent.com/61595808/136851442-7e6ba4c2-f924-4c6c-953c-cc77223b09da.png)

->Kalan işlemlerden sonra Form1 class’a kalıtım ile MetroFrom’u ekliyorum.Kütüphane kısmında da using MetroFramework.Forms; ekliyorum.

![image](https://user-images.githubusercontent.com/61595808/136851488-c3dc4abc-e666-4b38-9c35-59c17e4a2dd0.png)

->MetroFramework’un kendine ait butonları araçları var.

->Tools’tan MetroStyleManager’ı seçip işlemlerimi gerçekleştirilmesi gerekiyor.

->Form kısmında TabPane kullandım üsteki kısımlar için dev express ile.

![image](https://user-images.githubusercontent.com/61595808/136851992-6af9c6f3-b91c-4a48-981e-9cd180567d75.png)

->Anchor, ekranı küçültürken ve büyütürken tam ekran olmasını sağlar.

![image](https://user-images.githubusercontent.com/61595808/136852021-4e44781e-2104-4dba-b388-7c14fdf74cd7.png)

Bu kısımdan Top,Bottom,Left,Rght seçtim.

->Partial class:Tek bir fiziksel dosyada tutulan sınıfların parça parça farklı fiziksel dosyalarda tutulmasına imkân sağlayan bir yapıdır. Kısmi (partial) özelliği sınıf (class) için kullanılabildiği gibi, yapı (struct) ya da arayüz (interface) için de kullanılabilmektedir.

->Şifre işleminde

![image](https://user-images.githubusercontent.com/61595808/136852085-99143571-4b85-4a40-8730-cb78cb33b18e.png)

![image](https://user-images.githubusercontent.com/61595808/136852106-682a9678-8d4b-412d-9a14-ac439c9b155c.png)

Bu kısmın yıldızlı şekilde olması için,Properties kısmından PassWordChar  kısmını * yapmamız  gerekiyor.

->Form ekranlarından Bu ekranın gitmesi için.

![image](https://user-images.githubusercontent.com/61595808/136852145-5b070f66-a44f-4980-acbf-dfa1e5148b0c.png)


![image](https://user-images.githubusercontent.com/61595808/136852153-c69de56d-8c8c-4dc7-bdef-92c403722680.png)

Seçmemiz gerekiyor. 

->Visual studio mbox ve prop yazınca  tab tab yapınca  kısayolu kullanmış oluyoruz.

->Visual Studio’da Ctrl+Alt+X  araç kutusunu açmak için kullanılıyor.

->Ctrl+Alt+L ile çözüm gezginini yani yan taraftaki classlar gibi kısımları açmak için kullanılır.

->Toolbox’tan SimpleButton’u seçilmesi gerekiyor.Bu Simple Button DevExpress ile geldi.Bu butonun özelliklerinden birisi resim ekleyebiliyoruz.

![image](https://user-images.githubusercontent.com/61595808/136852295-a188d02c-0323-4b80-8a6f-3b691d196807.png)

![image](https://user-images.githubusercontent.com/61595808/136852303-fd565034-b535-44a4-aebf-0ab77a05da0b.png)

Seçtiğildiğinde bu şekilde geliyor.

![image](https://user-images.githubusercontent.com/61595808/136852360-aaa6544a-0ac2-404d-8d21-1e7e86b50ca3.png)

Ok’a tıkladıktan sonra,Image tıklanılması gerekiyor.

![image](https://user-images.githubusercontent.com/61595808/136852411-5e96ec42-4bf1-4f57-bf2d-900a48ffc9f6.png)

Bu özellikler karşımıza çıkıyor.Buradan düzenlemeleri yapılıyor.

![image](https://user-images.githubusercontent.com/61595808/136852507-e9a8fd7b-fe54-4246-a61f-6abd2f5be025.png)

 ->Burada DataGridview’ın her ekranda her defasında aynı kalması için
 
 ![image](https://user-images.githubusercontent.com/61595808/136852558-567beb5d-ce45-4ddb-a442-5c8f42ef2e99.png)

Properties kısmından Dock’da Bottom seçtim

![image](https://user-images.githubusercontent.com/61595808/136852594-088ba0bd-6d8d-4ef3-abe5-8e58c4dec0e5.png)


-->Ana Menü’ye geçmek için Geri Butonunun kodlarının tüm Form ekranlarına eklenmesi gerekiyor.
![image](https://user-images.githubusercontent.com/61595808/136852647-5d5af78d-ca9e-428c-9dba-fe177abf5b63.png)

private void simpleButton2_Click(object sender, EventArgs e)
   {
       Form1 form1 = Application.OpenForms["Form1"] as Form1;
       Panel panel1 = form1.Controls["panel1"] as Panel;
       panel1.Controls.Clear();
       FormGiris formGiris = new FormGiris(banka);
       formGiris.TopLevel = false;
       panel1.Controls.Add(formGiris);
       formGiris.Show();
       formGiris.Dock = DockStyle.Fill;
   }

->![image](https://user-images.githubusercontent.com/61595808/136852767-92a077a5-f82b-4d95-8804-116eb572042d.png)
->Üç tane girşimiz var Yönetici Girişi,Personel Girişi ve Müşteri Girişi.Yönetici Girişine direk girebiliyoruz.

 ->Yönetici personeli ekleme işlemini gerçekleştirecek,personelde müşteriyi ekleme işlemini gerçekleştirecek.

->Personel Girişine girebilmemiz için Yönetici Personel eklemesi gerekiyor.

->Müşteri Girişi için ise Personel Müşteriyi kaydetmesi gerekiyor.

->Yönetici Girişine girdikten sonra Personel Ekle,Personel Çıkar,Personel Listele ve Banka İşlem Listesi kısımlarımı tabPane DevExpress ile yaptım.

![image](https://user-images.githubusercontent.com/61595808/136852835-29c6e3fe-5970-40c1-96c0-016903ff7910.png)

->Personel Silme  işlemlerini gerçekleştirdim.

![image](https://user-images.githubusercontent.com/61595808/136852922-87f0c07b-2889-4a57-b331-657223518285.png)

->Yönetici Girişinde Eda Kaş isimli Personeli ekledim.

->Personel Girişi Ekranı için:

![image](https://user-images.githubusercontent.com/61595808/136852968-1d6f5f1b-55dd-485c-ac57-23ae6c9fcfc0.png)

![image](https://user-images.githubusercontent.com/61595808/136852983-3d94ffb5-eb51-4e23-b2ce-0fdda47f1c82.png)

->Hesap Silme İşlemleri

![image](https://user-images.githubusercontent.com/61595808/136853027-aaa88a32-548c-42d7-8e5a-44daef43d0d0.png)

![image](https://user-images.githubusercontent.com/61595808/136853045-f45ca1c2-f48d-4451-b776-7ad003dbac51.png)

->Müşteri Girişi 

Personel Giriş’inden girip Müşteri kaydettim.Kaydettikten sonra Personel Girişi ekranından geri butonuna basıp Müşteri Numarası ve Şifresiyle,Müşteri Girişi ekranına girme işlemini gerçekleştirdim.

![image](https://user-images.githubusercontent.com/61595808/136853127-08f84325-0555-491a-86e6-24b7f61883bb.png)

->Müşteri Girişe girdikten sonra karşıma Müşteri Numarasına ait olan müşterimin adı ve soyadı gelme işlemini gerçekleştirdim.

![image](https://user-images.githubusercontent.com/61595808/136853178-104b4f8b-ca4a-47c4-af54-192a882f0c64.png)

->Müşteri Ekranından ‘Para Çekme’ işlemi

![image](https://user-images.githubusercontent.com/61595808/136853208-bacd57f4-d4c7-49ca-842e-eb640194064b.png)

![image](https://user-images.githubusercontent.com/61595808/136853220-d4c66ade-122d-47f2-9ae8-d84b2cb3fd2f.png)

->Müşteri Ekranından ‘Para Yatırma’ işlemi

![image](https://user-images.githubusercontent.com/61595808/136853277-fbd2152b-a9ee-4fea-87d0-3fb746ab3e51.png)

![image](https://user-images.githubusercontent.com/61595808/136853297-dc44d5c1-5340-4180-87c4-8cf5a6b71349.png)

![image](https://user-images.githubusercontent.com/61595808/136853309-e6ddf224-0bbd-4c33-b92e-325bd33e386b.png)

->Müşteri Ekranından ‘Havale’ işlemi

![image](https://user-images.githubusercontent.com/61595808/136853341-fc9304db-6456-4d19-bbbb-b81d28308598.png)

![image](https://user-images.githubusercontent.com/61595808/136853354-df842932-4b1c-4fdb-b94b-de511fe78864.png)

->Hesap Özeti 

![image](https://user-images.githubusercontent.com/61595808/136853403-e72888d5-c98e-41fa-adcc-ca0694f2c725.png)

->Hesaplarım kısmı

![image](https://user-images.githubusercontent.com/61595808/136853444-05188cf4-ea1b-472f-80c3-04cb483f463c.png)

->Yönetici Girişi kısmı

![image](https://user-images.githubusercontent.com/61595808/136853483-3c5cd3e0-f5e7-4728-a035-b939d0df3dbb.png)
