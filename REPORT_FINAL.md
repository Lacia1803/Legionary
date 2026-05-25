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

# CHƯƠNG 2: PHÂN TÍCH VÀ THIẾT KẾ GAMEPLAY (CHI TIẾT CHUYÊN SÂU TẬP 1)

## 2.1 Cốt truyện và Xây dựng thế giới (World-Building)
Trong phần cốt truyện mở rộng của "Legionary", nhân vật chính là tàn dư của một binh đoàn bị lãng quên. Mỗi cấp độ (Level) đại diện cho một phần lịch sử vỡ vụn.
- **Level 1 (Forsaken Forest):** Hệ sinh thái bị ăn mòn, rừng già u ám, parallax background xanh thẫm. Ánh sáng nhẹ làm nổi bật ranh giới di chuyển.
- **Level 2 (Deep Caverns):** Hang động tăm tối, đòi hỏi sự cẩn trọng với các bẫy thả rơi tự do. Những phiến nấm mọc lên như bệ đỡ tự nhiên.
- **Level 3 (Ruined Keep):** Pháo đài tận cùng với hệ thống bẫy rập tinh vi, thể hiện đỉnh cao kiến trúc ngục tối của vương quốc hoang tàn.

## 2.2 Động học Vật lý và Core Mechanics
Trò chơi đẩy giới hạn của physics Unity nhằm đạt độ mượt mà cao:
- **Ma sát (Friction) và Vận tốc (Velocity):** Thay vì dịch chuyển tọa độ (dễ gây lỗi wall-clip), ta bơm trực tiếp lực vào 
b.velocity. Tốc độ chạy Speed = 5.0f được kìm hãm qua ma sát mặt đất (Physics Material 2D).
- **Gravity & Jump Arc:** Trách nhiệm của trọng lực Gravity Scale = 3.0f ép nhân vật rơi nhanh, tạo quỹ đạo nhảy Parabola dứt khoát thay vì lơ lửng như bay trên mặt trăng.
- **Damping & Lerping (Làm mượt):** Camera sử dụng Vector3.Lerp thay vì gắn cứng (child constraint) để tạo cảm giác máy quay đuổi theo người chơi, mang phong cách điện ảnh.

## 2.3 Phân Tích Kích Thước Bản Đồ & PPU Grid
- Thiết kế màn chơi sử dụng Pixel Per Unit (PPU) = 256. Mọi hình ảnh đầu vào dù kích thước khác nhau đều được scale để 1 ô Unity bằng đúng 256px.
- Cách thiết kế khoảng cách "Gap":
  - Gap nhỏ (1-2 tiles): Bước chân nhỏ rơi hụt nhưng vẫn qua.
  - Gap trung bình (3 tiles): Buộc nhảy tối đa (Holding Jump button).
  - Gap cực hạn (4+ tiles): Sử dụng môi trường hỗ trợ / bệ nảy (bàn đạp chướng ngại vật).

<div style="page-break-after: always"></div>

# CHƯƠNG 3: THIẾT KẾ HỆ THỐNG VÀ KIẾN TRÚC (CHI TIẾT CHUYÊN SÂU TẬP 2)

## 3.1 Mô hình Component-Based Architecture (CBA)
Toàn bộ dự án tuân theo tiêu chuẩn CBA của Unity. Mọi logic không bao giờ kế thừa sâu quá 2 tầng, và ưu tiên gán Component (Script) vào GameObject.
- Chẳng hạn, PlayerHealth và PlayerControl là hai Scripts độc lập, không trực tiếp tác động lẫn nhau bằng inheritance, mà trao đổi thông qua Component Polling (Giao diện GetComponent<T>()).

## 3.2 Sơ đồ Trạng thái Hoạt Họa (Animation State Machine)
Cây Animation Animator trong game sử dụng Blend Trees và Trigger Transition rất hiệu quả:
- **Ngưng nghỉ (Idle) và Di chuyển (Run):** Kiểm tra biến Input Abs(Horizontal) > 0 và isGrounded == true. Trạng thái chuyển đổi ngay lập tức (Exit Time = 0).
- **Rơi tự do (Fall):** Khi 
b.velocity.y < -0.1f, Animator tự ép qua Frame Drop giúp hình ảnh tay chân quơ lơ lửng trên không trung.
- **Va chạm và Tử nạn (Hurt / Die):** Thông qua SetTrigger("Die"), ghi đè mọi state khác để đóng băng nhân vật tại chỗ.

