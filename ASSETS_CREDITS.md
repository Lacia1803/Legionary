# Ghi nhận Tài nguyên (Assets) & Bản quyền

Tệp này liệt kê các tài nguyên quan trọng (hình ảnh, âm thanh, font) được đưa vào dự án. Với mỗi tài nguyên lấy từ bên ngoài, cần tra cứu và giữ lại thông tin bản quyền (license) gốc và ghi nhận tác giả trong báo cáo nộp cuối kỳ.

Dưới đây là các tài nguyên đã tìm thấy trong thư mục `Assets/`. Nếu nguồn gốc hoặc license chưa rõ, cần mở gói import gốc trong Unity hoặc kiểm tra trang tải xuống ban đầu.

## Hình ảnh / Sprite

- `Assets/Custom Tileset/Tilesets/Level_1/Level_1_256x256.png` — Tileset cho Level 1 (nguồn: chưa rõ)
- `Assets/Custom Tileset/Props/Weapons/Weapons_01.png` — Sprite vũ khí (nguồn: chưa rõ)
- `Assets/Enemy Knight/ColorSwap/swap_texture.png` — Texture cho enemy (nguồn: bộ asset Enemy Knight demo)
- Nhiều sprite UI nằm trong `Assets/UI Assets/Textures and Sprites/` (nút, panel, background) — có thể lấy từ các UI pack.

### Phát hiện license tự động

- `Assets/UI Assets/Textures and Sprites/SF UI/Background/` có file `LICENSE.txt` ghi: "The background image is created by NASA and is in the public domain." ⇒ License: Public Domain (NASA). Bạn có thể giữ nguyên và ghi credit: "NASA - Public Domain".

_Lưu ý:_ Một số tệp (ví dụ `Level 1.unity`, một vài ảnh trong `Character file/`) có `.meta` chỉ ra `licenseType: Store` — nghĩa là tài nguyên này được lấy từ Unity Asset Store hoặc gói bản quyền; cần mở Unity để xem chi tiết author/license package.

## Âm thanh

- `Assets/Game assets/Audio Files/ASF.mp3`
- `Assets/Game assets/Audio Files/CaveSF.mp3`
- `Assets/Game assets/Audio Files/level 1 ambience.mp3`
- `Assets/Game assets/Audio Files/Death.mp3`
- `Assets/Game assets/Audio Files/Level 2 ambience.mp3`
- `Assets/Game assets/Audio Files/water ambience.mp3`
- `Assets/Game assets/Audio Files/WinSF.mp3`
- `Assets/Game assets/Music/Tropical Moments.wav` và phiên bản loop — nguồn/license: chưa rõ

## Phông chữ (Fonts)

- `Assets/UI Assets/Fonts/Jupiter/Jupiter.ttf` — file font (kiểm tra license kèm theo)
- `Assets/UI Assets/Fonts/Jupiter/Rajdhani-Light.ttf` — họ phông Rajdhani (kiểm tra license)
- `Assets/UI Assets/Fonts/Jupiter/Rajdhani-Bold.ttf` — họ phông Rajdhani (kiểm tra license)

### Phát hiện license tự động

- `Assets/UI Assets/Fonts/Jupiter/LICENSE.txt` nội dung: "The Jupiter font is created by Isurus Labs and is in the public domain." ⇒ License: Public Domain (Isurus Labs). Ghi credit: "Isurus Labs - Public Domain".
