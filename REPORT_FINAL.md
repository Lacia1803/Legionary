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

# CHƯƠNG 2: PHÂN TÍCH VÀ THIẾT KẾ GAMEPLAY

## 2.1 Cốt truyện chi tiết và bối cảnh (Extended)

Legionary theo chân một chiến binh trẻ tuổi bị lưu đày khỏi vương quốc. Mỗi level đại diện cho một vùng địa hình với chủ đề và thách thức riêng:
- Level 1 — Vùng rừng ven thành: địa hình có nền đất vững, một vài hố nhỏ, enemy đơn giản, mục tiêu dạy người chơi di chuyển cơ bản.
- Level 2 — Hang động ngầm: nền trơn trượt, nhiều hố sâu, hazard kéo dài, enemy có hành vi tấn công điểm.
- Level 3 — Pháo đài đổ nát: kết hợp bẫy, moving platforms, quái mạnh hơn, checkpoint thưa.

Mỗi level có kịch bản nhỏ (micro-story) để tạo động lực cho người chơi: thu thập vật phẩm, giải đố môi trường, hoặc tiêu diệt miniboss.

## 2.2 Luật chơi chi tiết (Rules & Mechanics)

- Di chuyển: lực chịu tác động từ Rigidbody2D, áp dụng hệ số friction (Physics Material 2D) để điều chỉnh cảm giác dừng, trượt.
- Nhảy: sử dụng impulse vertical velocity thay vì thay đổi transform, đảm bảo tương tác chính xác với collider.
- Double-jump / wall-jump (tùy biến): Implemented as optional component toggled trong PlayerControl để dễ test.
- Health: mỗi lần va chạm với collider tagged "Enemy" hoặc "Hazard" sẽ gọi `PlayerHealth.LoseHealth(damage)` với giá trị damage khác nhau.

## 2.3 Level Design Patterns và Difficulty Curve

Thiết kế độ khó theo dạng S-curve: Level 1 giới thiệu mechanics, Level 2 mở rộng bằng hazard phức tạp, Level 3 kết hợp mọi yếu tố và เพิ่ม boss encounter. Mục tiêu là giữ flow gameplay — tránh spike difficulty bằng cách sử dụng checkpoints có khoảng cách hợp lý.

## 2.4 User Flow và UX Considerations

- Visual feedback: particle effect + sound khi nhặt coin giúp người chơi nhận biết immediate reward.
- Telemetry (local logs): ghi lại sự kiện quan trọng (checkpoint reached, deaths) vào console để phát hiện khó khăn trong playtest.
- Accessibility: hỗ trợ remappable keys qua input manager và scale UI cho màn hình khác nhau.

<div style="page-break-after: always"></div>

# CHƯƠNG 3: THIẾT KẾ HỆ THỐNG VÀ KIẾN TRÚC (MỞ RỘNG)

## 3.1 Kiến trúc tổng thể (Component-based)

Unity dùng mô hình component — mọi hành vi gắn vào GameObject thông qua MonoBehaviour. Dự án chia thành các subsystem:
- Core: `LevelManager`, `GameManager` (flow tổng), `SaveManager` (tùy tương lai).
- Player: `PlayerControl`, `PlayerHealth`, `PlayerAnimation`.
- Enemy: base class `EnemyBase` với state machine đơn giản (Patrol, Chase, Attack, Hurt).
- World: tilemaps, hazards, triggers.
- UI: HUD, Menus, Popup dialogues.

## 3.2 Sơ đồ lớp chi tiết và giao tiếp

Mỗi lớp có trách nhiệm single-responsibility:
- `LevelManager`: quản lý coins, checkpoint, global state, high-level events.
- `PlayerControl`: đọc Input, apply velocity, flip sprite, trigger animation.
- `PlayerHealth`: track HP, invincibility frames (i-frames), death flow.
- `CollectableObjects`: interface `ICollectable` có `Collect(GameObject collector)` để dễ mở rộng.

Sequence example: Player collides with Coin -> `CollectableObjects.Collect()` gọi `LevelManager.AddCoins()` -> `UIManager.UpdateScore()` -> play SFX.

## 3.3 Design Patterns Applied

- Singleton: `LevelManager` để cung cấp điểm truy xuất O(1).
- Observer/Event Bus: custom event `OnPlayerDie`, `OnCoinCollected` để giảm coupling giữa systems.
- Factory (light): `EnemyFactory` prefab-instantiates enemies cho từng level, hỗ trợ difficulty scaling.

<div style="page-break-after: always"></div>

# CHƯƠNG 4: CHI TIẾT TRIỂN KHAI VÀ HIỆN THỰC (MÃ NGUỒN) — MỞ RỘNG

Trong chương này trình bày chi tiết các hàm, thuật toán và quyết định kỹ thuật kèm mã nguồn.

## 4.1 PlayerControl — Implementation notes

