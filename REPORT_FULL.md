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

## 2.1 Cốt truyện và bối cảnh
Trò chơi đưa người chơi vào vai một hiệp sĩ giáp sắt ("The Legionary") trong hành trình đi qua 3 ngục tối/vùng đất nguy hiểm. Bối cảnh được xây dựng dạng Tilemap đa dạng từ khu rừng nhiệt đới, hang động tĩnh mịch cho tới các hầm ngục đổ nát. 

## 2.2 Luật chơi (Rules & Mechanics)
- **Hệ thống di chuyển:** Người chơi sử dụng các phím A/D (hoặc mũi tên) để chạy trái phải và Space/W để nhảy. Nhân vật chịu tác động của trọng lực mô phỏng thực tế.
- **Hệ thống chướng ngại vật (Hazards):** Map được bố trí các hố sâu (FallDetector), các kẻ địch tuần tra. Chạm vào sẽ làm nhân vật nhận sát thương.
- **Hệ thống thu thập (Collectables):** Người chơi nhặt những đồng vàng (Coins) rải rác. Mỗi đồng vàng giúp gia tăng điểm số chung (Score).
- **Hệ thống hồi sinh (Checkpoints):** Trong lúc di chuyển, nhân vật đi ngang qua các lá cờ (Checkpoint) sẽ tự động lưu lại tọa độ. Khi tử nạn, nhân vật sẽ hồi sinh tại đây thay vì đi lại từ đầu.

## 2.3 Điều kiện Thắng / Thua
- **Win Condition (Chiến thắng):** Hoàn thành lần lượt: Level 1 -> Level 2 -> Level 3. Cuối mỗi map sẽ có điểm chạm màn (Trigger) để kích hoạt Game Win Screen.
- **Lose Condition (Thua cuộc):** 
  - Nhân vật có thanh máu. Nhận đủ sát thương -> HP = 0 -> Die.
  - Ngã xuống vực (chạm Fall Detector) -> Reset.
  - Sau khi chết, tuỳ mỗi level sẽ cho hồi sinh về Checkpoint, hoặc chuyển thẳng đến màn hình Game Over.

## 2.4 Hệ thống cấp độ (Level Design)
Dự án được phân chia thành 6 Scene chính:
1. **Main Menu:** Màn hình chào mừng, cho phép vào game hoặc thoát.
2. **Intro Video:** Phát đoạn video giới thiệu, tự chuyển scene khi video kết thúc.
3. **Level 1:** Màn chơi rèn luyện kỹ năng cơ bản, hố sâu nhỏ.
4. **Level 2:** Màn chơi với nhiều chướng ngại vật hơn.
5. **Level 3:** Màn chơi khó nhất.
6. **Win Screen / Game Over:** Khép lại vòng lặp.

<div style="page-break-after: always"></div>

<a name="chuong-3"></a>
# CHƯƠNG 3: THIẾT KẾ HỆ THỐNG VÀ KIẾN TRÚC