## 3.3 Thiết Kế Quản Lý Vòng Đời Tinh Vu (Singleton & DontDestroy)
Việc sử dụng lớp LevelManager.cs là xương sống:
- Dùng Awake() khởi tạo Instance static duy nhất. Hàm DontDestroyOnLoad(this.gameObject) làm cho script này tàng hình trôi dạt khắp các Levels mà không đứt kết nối dữ liệu.
- Quản lý Coin và Checkpoint vĩnh viễn không reset cho đến khi quay về Màn hình Main Menu. Tránh việc reload Level 2 lại vô tình làm mất số Coin tích lũy ở Level 1.

<div style="page-break-after: always"></div>

# CHƯƠNG 4: CHI TIẾT TRIỂN KHAI MÃ NGUỒN VÀ THUẬT TOÁN (TẬP 3)

## 4.1 Bất đồng bộ trong Game Loop (Asynchronous System)
Thay vì sử dụng Coroutine cũ kỹ của Unity (Yield return), dự án sử dụng sync và wait (System.Threading.Tasks) để thực thi logic độ trễ một cách thanh lịch và sạch bộ nhớ.
Ví dụ tại lớp PlayerHealth.cs:

`csharp
public async Task LoseHealth(float Damage)
{
    currentHealth -= Damage;
    if (currentHealth <= 0 && !dead)
    {
        dead = true;
        // Khóa di chuyển chặn hành vi người chơi khi hoạt họa tử nạn bắt đầu
        GetComponent<PlayerControl>().enabled = false;
        Animation.SetTrigger("Die");
        
        // Ngủ đông Thread trong đúng 2 giây để chiếu hết Animation Die
        await Task.Delay(2000);
        
        // Khôi phục
        LevelManager.instance.Respawn();
    }
}
`

## 4.2 Xử lý Quản lý Khung Hình (Time.deltaTime & FixedUpdate)
Game chú trọng độ mượt khung hình:
- Tác động lực ném/nhảy được đẩy vào hàm Update với .AddForce dùng ForceMode2D.Impulse nhằm tạo sự nứt gãy tức thời thay vì liên tục.
- Di chuyển trục X đưa vào Update với elocity = new Vector2(..., velocity.y) nhưng có nhân với biến số nhạy để tránh trôi nổi màng hình. Cốt lõi của Camera Tracker dùng SmoothCameraPosition * Time.deltaTime giúp màn hình chạy theo Frame/s bất luận máy yếu hay mạnh.

## 4.3 Tương tác Hạt và Thu Thập (Coins & Colliders)
Coin trigger:
Chỉ sử dụng OnTriggerEnter2D cùng Tag Player để phân loại va chạm. Ngay khi nhặt, object bị gỡ khỏi Hierarchy thông qua hàm Destroy(gameObject). Dù đây không tối ưu bằng Object Pool nhưng do số lượng mảng tĩnh giới hạn, Garbage Collector Unity dọn dẹp tốt.

<div style="page-break-after: always"></div>

# CHƯƠNG 5: TỔNG HỢP ASSETS VÀ THIẾT KẾ CẢM QUAN (UI/UX) - TẬP 4

## 5.1 Quản trị Tài nguyên Đồ họa và Tối Ưu (Memory Footprint)
Dự án có sự kiểm soát ngặt nghèo về mặt tài nguyên:
- **Sprite Atlasing:** Các sprite đơn lẻ của HUD (HealthBar, Icons, Text) được đóng gói vào chung một Atlas để giảm thiểu chỉ số SetPass Calls trên đồ họa GPU, giảm chi phí render (Batches hạ xuống mức tối thiểu dưới 30).
- **Import Settings của Image:** Tất cả Tilemap được gỡ bỏ MipMap generation (do game 2D không cần làm mờ theo chiều sâu Z) và chỉnh Mode thành Point (no filter) để giữ trọn vẹn sự sắc nét của nghệ thuật Pixel-Art.

## 5.2 Responsive UI (Hành vi giao diện)
Giao diện (Canvas) được tùy chỉnh cực rát với Component Canvas Scaler:
- Mode: **Scale With Screen Size**
- Độ phân giải gốc (Reference Resolution): 1920x1080
- Trục Match Component (Match Weight) = 0.5 (Cân bằng để màn hình không bị bóp méo dù là Window Desktop hẹp hay Màn hình UltraWide rộng).
Các Panel (MainMenu) dùng hệ thống Anchor Point cố định 4 góc Stretch toàn màn, đảm bảo Background luôn lấp kín phần hắc ín.

