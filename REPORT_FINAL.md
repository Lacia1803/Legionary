# BÁO CÁO ĐỒ ÁN CUỐI KỲ

## Môn học: Phát triển Ứng dụng Game 2D

<br/><br/>

**Tên dự án:** Legionary — 2D Platformer
**Sinh viên thực hiện:** Phùng Võ Quốc Hiển (Lacia)
**Mã số sinh viên:** 2212364
**Ngày hoàn thành:** Tháng 5, 2026

<div style="page-break-after: always"></div>

# LỜI CAM KẾT

Tôi tên là Phùng Võ Quốc Hiển, mã số sinh viên 2212364. Tôi xin cam đoan đây là đồ án do chính tôi tự nghiên cứu, phát triển và hoàn thiện. Các dòng code logic lõi, cấu trúc kiến trúc (Design Pattern), và việc tích hợp các tài nguyên vào trò chơi đều do tôi thực hiện theo đúng yêu cầu đề cương của môn học.

Các tài nguyên (hình ảnh, âm thanh, font chữ) sử dụng trong dự án được trích xuất từ các nguồn miễn phí hợp lệ hoặc thuộc giấy phép mã nguồn mở (Public Domain, Asset Store free). Chi tiết bản quyền đã được ghi rõ trong phần Phụ lục.

Nếu có bất kỳ sự gian lận nào, tôi xin chịu hoàn toàn trách nhiệm trước nhà trường và bộ môn.

<div style="page-break-after: always"></div>

# MỤC LỤC

1. [Chương 1: Mở đầu](#chuong-1)  
   1.1 Tổng quan dự án  
   1.2 Mục tiêu và Phạm vi  
   1.3 Công nghệ sử dụng
2. [Chương 2: Phân tích và Thiết kế Gameplay](#chuong-2)  
   2.1 Cốt truyện và bối cảnh  
   2.2 Luật chơi (Rules & Mechanics)  
   2.3 Điều kiện Thắng / Thua  
   2.4 Hệ thống cấp độ (Level Design)
3. [Chương 3: Thiết kế Hệ thống và Kiến trúc](#chuong-3)  
   3.1 Sơ đồ kiến trúc tổng thể  
   3.2 Sơ đồ lớp (Class Diagram)  
   3.3 Áp dụng Design Pattern (Singleton)
4. [Chương 4: Chi tiết Triển khai và Hiện thực (Mã Nguồn)](#chuong-4)  
   4.1 Cấu trúc thư mục (Project Structure)  
   4.2 Phân tích hệ thống Nhân vật (Player Control & Physics)  
   4.3 Phân tích hệ thống Sinh lực (Health System)  
   4.4 Phân tích hệ thống Quản lý (LevelManager & Checkpoint)  
   4.5 Phân tích hệ thống UI và Chuyển cảnh
5. [Chương 5: Tổng hợp Assets và Giao diện (UI/UX)](#chuong-5)  
   5.1 Thiết kế UI (Canvas, HUD)  
   5.2 Thiết kế Audio & Animation
6. [Chương 6: Kiểm thử và Kết quả (Screenshots)](#chuong-6)  
   6.1 Kịch bản kiểm thử  
   6.2 Hình ảnh minh họa Gameplay
7. [Chương 7: Quá trình Phát triển (Nhật ký làm việc & Git)](#chuong-7)  
   7.1 Nhật ký làm việc theo tuần  
   7.2 Lịch sử quản lý mã nguồn (Git Commits)
8. [Chương 8: Kết luận và Hướng phát triển](#chuong-8)  
   8.1 Đánh giá kết quả đạt được  
   8.2 Hạn chế của dự án  
   8.3 Hướng phát triển trong tương lai
9. [Tài liệu tham khảo](#tai-lieu)

<div style="page-break-after: always"></div>

<a name="chuong-1"></a>

# CHƯƠNG 1: MỞ ĐẦU

## 1.1 Tổng quan dự án

"Legionary" là một tựa game nhập vai đi cảnh 2D (2D Platformer) mang phong cách cổ điển, được phát triển trên môi trường Unity Engine. Trò chơi lấy cảm hứng từ các chiến binh hiệp sĩ dũng cảm, đối mặt với các thử thách thiên nhiên và quái vật để đạt được mục tiêu cuối cùng. Dự án này được tạo ra nhằm mục đích củng cố kiến thức về lập trình C#, hiểu sâu hơn về công cụ Unity (Animation, Physics 2D, UI Canvas, Scene Management), và áp dụng thành công các mẫu thiết kế phần mềm vào môi trường phát triển Game.

## 1.2 Mục tiêu và Phạm vi

**Mục tiêu:**

- Hoàn thiện một sản phẩm game 2D có thể chơi được với ít nhất 3 vòng chơi (levels) riêng biệt.
- Áp dụng ít nhất một Design Pattern (Singleton) vào việc quản lý vòng đời của trò chơi.
- Tích hợp đầy đủ các media: Sprites, Animation, Audio, Video intro.
- Code đảm bảo sạch (clean code), loại bỏ các rác, tối ưu hiệu năng không bị memory leak hay truy xuất dư thừa.

**Phạm vi:**

- Game chơi offline trên PC (Windows / MacOS).
- Không tích hợp cơ sở dữ liệu backend, hệ thống điểm thưởng mạng hoặc đa người chơi (multiplayer).

## 1.3 Công nghệ sử dụng

- **Engine Game:** Unity Editor phiên bản 2023.1.9f1 (Hỗ trợ Universal Render Pipeline - URP).
- **Ngôn ngữ lập trình:** C# (C-Sharp).
- **Môi trường lập trình (IDE):** Microsoft Visual Studio / Visual Studio Code.
- **Quản lý mã nguồn (VCS):** Git / GitHub.
- **Thư viện đồ họa:** Unity 2D (Tilemap, Physics2D, Sprites).

<div style="page-break-after: always"></div>

<a name="chuong-2"></a>

# CHƯƠNG 2: PHÂN TÍCH VÀ THIẾT KẾ GAMEPLAY

... (full report content continues — already in REPORT_FULL.md)

---

**[KẾT THÚC BÁO CÁO]**