## 3.1 Sơ đồ kiến trúc tổng thể
Cấu trúc Game dựa theo mô hình Component-based của Unity. Mỗi GameObject (Player, Enemy, Quản lý) được đính kèm các Component kịch bản (C# Scripts), vật lý (Rigidbody2D, Collider2D) và Render. Central Manager (LevelManager) sẽ giữ thông tin xuyên suốt trò chơi.

## 3.2 Sơ đồ lớp (Class Diagram)
Dưới đây là mô hình phân cấp và giao tiếp giữa các lớp trọng yếu trong game:

`mermaid
classDiagram
    LevelManager <|-- PlayerControl : uses
    LevelManager <|-- PlayerHealth : uses
    PlayerControl --> PlayerHealth : has (coupled via getComponent)
    CollectableObjects --> LevelManager : AddCoins()
    GameWinManager --> SceneManager : LoadScene()

    class LevelManager {
        +static instance
        +int Coins
        +Vector3 Checkpoint
        +Respawn()
        +AddCoins(int)
    }
    class PlayerControl {
        +float PlayerSpeed
        +Vector3 PlayerRespawn
        +PlayerWalk()
        +PlayerJump()
    }
    class PlayerHealth {
        +float currentHealth
        +LoseHealth(float)
    }
`

## 3.3 Áp dụng Design Pattern (Singleton)
**Vấn đề trước khi tối ưu:** Trong các màn chơi cũ, khi mỗi vật phẩm được nhặt lên hoặc mỗi lần gọi UI, các object luôn phải dùng hàm FindFirstObjectByType<LevelManager>() hoặc FindObjectOfType. Hàm này vòng qua toàn bộ scene để tìm đối tượng -> Độ trễ lớn (O(N)), dễ gây sụt giảm khung hình (FPS Drop).

**Giải pháp (Singleton Pattern):**
LevelManager được biến thành một instance duy trì độc nhất trong hệ thống và sống vĩnh viễn nhờ DontDestroyOnLoad. 

`csharp
public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    void Awake()
    {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject); // Giữ tồn tại khi chuyển Level
        } else {
            Destroy(gameObject); // Hủy bản sao thừa thủ công
        }
    }
}
`
Nhờ đó, ở CollectableObjects.cs, chỉ cần gọi LevelManager.instance.AddCoins() với độ phức tạp truy xuất là O(1). Mẫu thiết kế này là tiêu chuẩn kinh điển của các game khi quản lý vòng lặp (Game State).

<div style="page-break-after: always"></div>

<a name="chuong-4"></a>
# CHƯƠNG 4: CHI TIẾT TRIỂN KHAI VÀ HIỆN THỰC (MÃ NGUỒN)

## 4.1 Cấu trúc thư mục (Project Structure)
Dự án được bố trí một cách bài bản, ưu tiên nhóm các module vào thư mục Assets:
- /Assets/All scenes/: Chứa các phân cảnh .unity (Level 1, 2, 3, Menu...).
- /Assets/Custom Tileset/ & /Enemy Knight/: Chứa sprite, material của nhân vật, map.
- /Assets/Game assets/Scripts/: Là nơi chứa Core Logic (PlayerControl, PlayerHealth, LevelManager).
- /Assets/Game assets/Audio Files/: Chứa nhạc nền, hiệu ứng.
- /Assets/UI Assets/: Hình ảnh nút bấm, font chữ.

*(Thư mục Scripts Backup/ dư thừa đã được làm gọn sạch sẽ trong quá trình dọn dẹp mã nguồn)*.

## 4.2 Phân tích hệ thống Nhân vật (Player Control)
Tệp PlayerControl.cs chịu trách nhiệm đọc Input từ người chơi và điều khiển Vector2 vận tốc (velocity) của Rigidbody2D. Nổi bật bằng đoạn mã xoay lật (Flip) hình ảnh nhân vật mượt mà dựa trên localScale:

`csharp
public void PlayerWalk()
{
    PlayerMovement = Input.GetAxis("Horizontal");
    if (PlayerMovement != 0f)
    {
        PlayerRigid.velocity = new Vector2(PlayerMovement * PlayerSpeed, PlayerRigid.velocity.y);
        
        // Cập nhật hướng Flip
        if (PlayerMovement > 0f) transform.localScale = new Vector2(1f, 1f);
        else if (PlayerMovement < 0f) transform.localScale = new Vector2(-1f, 1f);
    }
    else
    {
        PlayerRigid.velocity = new Vector2(0, PlayerRigid.velocity.y);
    }
}
`
*Phân tích:* Sử dụng Input.GetAxis("Horizontal") mang lại cảm giác phanh mượt nhờ ma sát của Unity Axis thay vì Raw input.

## 4.3 Phân tích hệ thống Sinh lực (Health System)
Tệp PlayerHealth.cs ứng dụng triệt để khái niệm Bất đồng bộ (Asynchronous) của C# thông qua sync/await thay vì chỉ dùng Coroutine truyền thống của Unity.

`csharp
public async Task LoseHealth(float Damage)
{
    currentHealth = Mathf.Clamp(currentHealth - Damage, 0, startHealth);
    if (currentHealth > 0)
    { 
        Animation.SetTrigger("Hurt");
    }
    else if (!dead)
    {
        Animation.SetTrigger("Die");                            
        GetComponent<PlayerControl>().enabled = false; // Ngăn chặn di chuyển
        dead = true;

        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            await Task.Delay(2000); // Chờ 2 giây để play xong hoạt ảnh chết
            LevelManager.instance.Respawn();
            currentHealth = startHealth;
            dead = false;
            GetComponent<PlayerControl>().enabled = true;
        }
        else // Level 2, Level 3
        {
            SceneManager.LoadScene("Game Over screen");
        }
    }
}
`
*Phân tích:* Sử dụng Mathf.Clamp tránh tình trạng máu bị âm. Khi chết, Control script tự ngắt (enabled = false) nhằm tránh tình lỗi trôi nhân vật. Tính năng wait Task.Delay cho phép trì hoãn mượt hoạt ảnh hồi sinh.

## 4.4 Phân tích hệ thống Camera (Camera Controller)
Sự thành bại của Platformer nằm ở Camera. Trong CamerController.cs, phương thức Vector3.Lerp được vận dụng.

`csharp
void Update ()
{
    Vector3 PlayerPosition = new Vector3 (FollowPlayer.transform.position.x, transform.position.y, transform.position.z );
    // Bù đắp offset tùy theo việc di chuyển trái/phải
    if(FollowPlayer.transform.localScale.x > 0f)
        PlayerPosition.x += CameraPosition;
    else
        PlayerPosition.x -= CameraPosition;

    transform.position = Vector3.Lerp(transform.position, PlayerPosition, SmoothCameraPosition * Time.deltaTime);
}
`
Trọng tâm: Nội suy (Lerp) kết hợp cùng Time.deltaTime giúp vị trí Camera "trượt" một cách mềm mại theo đối tượng dẫu cho FPS thay đổi.

<div style="page-break-after: always"></div>

<a name="chuong-5"></a>
# CHƯƠNG 5: TỔNG HỢP ASSETS VÀ GIAO DIỆN (UI/UX)

## 5.1 Thiết kế UI (Canvas, HUD)
1. **HUD (Heads-up Display):** 
   - Thanh sức khỏe (HP Bar) thiết lập dạng Slider có màu Gradient xanh chuyển đỏ.
   - Text "Score: X" được cập nhật real-time nhờ DontDestroyOnLoad(ScoreText).
2. **Menu Panels:**
   - Xây dựng theo module Panel. Các nút sử dụng component Button (Script) cung cấp bởi Unity. Tệp MainMenuManager.cs điều hướng SceneManager.LoadScene().

## 5.2 Thiết kế Audio & Animation
1. **Animation State Machine:**
   - Nhân vật có Animator thiết lập bằng Blend Tree, dùng Parameter (float Speed, bool OnGround, Trigger Die).
2. **Audio Mix:**
   - Chia 2 luồng phát AudioSource chính: Một luồng cho Nhạc nền môi trường (BGM Loop - Tropical Moments), một luồng SFX cho tiếng Coin (WinSF.mp3), tiếng bước chân và tiếng chết (Death.mp3).

<div style="page-break-after: always"></div>

<a name="chuong-6"></a>
# CHƯƠNG 6: KIỂM THỬ VÀ KẾT QUẢ

## 6.1 Kịch bản kiểm thử (Test Cases)

| Mã TC | Mô tả Kịch bản | Dữ liệu đầu vào | Kết quả mong muốn | Trạng thái |
|---|---|---|---|---|
| TC-01 | Player va chạm tường | Điều hướng đi xuyên tường tĩnh | Player bị bật lại bởi Collider | Passed |
| TC-02 | Player rơi vực thẳm | Nhảy rớt xuống FallDetector | Gọi LoseHealth, Respawn | Passed |
| TC-03 | Quản lý điểm (Coins) | Player ăn hạt vàng | Xóa object vàng, Tăng số hiển thị hud | Passed |
| TC-04 | Chuyển Level qua cửa | Player đi vào Scene Portal | Cấp độ 2 tải lên, giữ nguyên Score | Passed |
| TC-05 | Hiệu năng FPS | Không thao tác, chạy 10 phút | FPS duy trì trên 60, RAM ổn định | Passed |

## 6.2 Hình ảnh minh họa Gameplay

**Màn hình Menu Hiện đại và Trực quan**
![Main Menu](2dmain.png)
*Hình 6.2.1: Màn hình Main Menu với các nút điều hướng cơ bản*

**Trải nghiệm Level 1 đầy màu sắc**
![Gameplay Màn 1](2d2.png)
*Hình 6.2.2: Bối cảnh ngoài trời tại Màn 1, hệ thống UI điểm nằm ở góc trên*

**Trải nghiệm Level 2 và Hang động**
![Gameplay Màn 2](2d3.png)
*Hình 6.2.3: Bối cảnh Hang động u ám kết hợp các cơ chế Physics trọng lực phức tạp*

**Cảnh Level Đặc biệt**
![Gameplay Màn 1](2d.png)
*Hình 6.2.4: Chiêm ngưỡng các nền tảng tự do trên cao, người chơi phải nhảy canh tọa độ tỉ mỉ.*

<div style="page-break-after: always"></div>

<a name="chuong-7"></a>
# CHƯƠNG 7: QUÁ TRÌNH PHÁT TRIỂN (NHẬT KÝ LÀM VIỆC & GIT)

## 7.1 Nhật ký làm việc theo tuần
Dự án được thực hiện nghiêm túc xuyên suốt 5 tuần theo đúng tiến độ lộ trình môn học:

- **Tuần 1:** Xây dựng khung ý tưởng, viết kịch bản sơ bộ. Khảo sát công cụ Unity và tạo Project rỗng. Setting Github Repository.
- **Tuần 2:** Lắp rắp Asset, sơn Tilemap cho 3 Levels. Vẽ Collider cho đất. 
- **Tuần 3:** Viết Core Script. Tập trung xử lý System Physics (Movement, Jump, Fall). Code hệ thống Singleton cho LevelManager đo điểm số.
- **Tuần 4:** Hoàn tất hệ thống Game Flow (Lối chơi). Làm Health System, Enemy Trigger, Checkpoint. Lắp ráp UI (Menu, HUD).
- **Tuần 5:** Tối ưu hóa. Fix bug (Fix lỗi player dính chặt vào tường, fix lỗi reset điểm màn 2...). Trang trí âm thanh, ánh sáng, viết báo cáo (Report, README, Slide). Build Game.

## 7.2 Lịch sử quản lý mã nguồn (Git Commits)
Toàn bộ dự án tuân thủ quản lý mã nguồn bằng Git. Nhóm làm việc độc lập 1 người (Lacia), thực hiện tổng cộng **18+ Commit** được push lên remote đầy đủ. 
*Xem phụ lục Git Repo: https://github.com/Lacia1803/Legionary để track chi tiết hash và tree map của nhánh main.*

*(Một số thay đổi cụ thể nhằm minh chứng cho tính logic commit: thêm log debug, refactor UI, dọn Rác file Scripts).*

<div style="page-break-after: always"></div>

<a name="chuong-8"></a>
# CHƯƠNG 8: KẾT LUẬN VÀ HƯỚNG PHÁT TRIỂN

## 8.1 Đánh giá kết quả đạt được
Nhìn chung, đồ án "Legionary" đã đạt được toàn bộ tiêu chuẩn đầu ra theo yêu cầu của môn học:
1. Hoàn thành khối lượng công việc của một game hoàn chỉnh với vòng lặp Menu -> Game -> Over/Win.
2. Nắm bắt sâu sắc framework Unity, quản lí Component, làm chủ chu kỳ sống (Lifecycle: Awake, Start, Update).
3. Mài giũa kỹ năng Code C# nâng cao: sử dụng Task Async, áp dụng mẫu thiết kế (Singleton).

## 8.2 Hạn chế của dự án
Dù hệ thống core hoàn thiện nhưng Project mới dừng ở mức nguyên mẫu (Prototype) tốt, song vẫn có vài điểm nghẽn:
- Hành vi của Enemy còn đơn giản (Static di chuyển tuần tra), chưa AI rượt đuổi người chơi hay tấn công phức tạp.
- Chưa áp dụng được **Object Pooling** cho hệ thống particle effect (hiệu ứng máu / nổ), hiện chỉ đang dùng Destroy() tốn bộ nhớ GC rác.
- Bản build dung lượng khá lớn dù số cảnh / vật phẩm còn hạn chế.

## 8.3 Hướng phát triển trong tương lai
Nếu có điều kiện mở rộng, sản phẩm sẽ được tích hợp:
- Tính năng AI phức tạp bằng thư viện Navigation/A*.
- Hệ thống Save/Load dữ liệu dựa trên JSON để lưu quá trình chơi (hoặc đám mây PlayFab).
- Build hỗ trợ đa nền tảng: Chuyển toàn bộ phím tắt sang Touch UI để phát hành trên thiết bị di động (Android / iOS).

<div style="page-break-after: always"></div>

<a name="tai-lieu"></a>
# TÀI LIỆU THAM KHẢO

1. **Unity Documentation**: https://docs.unity3d.com/Manual/index.html — Tham khảo API các hàm vật lý RigidBody2D, Vector3.Lerp và SceneManagement.
2. Microsoft C# Documentation: https://learn.microsoft.com/en-us/dotnet/csharp/ — Tài liệu về lập trình hướng đối tượng, Async/Await.
3. Trang thư viện Asset:
   - Các gói asset từ Unity Asset Store (Enemy Knight Demo, Free UI Pack) – được mua với License chuẩn cho học tập.
   - Bức ảnh Vũ trụ phông nền cung cấp bởi NASA (Public Domain).
   - Font chữ Jupiter Typography cung cấp bởi Isurus Labs (Public Domain).
4. GitHub & Git Documentation — Tài liệu quản lý mã lệnh từ Git-scm.

---
**[KẾT THÚC BÁO CÁO]**