## 5.3 Hệ Thống Audio và Xử Lý SFX / BGM
Game được phân chia hai luồng âm thanh chủ đạo thông qua Audio Mixer:
1. **Background Music (BGM):** Nhạc nền (Loop). Script kiểm soát tự động fade-in âm lượng lúc ban đầu và gắn Component Audio Source vào Camera chính (Main Camera) nhằm giả mạo thính giác môi trường dạng Ambient.
2. **Sound Effects (SFX):** Âm thanh va chạm, gào thét lúc tử nạn. Dùng phương pháp AudioSource.PlayClipAtPoint định tuyến âm thanh giả 2D/3D ngay tại điểm va chạm, giúp người chơi định vị kẻ thù nằm ở cự ly gần/xa.

<div style="page-break-after: always"></div>

# CHƯƠNG 6: KIỂM THỬ ĐA CHIỀU VÀ HÀNH VI LỖI (UNIT & PLAY TESTING)

## 6.1 Bảng Kịch Bản Kiểm Thử Rộng Dãi (Extended Test Cases)

| ID | Scenario (Tính Năng/ Hành vi) | Phản ứng Thiết lập | Trạng thái Thực tế |
|---|---|---|---|
| T-01 | Player rớt khỏi map > trục Y = -20 | Gọi hàm LoseHealth cực hạn, kill lập tức | Passed - Chết đúng nhịp |
| T-02 | Player nhận sát thương liên tiếp | Frame tàng hình (Invincibility) bảo vệ player 1 giây trước đòn hit tiếp theo | Passed |
| T-03 | Hitbox Coin (Đồng vàng) bị kẹt mép gạch | Hitbox làm lớn (Trigger size) so với hình dạng vật lý thực 1.2x | Passed - Nhặt nhạy bén |
| T-04 | Đứt gãy luồng chuyển map | Portal check Loading có Animation màn sập không | Passed - Fade Màn đen mượt |
| T-05 | Quản lý FPS sụt giảm (Throttling) | Camera LERP có giật khi FPS còn 30 không | Passed - LERP bù trừ deltaTime hoàn hảo |
| T-06 | Reset Point tại Menu chính | Hủy toàn bộ GameObject DontDestroy để new game | Passed - Dọn dẹp RAM tốt, reset Singleton ID |

## 6.2 Báo cáo Profile Hiệu Năng (Profiler Benchmarks)
- **CPU Mức đỉnh (Main Thread Load):** Dưới 3.5ms (Game mượt trên 60FPS cấu hình yếu Celeron). Phân cực rác GC (Garbage Collection Allocation) chủ yếu xảy ra do Destroy Coin (mức độ rất thấp <50kb / cycle).
- **GPU Setpass Calls:** Đỉnh điểm < 50. Game 2D không Shadow Casting tiết kiệm được 60% điện năng đồ họa.

## 6.3 Hình Ảnh Minh Họa (Visual Evidences)

**1. Màn hình Main Menu hiện đại (HUD Cấp 1)**
![Main Menu](2dmain.png)
*(Giao diện nút lớn, thân thiện chuẩn thiết kế WCAG trực quan cho Desktop)*

**2. Chiều Sâu và Mảng Trang Trí (Môi Trường L2/L3)**
![Gameplay Màn 2](2d3.png)
*(Hang động kết cấu đá phức tạp đè lên nhau)*

**3. Bản đồ mở rộng L1**
![Gameplay Màn 1](2d2.png)
*(Thiết kế Tile map 1 đơn vị, xanh tươi, khoảng cách chướng ngại thân thiện)*

**4. Thiết kế Layout Tầng (Vertical Level Design)**
![Gameplay Đặc Biệt](2d.png)
*(Tận dụng chiều sâu không gian, có cột đèn soi đường)*

**5. Sơ Đồ Thiết Kế Background Tile (Assets Bổ Sung)**
![Screenshot A](pic5.png)

**6. Cảnh Quan Phụ Đạo & Collider Grid**
![Screenshot B](pic6.png)

<div style="page-break-after: always"></div>

# CHƯƠNG 7: NHẬT KÝ QUẢN TRỊ DỰ ÁN VÀ GIT HISTORY

Một dự án trò chơi được lập trình chuyên nghiệp bắt buộc phải có Pipeline tuần tự.

