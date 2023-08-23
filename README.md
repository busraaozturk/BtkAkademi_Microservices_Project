# BtkAkademi_Microservices_Project
* BtkAkademi tarafından düzenlenen Asp.Net Bootcamp final projesidir.
* Admin giriş paneli eklend ve giriş yapması sağlandı.
* Ana ekranda ürünlerin doğru bir şekilde listelenmesi sağlandı.
* Canlı Sohbet butonuna basıldığında admin ve müşteri aynı anda birbirleriyle iletişime geçebilmeleri sağlandı.

https://github.com/busraaozturk/BtkAkademi_Microservices_Project/assets/133029581/bd49cb6a-0bb5-42c4-bdb2-dc97fc367bd6
  
# Projede Kullanılan Teknolojiler
* ASP.NET CORE
* Microservis Mimarisi
* RabbitMQ
* SignalR
* Microsoft Sql Server
* Docker
* Entity Framework
* Identity Server
  
# Admin - Müşteri Sohbet Özelliği
Canlı Sohbet butonuna basıldığında admin ve müşteri tam zamanlı olarak birbirleriyle mesajlaşmaları sağlanmıştır. 
Müşteriler akıllarında oluşan soruları site yöneticilerine kolaylıkla sorup cevap alabilecekler.
Sohbet menüsünün mesaj gönderimini sağlayan kodları <b>javascript</b> ile yazılmıştır.
* SignalR teknolojisi kullanıldı.
* Müşteri hesaba giriş yapmasına gerek olmadan sorularını sorabilir.
* Müşteri ve admin birinci textboxa adlarını ikinci textboxa soru ve cevaplarını yazıp Mesajı Gönder butonuna bastığında karşı tarafa aynı zamanda gönderilecektir.
* Mesaj yazılırken karşı tarafta bekleyen kişiye "yazıyor..." şekllinde mesajın yazıldığı belirtilir.
