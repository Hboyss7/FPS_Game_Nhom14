# 🎮 HƯỚNG DẪN MỞ DỰ ÁN UNITY - FPS GAME NHÓM 14

## 📋 Thông tin dự án
- **Tên dự án:** CuoiKy_GameNC_FPS_Nhom14
- **Engine:** Unity 6 (phiên bản 6000.0.26f1)
- **Repository:** FPS_Game_Nhom14
- **Branch:** main

---

## ⚠️ QUAN TRỌNG VỀ PHIÊN BẢN UNITY

Dự án này được tạo bằng **Unity 6 (phiên bản 6000.0.26f1)**.

### 📌 Quy trình đơn giản:

1. **Nếu bạn đã có Unity 2022 (ví dụ: 2022.3.61f1):**
   - ✅ **Cứ thử mở dự án bằng Unity 2022 trước**
   - ⚠️ **Nếu gặp lỗi** (Missing Script, compile error, không mở được...):
     - 💬 **Liên hệ ngay với team leader** để được hỗ trợ
     - 💾 **HOẶC cài thêm Unity 6000.0.26f1** (xem hướng dẫn BƯỚC 3 bên dưới)

2. **Nếu bạn chưa có Unity nào:**
   - 🎯 **Khuyến nghị:** Cài luôn **Unity 6000.0.26f1** (phiên bản chính thức của dự án)

3. **Nếu bạn đã có Unity 6 (6000.0.x):**
   - ✅ **Rất tốt!** Cứ thử mở dự án
   - ⚠️ Nếu bị lỗi → Cài đúng phiên bản **6000.0.26f1**

### 💡 Lưu ý:
- Dự án Unity 6 **có thể** mở được bằng Unity 2022, nhưng **KHÔNG ĐƯỢC ĐẢM BẢO**
- Nếu sử dụng sai phiên bản, có thể gặp lỗi "Missing Script" hoặc "Mất hình"
- **An toàn nhất:** Dùng đúng Unity 6000.0.26f1

---

## 🛑 BƯỚC 1: Kiểm tra "Đồ nghề" (Git & Git LFS)

Trước khi tải bất cứ thứ gì, bạn cần mở **Terminal** (trên Mac) hoặc **CMD / PowerShell** (trên Windows) và gõ 2 lệnh kiểm tra sau.

### 1. Kiểm tra Git:

```bash
git --version
```

