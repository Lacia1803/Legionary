# Báo Cáo Đồ Án: Legionary — 2D Platformer

Tác giả: Phùng Võ Quốc Hiển (Lacia)
MSSV: 2212364
Môn học: Đồ án / Bài tập lớn cuối kỳ

---

Mục lục (phác thảo):

1. Trang bìa
2. Lời cam kết
3. Tóm tắt
4. Mục tiêu & Phạm vi
5. Công nghệ sử dụng
6. Phân tích gameplay
7. Thiết kế hệ thống
   7.1 Sơ đồ kiến trúc tổng thể
   7.2 Sơ đồ lớp (class diagram)
   7.3 Thiết kế các hệ thống chính (Character, Enemy, UI, Audio)
8. Thực hiện
   8.1 Cấu trúc dự án (Assets/)
   8.2 Các tính năng đã thực hiện (bảng)
   8.3 Các đoạn code quan trọng (3-5 đoạn) và phân tích
9. Kiểm thử & Kết quả
   9.1 Các test chính
   9.2 Screenshot và mô tả
10. Phân công công việc và lịch sử commit
11. Hạn chế & Hướng phát triển
12. Tài liệu tham khảo

---

1. Trang bìa

Legionary — 2D Platformer
Phùng Võ Quốc Hiển (Lacia) — MSSV 2212364
Giảng viên hướng dẫn: [Điền tên giảng viên nếu cần]
Ngày nộp: [Điền ngày]

2. Lời cam kết

Tôi xin cam đoan đây là sản phẩm do chính tôi phát triển. Mọi đoạn code, thiết kế kỹ thuật và nội dung trong báo cáo đều do tôi thực hiện. Nếu có sử dụng tài nguyên bên ngoài, tôi đã ghi rõ nguồn và tuân thủ giấy phép sử dụng.

3. Tóm tắt

Legionary là một trò chơi 2D platformer được phát triển trên Unity. Người chơi điều khiển một chiến binh vượt chướng ngại, tiêu diệt kẻ thù, thu thập tiền xu, duy trì sinh lực và hoàn thành 3 màn chơi có độ khó tăng dần. Dự án thể hiện các kiến thức về Unity, C# scripting, physics 2D, animation, UI và quản lý dự án bằng Git.

4. Mục tiêu & Phạm vi

- Mục tiêu: Xây dựng sản phẩm game 2D hoàn chỉnh, có ít nhất 3 tính năng gameplay, animation, sound, UI, và build chạy được trên nền Windows/macOS.
- Phạm vi: Bao gồm Menu chính, Intro Video, 3 Level gameplay, hệ thống checkpoint, health, score, game over và win screens. Không bao gồm mạng/multiplayer và hệ thống lưu điểm đám mây.

5. Công nghệ sử dụng