Key considerations:
- Use `FixedUpdate` for physics-driven movement when applying forces; `Update` for input polling.
- Movement smoothing: apply `Mathf.SmoothDamp` for gradual acceleration/deceleration if needed.

Pseudo-code for improved jump logic (coyote time + variable jump height):

1. Track `timeSinceLeftGround` to allow jump within short window after leaving ground (coyote time).
2. On Jump button down, if grounded or within coyote window -> apply jump velocity.
3. While jump held and verticalVelocity > 0, apply extra upward acceleration to allow variable jump height.

## 4.2 PlayerHealth — Robust handling

- Implement invincibility frames: after being hit, set `isInvincible=true` and start coroutine to disable.
- Use `Mathf.Clamp` to prevent health overflow/underflow.

## 4.3 Collectables and Pooling

Destroying many small objects (coins, particles) causes GC churn. For production, implement object pooling:
- `PoolManager` pre-instantiates X coin prefabs, reuses them on Collect -> `SetActive(false)` instead of Destroy.

## 4.4 Camera and Level Bounds

- Camera follows player with `Vector3.Lerp` and clamps to level bounds using a `Bounds` calculated from Tilemap.

## 4.5 BuildScript & CI considerations

`Assets/Editor/BuildScript.cs` enables command-line builds. For CI (GitHub Actions) one can call Unity in headless mode on a self-hosted runner or use Unity Cloud Build. Example GitHub Actions step (self-hosted runner with Unity):

```yaml
- name: Build Windows
  run: |
   "C:/Program Files/Unity/Hub/Editor/2023.1.9f1/Editor/Unity.exe" -quit -batchmode -projectPath %GITHUB_WORKSPACE% -executeMethod BuildScript.BuildWindows -logFile build_windows.log
```

<div style="page-break-after: always"></div>

# CHƯƠNG 5: TỔNG HỢP ASSETS, AUDIO VÀ UI (MỞ RỘNG)

## 5.1 Assets inventory & optimization

- Textures: prefer power-of-two sizes for GPU mipmapping; use `Sprite Packer` to atlasing UI sprites.
- Audio: compress SFX with ADPCM for smaller size, keep music as PCM if quality matters.
- Fonts: include only required glyph ranges to reduce build size (via font asset settings).

## 5.2 UI design and accessibility

- Responsive Canvas: use Canvas Scaler (Scale With Screen Size) and safe areas handling for various aspect ratios.
- UI animations should be cheap (tweening via RectTransform anchoredPosition) and avoid frequent layout rebuilds.

## 5.3 Licensing & Asset Credits (summary)

See `ASSETS_CREDITS.md` for detected public-domain assets and `ASSETS_CREDITS_PENDING.md` for items requiring manual Asset Store verification. Include author names and license type in final appendix.

<div style="page-break-after: always"></div>

## 6. CHƯƠNG 6: KIỂM THỬ VÀ KẾT QUẢ
(Phần này giữ nguyên; hình ảnh minh họa đã thêm)

<div style="page-break-after: always"></div>

# CHƯƠNG 7: QUÁ TRÌNH PHÁT TRIỂN (NHẬT KÝ & GIT) — MỞ RỘNG

## 7.1 Nhật ký làm việc chi tiết theo ngày

- Ngày 1: Thiết lập project, import tilemap và kiểm tra pipeline URP.
- Ngày 2–4: Thiết kế player mechanics, iterative playtest để cân bằng nhảy và tốc độ.
- Ngày 5–10: Thiết lập enemy prefabs, checkpoints, UI HUD.
- Ngày 11–15: Thêm audio, polish animations, test performance trên target machine.

## 7.2 Lịch sử commit và phân công (tóm tắt)

Repository có 18 commit chính do Phùng Võ Quốc Hiển. Phân công công việc (self-assigned):
- Code core systems (PlayerControl, PlayerHealth, LevelManager): 60%
- Art & Tileset integration: 20%
- Documentation, report, slides: 20%

Để minh bạch, phần phụ lục kèm danh sách hash commit (tùy xuất file `git log --pretty=oneline`) có thể được đính kèm khi nộp.

<div style="page-break-after: always"></div>

# CHƯƠNG 8: KẾT LUẬN VÀ HƯỚNG PHÁT TRIỂN (MỞ RỘNG)

## 8.1 Đánh giá kết quả

Dự án hoàn thành các mục tiêu chính: mechanics, 3 level, UI, audio, build script. Phần mở rộng (AI nâng cao, object pooling) được ghi trong roadmap.

## 8.2 Hạn chế kỹ thuật

- Không dùng object pooling cho tất cả effect -> có thể gây GC spikes khi spawn nhiều particle.
- Một số assets cần xác minh license (Asset Store) để đảm bảo tuân thủ giấy phép phân phối.

## 8.3 Roadmap & cải tiến đề xuất

- Implement Object Pooling cho coins/particles.
- Add enemy behavior trees hoặc navmesh-based pathfinding for smarter AI.
- Integrate analytics (local logs) and automated screenshot tests with Unity Test Runner.

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
