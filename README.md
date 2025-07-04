# Hızlı Ürün Arama ve Envanter Yönetim Sistemi
Bu proje, ürünlerin envanterini yönetmek için kullanılan bir uygulamadır. Proje, AVL Ağaçları, Hash Tabloları, Bağlı Listeler ve Stack gibi veri yapıları kullanarak ürünlerin hızlıca eklenmesi, silinmesi, güncellenmesi ve sıralanması işlemlerini gerçekleştirmektedir.

## İçindekiler
- [Proje Hakkında](#proje-hakkında)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Görsel Arayüz](#görsel-arayüz)
- [Veri Yapıları](#veri-yapıları)
- [Performans Testleri](#performans-testleri)
- [Katkı](#katkı)
- [Lisans](#lisans)

## Proje Hakkında
Bu proje, envanter yönetim sistemini optimize etmek amacıyla 3 farklı veri yapısını birleştirir:

- **AVL Ağacı**: Ürünleri sıralı bir şekilde tutar ve hızlı sıralama ve arama işlemleri sağlar.
- **Hash Tablosu**: Ürünlere ID'ye göre hızlı erişim sağlar.
- **Bağlı Liste**: Ürünleri eklenme sırasına veya stok miktarına göre sıralayarak yönetir.
- **Stack**: Son yapılan işlemleri geri almayı sağlar (Undo özelliği).

Bu yapılar birlikte çalışarak, her birinin avantajlarından yararlanır ve ürünlerin envanteri üzerinde verimli bir şekilde işlemler yapar.

Proje, kullanıcı dostu bir **Windows Forms** arayüzü ile birlikte gelmektedir. Arayüz, ürün ekleme, arama, güncelleme ve silme gibi işlemleri kolayca yapmanıza olanak tanır. Ayrıca, ürünler sıralanabilir, fiyatları güncellenebilir ve stok miktarları yönetilebilir.

## Kullanılan Teknolojiler
- **C# (.NET Framework)**
- **Windows Forms (GUI)**: Kullanıcı arayüzü için
- **IDE**: Visual Studio

## Kurulum
### Gereksinimler:
- **Visual Studio** (veya tercihinize göre başka bir C# IDE)
- **.NET Framework** (Proje .NET Core veya .NET Framework kullanılarak yapılabilir)

### Adımlar:
1. Bu projeyi klonlayın:
    ```bash
    git clone https://github.com/elifsudeyilmaz/UrunYonetimSistemi.git
    ```

2. Proje dosyasını Visual Studio’da açın.

3. Bağımlılıkları yükleyin ve projeyi çalıştırın.

## Kullanım
1. **AVL Ağacı ile Ürün Yönetimi**
   - Ürünler fiyatlarına göre sıralı bir şekilde AVL ağacına eklenir.
   - Fiyat, ID veya isimle arama yapılabilir.
   - Fiyat güncellenebilir ve sıralı listeleme yapılabilir.

2. **Hash Tablosu ile Hızlı ID Arama**
   - Ürünler, ID'ye göre hash tablosu aracılığıyla hızlı bir şekilde eklenir, aranır ve silinir.

3. **Bağlı Liste ile Stok Bazlı Yönetim**
   - Ürünler, stok miktarına göre sıralanarak eklenebilir.
   - Stok güncellemeleri yapılabilir.
    
4. **Stack ile Geri Alma (Undo)**
   - Yapılan işlemler (ekleme, silme, güncelleme) bir yığına kaydedilir.
   - "Geri Al" butonu ile son işlem geri alınabilir.
   - Bu sayede yanlış yapılan işlemler kolayca iptal edilebilir.

## Görsel Arayüz
Proje, kullanıcı dostu bir görsel arayüz sunar. Windows Forms kullanılarak geliştirilen bu arayüzde:
- Ürün ekleme, arama, güncelleme ve silme işlemleri için butonlar bulunur.
- Arama sonuçları ve ürün listelemeleri **DataGridView** aracılığıyla görsel olarak gösterilir.
- Kullanıcılar, ürünler üzerinde işlem yaparken görsel geri bildirimler alır ve uygulama üzerinden işlemlerini rahatça gerçekleştirebilirler.

## Veri Yapıları
### 1. AVL Ağacı
- Ürünler, fiyatlarına göre sıralanır.
- Dengeyi koruyarak O(log n) karmaşıklıkla hızlı sıralama ve arama işlemleri yapılır.
- Kullanıcı adıyla veya ID ile ürün araması yapılabilir.

### 2. Hash Tablosu
- Ürünler ID'ye göre hash fonksiyonu ile yerleştirilir.
- Çakışmaları çözmek için bağlı liste kullanılır.
- O(1)'lik zaman karmaşıklığıyla hızlı erişim sağlanır.

### 3. Bağlı Liste
- Ürünler, eklenme sırasına veya stok miktarına göre sıralı bir şekilde tutulur.
- Listeye ürün eklemek ve silmek O(n) karmaşıklıkla yapılır.
- Stok güncelleme ve sıralama işlemleri yapılabilir.

### 4. Stack (Yığın)
- İşlem geçmişi tutma
- O(1) geri alma işlemi

## Performans Testleri
Proje, farklı veri yapılarının büyük veri setleri üzerinde nasıl performans gösterdiğini test etmek için bazı performans testleri içerir.

1. **Büyük Veri Testi (Big Data Test)**: 
   - Rastgele ürünler eklenerek işlem süresi ölçülür.

2. **Arama Testi**: 
   - Ürün ID'leri rastgele seçilir ve arama performansı ölçülür.

3. **Silme Testi**: 
   - Ürünler rastgele silinir ve silme işleminin süresi ölçülür.

Testler, MessageBox ile sonuçlar gösterilir.

## Katkı
Bu projeye katkı sağlamak isterseniz, pull request göndererek veya yeni özellikler önererek katkıda bulunabilirsiniz. Her türlü geri bildirim ve iyileştirme önerileri memnuniyetle karşılanacaktır.

## Lisans
Bu proje MIT Lisansı ile lisanslanmıştır.