- Unity Editor 2023.1.x
- Ngôn ngữ: C#
- Công cụ phát triển: Visual Studio / VS Code
- Hệ thống quản lý mã nguồn: Git (repository: https://github.com/Lacia1803/Legionary)

6. Phân tích gameplay

- Cơ chế chơi chính: di chuyển (run), nhảy, thu thập coin, va chạm với enemy hoặc hazard làm mất HP, checkpoint và respawn.
- Điều kiện thắng: Hoàn thành màn chơi đi tới cổng hoặc trigger chiến thắng.
- Điều kiện thua: HP về 0 hoặc rơi xuống vực -> Game Over hoặc respawn tùy tình huống.

7. Thiết kế hệ thống

7.1 Sơ đồ kiến trúc tổng thể

- Các subsystem chính: Input -> PlayerController -> Physics/Animation; LevelManager (quản lý state/score/checkpoint); UI Manager (HUD, menu); Audio Manager; Scene Management.

  7.2 Sơ đồ lớp (tóm tắt)

- Xem `CLASS_DIAGRAM.md` trong repo (đã đính kèm sơ đồ mermaid và giải thích các class chính).

  7.3 Thiết kế các hệ thống chính

- Player: `PlayerControl.cs` — xử lý input, di chuyển, jump, animation.
- Health: `PlayerHealth.cs` — quản lý HP, xử lý hurt/die, gọi respawn hoặc load Game Over.
- Level Manager: `LevelManager.cs` (Singleton) — quản lý điểm, respawn, state giữa các scene.
- Collectables: `CollectableObjects.cs` — handle pickup coin.
- UI: Canvas cho menu, HUD, buttons.

8. Thực hiện

8.1 Cấu trúc dự án (Assets/)

- `Assets/Game assets/Scripts/` — các script chính như `PlayerControl.cs`, `PlayerHealth.cs`, `LevelManager.cs`, `GameOverManager.cs`, `GameWinManager.cs`, v.v.
- `Assets/Custom Tileset/` — tileset và props.
- `Assets/UI Assets/` — các sprite UI, font.
- `Assets/Game assets/Audio Files/` — âm thanh.

  8.2 Các tính năng đã thực hiện (bảng)

| Tính năng            | Mô tả                                                       | Trạng thái |
| -------------------- | ----------------------------------------------------------- | ---------- |
| Di chuyển & nhảy     | Player có thể chạy và nhảy, sprite flip theo hướng          | Hoàn thành |
| Hệ thống HP          | Player có health, khi 0 -> die/respawn hoặc Game Over       | Hoàn thành |
| Checkpoint & Respawn | Lưu vị trí checkpoint, respawn sau delay                    | Hoàn thành |
| Thu thập coin        | Coin tăng điểm, hiển thị Score                              | Hoàn thành |
| Menu & Scene         | Main Menu, Intro Video, các màn play, Win/Game Over screens | Hoàn thành |

8.3 Các đoạn code quan trọng và phân tích

- Xem `CLASS_DIAGRAM.md` (đã có 4 đoạn code quan trọng và giải thích chi tiết). Trong báo cáo chính thức, hãy copy 3–5 đoạn mã này sang mục 3.3 và mở rộng giải thích về lý do chọn cách triển khai.

9. Kiểm thử & Kết quả

9.1 Các test chính

- Test di chuyển & va chạm: kiểm tra không bị xuyên tile, nhảy qua chướng ngại.
- Test checkpoint: chết tại sau checkpoint -> respawn đúng.
- Test thu thập coin: coin biến mất và điểm tăng.

  9.2 Screenshot (đã lưu trong README và thư mục gốc): tối thiểu 6 ảnh gameplay (README hiện có 6 ảnh: main menu, level1, level2, tileset, enemy texture, special scene). Trong báo cáo cần đưa caption và mô tả cho mỗi ảnh.

10. Phân công công việc & Lịch sử commit

- Thành viên: Phùng Võ Quốc Hiển (Lacia) — thực hiện toàn bộ dự án.
- Lịch sử commit: Repo hiện có 18 commit bởi Phùng Võ Quốc Hiển (xem `git shortlog -s -n`).
- Ghi chú: Nếu cần, có thể tách phần commit cá nhân theo module (ví dụ commits liên quan UI, commits liên quan gameplay, commits tài liệu) trong phần phụ lục.

11. Hạn chế & Hướng phát triển

- Hạn chế: chưa có hệ thống AI phức tạp, chưa tối ưu pooling cho nhiều enemy, chưa build cho WebGL.
- Hướng phát triển: thêm enemy AI, object pooling, power-ups, hệ thống lưu điểm (save), cải thiện art và âm thanh.

12. Tài liệu tham khảo

- Unity Documentation
- Tài liệu hướng dẫn Asset Store nếu sử dụng assets trả phí
- Các trang hướng dẫn C# async/await, coroutines, Rigidbody2D

---

Ghi chú: Đây là bản nháp báo cáo đầy đủ nội dung chính — mình có thể mở rộng mỗi chương để đạt đủ 30 trang PDF (ví dụ: thêm phân tích chi tiết cho từng đoạn mã, các biểu đồ class diagram cỡ lớn, log commits, nhật ký làm việc tuần, và nhiều screenshot cùng caption). Bạn muốn mình phát triển phần nào thành bản hoàn chỉnh 30 trang trước?