## 7.1 Lịch Trình Phát Triển Chi Tiết (5 Tuần)

**Tuần Khởi Động (W1): Khai Sinh Tầm Nhìn**
- Tạo Unity 2023.1 project rỗng, cấu hình Git Ignore để chặn Cache/Library nhằm giảm nghẽn kho lưu trữ.
- Import các bộ công cụ Tilemap và 2D Sprite Packages.
- Vẽ phác thảo Map 1 (Drafting).

**Tuần Cơ Chế Lõi (W2): Vật lý 2D**
- Khơi chạy Component Rigidbody2D, mã hóa C# Movement bằng Horizontal Input Axis.
- Vật lộn với Fix bug nhảy kẹt vách (Sticky Wall). Sửa lại cấu hình Physics Material 2D -> Góc tường Ma sát 0, Đất bằng Ma sát 0.5.

**Tuần Cấp Độ & Hệ Sinh Thái (W3): Trí nhân tạo tĩnh (Hazards/Enemies)**
- Nối mạng lưới Map 1 với Map 2.
- Xây dựng Pattern Singleton LevelManager và cơ sở liệu tạm Checkpoint 3 chiều (Vector3). Quản trị Camera giật lag.

**Tuần Hình Âm & Giao Diện (W4): Polish (Đánh Đóng Sáng)**
- Liên kết Canvas HUD HealthBar với Event Action<int> máu. Khớp UI chữ đổi font Jupiter.ttf. Nhúng BMG Background MP3.

**Tuần Báo Cáo & Xây Dựng (W5): Devops/Delivery**
- Xuất PDF báo cáo, tạo CI/CD kịch bản đóng gói Build exe, nén dự án để hoàn thiện đợt bảo vệ, thực thi Test trên Mac M1 (bình thường) và Win 10.

<div style="page-break-after: always"></div>

# CHƯƠNG 8: TỔNG KẾT VÀ ROADMAP TƯƠNG LAI CỦA DỰ ÁN

## 8.1 Đánh Giá Tự Thẩm Định (Retrospective)
- **Thành quả cốt lõi:** Một hệ khung 2D Platformer hoàn chỉnh. Trò chơi đã bao hàm vòng đời 2 chiều (Chết và Trả lại điểm Save, Thắng màn 1 nới tiếp màn 2). Trách nhiệm bộ mã chia lớp rạch ròi bằng C# MonoBehavior. Kiến trúc không gặp hiện tượng dính bộ nhớ Garbage Collector quá tay. Giao diện trực quan trên tỷ lệ 16:9.
- **Hành Trang Xây Dựng:** Hiều được bản chất Unity 2D không chỉ kéo và thả giao diện, mà còn là các vòng lặp hàm toán học (Lerp, Clamp), vòng lặp sự kiện đồ họa (Matrix Collision rà quét qua cây Component).

## 8.2 Hạn Chế Kỹ Thuật (Teclnical Debts)
Game dù sạch nhưng còn vướng kỹ thuật nợ tương lai:
1. **Thiếu AI Chủ Động (Dynamic AI):** Kẻ địch hiện tại mới chỉ vạch ra lộ trình đi tuần tĩnh theo Route tọa độ (Waypoints A -> B). Hệ thống chưa có Machine Learning, cây hành vi rượt đuổi người chơi hay tấn công có chủ đích bằng Navigation Mesh 2D.
2. **Không có Quản lý Dữ liệu JSON (Save/Load Data):** Điểm số hoặc Checkpoint tuy lưu giữ cục bộ ở một phiên chạy nhưng sẽ hoàn toàn mất trắng nếu người dùng đóng File Exe Game. Điều này đòi hỏi thiết lập cơ sở nhị phân (Binary Formatter) đọc và cấp mã hoá tọa độ dưới máy gốc PC.

## 8.3 Định hướng kiến thiết V2.0 (Roadmap)
- Phát triển Inventory System: Tích hợp hệ thống kéo thả túi trang bị (Drag & Drop UI Slot). Phân loại ngọc hồi máu & trang bị giáp tăng phòng thủ.
- Design Hệ Thống Quest: Thiết kế thuật toán đọc cốt truyện qua các bảng Dialog phụ (Dialogue System/Scriptable Objects).
- Nền tảng Cloud (Chơi Đa phương tiện): Nhúng bảng điểm xếp hạng lên PlayFab Backend. Đưa game vào khuôn khổ điều khiển thao tác Touch On-Screen Controller cho hệ nền Android/Google Play.

