# 🚀 C# Eğitim Kampı & OOP Pratikleri

Temel C# programlama yapılarından başlayarak karar mekanizmaları, döngüler, algoritmalar, metotlar ve veritabanı CRUD operasyonlarına kadar geliştirilen pratikleri içeren kapsamlı bir çalışma reposudur.

---

## 🛠️ Kullanılan Teknolojiler ve Araçlar

- **Dil:** C# (.NET Framework / .NET Core)
- **Geliştirme Ortamı:** Visual Studio
- **Veritabanı:** MS SQL Server
- **Veri Erişimi:** ADO.NET
- **Mimari / Yapı:** Console Applications & Çoklu Proje Mimarisi

---

## 📂 Proje İçeriği ve Başlıklar

| No | Proje Adı | Kapsanan Konular | Açıklama |
| :---: | :--- | :--- | :--- |
| **01** | `01_MainSubjects` | Temel Sözdizimi | Konsol çıktı komutları (`Console.Write`, `Console.WriteLine`), temel değişken tanımları |
| **02** | `02_Variables` | Değişkenler & Veri Tipleri | Metinsel/sayısal tipler (`string`, `int`, `double`, `char`), tip dönüşümleri |
| **03** | `03_MakingDecision` | Karar Yapıları | `if-else` koşulları, mantıksal operatörler, `switch-case` yapıları |
| **04** | `04_Loops` | Temel Döngüler | `for` ve `while` döngüleri, sayaç mantığı ve iterasyonlar |
| **05** | `05_LoopsWithStars`| Algoritmik Desenler | İç içe döngüler ile yıldız desenleri, dik üçgen ve baklava dilimi algoritmaları |
| **06** | `06_Arrays` | Diziler (Arrays) | Tek boyutlu diziler, dizi tanımlama, eleman atama ve sıralama metotları |
| **07** | `07_ForeachLoops` | Koleksiyon Gezinimi | `foreach` döngüsü kullanımı, dizi ve liste elemanlarını listeleme |
| **08** | `08_Methods` | Metotlar (Fonksiyonlar) | Geriye değer döndüren/döndürmeyen (`void`) metotlar, parametre kullanımı |
| **09** | `09_DataBaseProject`| Veritabanı Temelleri | ADO.NET ile SQL Server bağlantısı (`SqlConnection`), sorgu çalıştırma (`SqlCommand`) |
| **10** | `10_DatabaseCrud` | CRUD Operasyonları | SQL üzerinde Ekleme (Create), Listeleme (Read), Güncelleme (Update) ve Silme (Delete) işlemleri |

---

## 💻 Kurulum ve Çalıştırma

1. **Repoyu Klonlayın:**
```bash
git clone [https://github.com/dilaraaozcan/CSharpEgitimKampi.git](https://github.com/dilaraaozcan/CSharpEgitimKampi.git)
```

2. **Projeyi Açın:**
   `CSharpEgitimKampi.sln` çözüm dosyasını Visual Studio ile açın.

3. **Veritabanı Ayarları (09 & 10 için):**
   Projelerdeki `SqlConnection` bağlantı dizesini (`connection string`) kendi yerel MS SQL Server sunucu bilginize göre güncelleyin:
```csharp
SqlConnection connection = new SqlConnection("Data Source=SUNUCU_ADINIZ;Initial Catalog=EgitimKampiDb;Integrated Security=True");
```

4. **Çalıştırma:**
   - İncelemek veya çalıştırmak istediğiniz projenin üzerine Solution Explorer'da sağ tıklayın.
   - **"Set as Startup Project"** (Başlangıç Projesi Olarak Ayarla) seçeneğini seçin.
   - `Ctrl + F5` veya `F5` tuşuna basarak çalıştırın.

---

## 👤 Geliştirici

- **Geliştirici:** Dilara Özcan
- **GitHub:** [@dilaraaozcan](https://github.com/dilaraaozcan)
