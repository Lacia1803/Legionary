# Ghi nhận Tài nguyên (Assets) & Bản quyền

Tệp này liệt kê các tài nguyên quan trọng (hình ảnh, âm thanh, font) được đưa vào dự án. Với mỗi tài nguyên lấy từ bên ngoài, cần tra cứu và giữ lại thông tin bản quyền (license) gốc và ghi nhận tác giả trong báo cáo nộp cuối kỳ.

Dưới đây là các tài nguyên đã tìm thấy trong thư mục `Assets/`. Nếu nguồn gốc hoặc license chưa rõ, cần mở gói import gốc trong Unity hoặc kiểm tra trang tải xuống ban đầu.

## Hình ảnh / Sprite

- `Assets/Custom Tileset/Tilesets/Level_1/Level_1_256x256.png` — Tileset cho Level 1 (nguồn: chưa rõ)
- `Assets/Custom Tileset/Props/Weapons/Weapons_01.png` — Sprite vũ khí (nguồn: chưa rõ)
- `Assets/Enemy Knight/ColorSwap/swap_texture.png` — Texture cho enemy (nguồn: bộ asset Enemy Knight demo)
- Nhiều sprite UI nằm trong `Assets/UI Assets/Textures and Sprites/` (nút, panel, background) — có thể lấy từ các UI pack.

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

## Video

- `Assets/Game assets/Videos/IntroVideo.mp4` — video intro nằm trong dự án (nếu lấy từ nguồn ngoài cần kiểm tra quyền sử dụng)

## Các bước tiếp theo (cần làm)

1.  Với mỗi mục trong danh sách, mở gói import gốc trong Unity (hoặc kiểm tra trang tải Asset Store/nguồn tải) và xác định thông tin license/attribution.
2.  Ghi rõ license bên cạnh từng asset trong tệp này (ví dụ: `CC-BY 4.0`, `Royalty-free`, `Paid (đã mua kèm license)`), và nếu cần attribution hãy ghi tác giả + link nguồn.
3.  Nếu tài nguyên do bạn tự tạo, đánh dấu rõ: `Created by: Phùng Võ Quốc Hiển (Lacia)`.

Nếu bạn muốn, mình có thể tự động tìm trong repository các tệp metadata (ví dụ `manifest.json`, `package.json`) để hỗ trợ xác định nguồn tài nguyên.