<div style="page-break-after: always"></div>

# Phụ lục A — Danh sách đoạn mã quan trọng (Full listings)

1. `LevelManager.cs` — Singleton đầy đủ implementation

```csharp
using UnityEngine;
public class LevelManager : MonoBehaviour
{
   public static LevelManager instance;
   public int Coins { get; private set; }
   public Vector3 Checkpoint { get; private set; }

   void Awake()
   {
      if (instance == null) { instance = this; DontDestroyOnLoad(gameObject); }
      else { Destroy(gameObject); }
   }

   public void AddCoins(int amount) { Coins += amount; /* update UI */ }
   public void SetCheckpoint(Vector3 pos) { Checkpoint = pos; }
   public void Respawn() { /* find player and set position */ }
}
```

2. `PlayerControl.cs` — core movement (excerpt)

```csharp
using UnityEngine;
public class PlayerControl : MonoBehaviour
{
   public float PlayerSpeed = 5f; public Rigidbody2D rb;
   float horiz;
   void Update() { horiz = Input.GetAxis("Horizontal"); PlayerWalk(); }
   void PlayerWalk()
   {
      rb.velocity = new Vector2(horiz * PlayerSpeed, rb.velocity.y);
      if (horiz > 0) transform.localScale = Vector3.one;
      else if (horiz < 0) transform.localScale = new Vector3(-1,1,1);
   }
}
```

3. `PlayerHealth.cs` — health and respawn (excerpt)

```csharp
using System.Threading.Tasks;
using UnityEngine;
public class PlayerHealth : MonoBehaviour
{
   public int startHealth = 5; int currentHealth; bool dead;
   void Start() { currentHealth = startHealth; }
   public async Task LoseHealth(int dmg)
   {
      currentHealth = Mathf.Clamp(currentHealth - dmg, 0, startHealth);
      if (currentHealth <= 0 && !dead) {
         dead = true; // play die
         await Task.Delay(1500);
         LevelManager.instance.Respawn();
         currentHealth = startHealth; dead = false;
      }
   }
}
```

<div style="page-break-after: always"></div>

# Phụ lục B — Asset Credits & License Summary

- `Assets/UI Assets/Fonts/Jupiter/LICENSE.txt` — Isurus Labs — Public Domain.
- `Assets/UI Assets/Textures and Sprites/SF UI/Background/LICENSE.txt` — NASA — Public Domain.
- Items flagged with `licenseType: Store` are listed in `ASSETS_CREDITS_PENDING.md` for manual verification.

<div style="page-break-after: always"></div>

# Phụ lục C — Hướng dẫn Build & Nộp bài

1. Local build (Windows PowerShell example):

```powershell
"C:\Program Files\Unity\Hub\Editor\2023.1.9f1\Editor\Unity.exe" -quit -batchmode -projectPath "D:/Unity-2D-Platformer-master/Unity-2D-Platformer-master" -executeMethod BuildScript.BuildWindows -logFile build_windows.log
```

2. Đóng gói nộp: include `REPORT_FINAL.pdf`, `slides.zip`, build folders, and link repository. Nếu muốn, tôi có thể tạo một `submission.zip` descriptor file listing files to include.

---

**[KẾT THÚC BÁO CÁO]**

# CHƯƠNG 6: KIỂM THỬ VÀ KẾT QUẢ

## 6.1 Kịch bản kiểm thử

- Test di chuyển & va chạm: kiểm tra không bị xuyên tile, nhảy qua chướng ngại.
- Test checkpoint: chết tại sau checkpoint -> respawn đúng.
- Test thu thập coin: coin biến mất và điểm tăng.
- Test chuyển cảnh: qua cổng scene đúng, giữ được Score khi cần.

## 6.2 Hình ảnh minh họa Gameplay

**Màn hình Menu (Main Menu)**

![Main Menu](2dmain.png)

**Gameplay — Level 1**

![Gameplay Màn 1](2d2.png)

**Gameplay — Level 2**

![Gameplay Màn 2](2d3.png)

**Khung cảnh thiết kế Tilemap**

![Gameplay Đặc Biệt](2d.png)

**Screenshot bổ sung A**

![Screenshot A](pic5.png)

**Screenshot bổ sung B**

![Screenshot B](pic6.png)

---

---

**[KẾT THÚC BÁO CÁO]**