- ✅ **Ổn:** Nếu nó hiện ra dòng chữ kiểu `git version 2.43.0...` (số nào cũng được).
- ❌ **Chưa ổn:** Nếu máy báo lỗi "command not found" hoặc "is not recognized".
  - **→ Phải tải và cài Git** tại [git-scm.com](https://git-scm.com/)

### 2. Kiểm tra Git LFS (Quan trọng cho Game):

```bash
git lfs --version
```

- ✅ **Ổn:** Nếu nó hiện ra kiểu `git-lfs/3.4.0...`
- ❌ **Chưa ổn:** Nếu báo lỗi.
  - **→ Phải tải và cài Git LFS** tại [git-lfs.com](https://git-lfs.com/)

---

## ⚙️ BƯỚC 2: Kích hoạt LFS và Clone dự án

Sau khi đã cài đủ đồ nghề, hãy mở Terminal/PowerShell tại thư mục muốn lưu game và làm đúng thứ tự:

### 1. Kích hoạt LFS (Chỉ cần làm 1 lần duy nhất trên máy):

```bash
git lfs install
```

**(Bắt buộc phải thấy dòng chữ "Git LFS initialized" thì mới được đi tiếp).**

### 2. Tải dự án về:

```bash
git clone https://github.com/Hboyss7/FPS_Game_Nhom14.git
```

**Lưu ý:** Lúc này màn hình sẽ chạy 2 lần:
- **Lần 1:** Tải code (nhanh)
- **Lần 2:** Tải LFS files - ảnh, model, audio... (sẽ lâu hơn)

### 3. Di chuyển vào thư mục dự án:

```bash
cd FPS_Game_Nhom14
```

---

## 🎮 BƯỚC 3: Cài đặt đúng phiên bản Unity 6

Vì dự án đang dùng bản **`6000.0.26f1`**, để đảm bảo không có lỗi, khuyến nghị cài đúng phiên bản này.

### ⏱️ Thông tin cài đặt Unity 6000.0.26f1:

- 💾 **Dung lượng tải về:** ~3.5 - 4 GB (tùy modules)
- 📦 **Dung lượng sau khi cài:** ~8 - 10 GB
- ⏰ **Thời gian tải:** 15 - 45 phút (tùy tốc độ mạng)
- ⚙️ **Thời gian cài đặt:** 10 - 20 phút
- 🔧 **Tổng thời gian:** Khoảng **30 - 60 phút**

### Cách cài đặt:

1. Mở **Unity Hub**
2. Vào tab **Installs** → **Install Editor**

4. **Modules cần cài thêm (khuyến nghị):**
   - ✅ **Visual Studio** (hoặc VS Code) - ~5 GB
   - ✅ **Windows Build Support** (nếu build cho Windows) - ~500 MB
   - ✅ **Documentation** - ~200 MB
   
   *(Nếu chọn đủ modules, tổng dung lượng có thể lên tới ~15 GB)*

### 📝 Lưu ý về phiên bản:

### 📝 Lưu ý về phiên bản:

#### � LINH HOẠT: Thử Unity 2022 trước

**Nếu bạn đã có Unity 2022 (ví dụ: 2022.3.61f1):**
1. ✅ **Cứ thử mở dự án bằng Unity 2022 trước**
2. ⏳ Đợi Unity import xong (10-30 phút)
3. 🧪 Kiểm tra xem có lỗi không:
   - ✅ **Nếu mở được, không có lỗi** → Tuyệt vời! Cứ dùng Unity 2022
   - ❌ **Nếu có lỗi** (Missing Script, compile error...):
     - 📞 **Liên hệ ngay team leader** để được tư vấn
     - 💾 **HOẶC cài Unity 6000.0.26f1** (theo hướng dẫn phía trên)

#### ⚠️ Những phiên bản KHÔNG nên dùng:

- ❌ **Unity 2021.x** → Rủi ro cao
- ❌ **Unity 2020.x** → Rủi ro cao

**Tại sao có thể thử Unity 2022?**
- Unity 2022 và Unity 6 có một số tính năng tương thích
- **NHƯNG** không được đảm bảo 100%
- Có thể gặp lỗi API, Missing Script, hoặc các vấn đề khác
- **An toàn nhất:** Vẫn là dùng Unity 6000.0.26f1

#### ✅ PHIÊN BẢN ĐƯỢC KHUYẾN NGHỊ:

**Ưu tiên cao nhất:**
- 🎯 **Unity 6000.0.26f1** (Phiên bản chính thức - Đảm bảo 100%)

**Có thể thử (Nếu đã có sẵn):**
- 🔄 **Unity 2022.3.x** (Thử xem có lỗi không)
- 🔄 **Unity 6000.0.x** (Các bản Unity 6 khác)

#### 📥 Nếu quyết định cài Unity 6:

**Lợi ích:**
- ✅ Không có lỗi phiên bản
- ✅ Tương thích 100% với dự án
- ✅ Nhận được tất cả tính năng mới của Unity 6
- ✅ Không phải lo lắng về Missing Script

**Chi phí:**
- 💾 Cần ~10-15 GB dung lượng ổ cứng
- ⏰ Mất ~30-60 phút để tải và cài
- 🔧 Có thể cùng tồn tại với Unity 2022 (không cần xóa)

#### 🚀 Quyết định nhanh:

| Tình huống | Khuyến nghị |
|------------|-------------|
| Chưa có Unity nào | Cài **Unity 6000.0.26f1** |
| Đã có Unity 2022 | **Thử Unity 2022 trước** → Nếu lỗi → Cài Unity 6 |
| Đã có Unity 6.x | **Cứ dùng** → Nếu lỗi → Cài 6000.0.26f1 |
| Đã có Unity 2021 | Cài thêm **Unity 6000.0.26f1** |

---

## ⏳ BƯỚC 4: Mở dự án và Kiên nhẫn

### 1. Thêm dự án vào Unity Hub:

- Trong Unity Hub, chọn **Open** (hoặc **Add Project from Disk**)
- Trỏ vào thư mục vừa clone về: `FPS_Game_Nhom14`

### 2. Chờ đợi quá trình import:

**CẢNH BÁO QUAN TRỌNG:**
- ⏰ Khi mở lần đầu, Unity sẽ thấy thiếu thư mục `Library`
- 📦 Nó sẽ hiện bảng **"Resolving Packages"** hoặc **"Importing Assets"**
- ⏱️ Quá trình này mất từ **10 - 30 phút** (tùy cấu hình máy)
- 💻 Máy tính có thể bị đơ nhẹ
- 🚫 **TUYỆT ĐỐI KHÔNG TẮT NGANG**. Hãy để nó chạy xong.

### 3. Dấu hiệu import thành công:

- Console không còn báo lỗi đỏ (hoặc chỉ có warning màu vàng nhẹ)
- Thư mục `Library` đã được tạo ra
- Project panel hiển thị đầy đủ assets

---

## 🛠️ BƯỚC 5: Xử lý nếu vào game bị "trắng trơn"

Sau khi mở lên được, nếu bạn thấy màn hình trống không:

1. Nhìn xuống khung **Project** bên dưới
2. Vào thư mục **Assets** → **Scenes**
3. Nhấp đúp (Double click) vào file Scene chính:
   - Tìm các scene có tên như `MainScene`, `Level1`, `GameScene`...
4. Game sẽ hiện ra đầy đủ

---

## 🔍 KIỂM TRA CÁC VẤN ĐỀ THƯỜNG GẶP

### ❌ Vấn đề 1: "Missing Script" (Thiếu script) hoặc Lỗi Compile

**Nguyên nhân phổ biến nhất:** Sử dụng phiên bản Unity không tương thích

#### 🚨 KIỂM TRA NGAY PHIÊN BẢN UNITY:

**Bước 0 - Xác định phiên bản đang dùng:**
1. Mở Unity Hub
2. Nhìn vào tab **Installs**
3. Kiểm tra phiên bản Unity bạn đã dùng để mở dự án

**Nếu bạn thấy số phiên bản là:**
- ✅ **6000.0.26f1** → **HOÀN HẢO!** (Nếu vẫn lỗi, xem Trường hợp 3 bên dưới)
- ⚠️ **6000.0.x** (khác 26f1) → **Có thể dùng** (Nếu lỗi, đổi sang 26f1)
- 🔄 **2022.3.x** → **Thử được** (Nếu lỗi, cài Unity 6)
- ❌ **2021.x.x** hoặc **2020.x.x** → **Rủi ro cao** (Nên cài Unity 6)

#### 📌 GIẢI PHÁP CHO TỪNG TRƯỜNG HỢP:

**Trường hợp 1: Đang dùng Unity 2022**

**Bước 1 - Đã thử chưa?**
- Nếu bạn **MỚI clone dự án** và **CHƯA MỞ LẦN NÀO**:
  1. ✅ Cứ thử mở bằng Unity 2022 trước
  2. ⏳ Đợi import xong (10-30 phút)
  3. 🧪 Kiểm tra Console xem có lỗi đỏ không

**Bước 2 - Nếu thấy lỗi:**
```
❌ Unity 2022 không tương thích 100% với dự án Unity 6
```

**Phải làm:**
1. 📞 **Liên hệ team leader** để được tư vấn
2. 💾 **HOẶC cài Unity 6000.0.26f1** (khuyến nghị):
   - Mở Unity Hub → **Installs** → **Install Editor**
   - Tìm phiên bản **6000.0.26f1** trong Archive
   - Link: https://unity.com/releases/editor/archive
   - Thời gian: ~30-60 phút
   - Dung lượng: ~10-15 GB
   
3. 🔄 **Xóa thư mục bị hỏng:**
   ```powershell
   # Di chuyển vào thư mục dự án
   cd "đường_dẫn_đến_dự_án\FPS_Game_Nhom14"
   
   # Xóa thư mục Library và Temp
   Remove-Item -Recurse -Force Library, Temp
   ```
4. ✅ **Mở lại dự án bằng Unity 6000.0.26f1**

**Trường hợp 2: Đang dùng Unity 2021/2020**

**Không nên thử, cài luôn Unity 6:**
1. 💾 Tải và cài **Unity 6000.0.26f1**
2. 🔄 Xóa thư mục `Library` và `Temp` (nếu đã từng mở)
3. ✅ Mở dự án bằng Unity 6

**Trường hợp 3: Đang dùng Unity 6 (6000.0.x) nhưng không phải 26f1**

**Bước 1 - Thử với phiên bản hiện tại:**
- Nếu bạn đang dùng Unity 6 (bất kỳ phiên bản 6000.0.x nào), hãy thử mở dự án
- Đợi Unity import xong hoàn toàn

**Bước 2 - Nếu vẫn bị lỗi:**
1. 📞 **Liên lạc ngay với team leader** để báo cáo lỗi
2. 💾 **Tải và cài đúng phiên bản 6000.0.26f1** (khuyến nghị cao)
3. Xóa thư mục `Library` và `Temp` trong thư mục dự án
4. Mở lại dự án bằng phiên bản **6000.0.26f1**

**Trường hợp 4: Đã dùng đúng Unity 6000.0.26f1 nhưng vẫn lỗi**

**Bước 1 - Reset lại dự án:**
```powershell
# Di chuyển vào thư mục dự án
cd "d:\Lap Trinh Game Nang Cao\CuoiKy_GameNC_FPS_Nhom14"

# Xóa thư mục Library và Temp (PowerShell)
Remove-Item -Recurse -Force Library, Temp

# Mở lại Unity Hub và mở dự án
```

**Bước 2 - Kiểm tra Git LFS:**
```bash
git lfs pull
```

**Bước 3 - Liên hệ team leader** nếu vẫn không được

### ❌ Vấn đề 2: Mất hình/texture trắng

**Nguyên nhân:** Git LFS không tải đầy đủ file

**Giải pháp:**
```bash
git lfs pull
```

### ❌ Vấn đề 3: Compile Error

**Nguyên nhân:** Packages chưa được resolve đầy đủ

**Giải pháp:**
1. Vào **Window** → **Package Manager**
2. Chờ tất cả packages tải xong
3. Nếu có package báo lỗi, click **Resolve** hoặc **Update**

### ❌ Vấn đề 4: Scene rỗng

**Giải pháp:**
- Double-click vào scene file trong `Assets/Scenes/`

---

## 📁 CẤU TRÚC DỰ ÁN

```
CuoiKy_GameNC_FPS_Nhom14/
├── Assets/                    # Tất cả tài nguyên game
│   ├── Scenes/               # Các scene của game
│   ├── Scripts/              # Code C#
│   ├── Prefabs/              # Prefabs
│   ├── Materials/            # Vật liệu
│   ├── Models/               # 3D Models
│   ├── Animations/           # Animations
│   ├── Sounds/               # Audio files
│   └── ...
├── ProjectSettings/          # Cài đặt dự án
├── Packages/                 # Package dependencies
└── Library/                  # (Tự động tạo - KHÔNG commit)
```

---

## 🚀 BẮT ĐẦU LÀM VIỆC

Sau khi mở dự án thành công:

1. **Chọn scene chính** trong `Assets/Scenes/`
2. **Nhấn Play** (▶️) để test game
3. **Bắt đầu code/chỉnh sửa**

---

## 💡 MẸO HỮU ÍCH

### Trước khi làm việc mỗi ngày:
```bash
git pull
git lfs pull
```

### Sau khi làm việc:
```bash
git add .
git commit -m "Mô tả thay đổi của bạn"
git push
```

### Tránh conflict:
- Luôn `git pull` trước khi bắt đầu làm việc
- Không chỉnh sửa cùng lúc trên cùng một file với thành viên khác
- Thường xuyên commit và push code

---

## 📞 HỖ TRỢ

Nếu gặp vấn đề không giải quyết được:

1. Kiểm tra lại từng bước trong hướng dẫn này
2. Xem Console trong Unity để biết lỗi cụ thể
3. Liên hệ với team leader
4. Tham khảo Unity Documentation: [docs.unity3d.com](https://docs.unity3d.com/)

---

## ✅ CHECKLIST TRƯỚC KHI BẮT ĐẦU

- [ ] Đã cài Git
- [ ] Đã cài Git LFS
- [ ] Đã chạy `git lfs install`
- [ ] Đã clone dự án thành công
- [ ] Đã cài Unity 6 phiên bản **6000.0.26f1**
- [ ] Đã mở được dự án trong Unity
- [ ] Đã load được scene chính
- [ ] Không có lỗi "Missing Script"
- [ ] Các texture/model hiển thị bình thường

---

**Chúc bạn làm việc hiệu quả! 🎮✨**

*Tài liệu được tạo ngày: 22/11/2025*
