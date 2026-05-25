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

*Lưu ý:* Một số tệp (ví dụ `Level 1.unity`, một vài ảnh trong `Character file/`) có `.meta` chỉ ra `licenseType: Store` — nghĩa là tài nguyên này được lấy từ Unity Asset Store hoặc gói bản quyền; cần mở Unity để xem chi tiết author/license package.

## Âm thanh

- `Assets/Game assets/Audio Files/ASF.mp3`
- `Assets/Game assets/Audio Files/CaveSF.mp3`
- `Assets/Game assets/Audio Files/level 1 ambience.mp3`
- `Assets/Game assets/Audio Files/Death.mp3`
- `Assets/Game assets/Audio Files/Level 2 ambience.mp3`
- `Assets/Game assets/Audio Files/water ambience.mp3`
- `Assets/Game assets/Audio Files/WinSF.mp3`
- `Assets/Game assets/Music/Tropical Moments.wav` và phiên bản loop — nguồn/license: chưa rõ

### Phát hiện license tự động

- Hiện không tìm thấy file license kèm theo trong thư mục `Assets/Game assets/Audio Files/`. Các file âm thanh được liệt kê cần kiểm tra nguồn gốc (Asset Store package, tác giả cá nhân, hoặc free license). Nếu bạn nhớ đã tải gói âm thanh từ nguồn nào (FreeSound, Asset Store...), ghi lại nguồn để mình cập nhật.

## Phông chữ (Fonts)

- `Assets/UI Assets/Fonts/Jupiter/Jupiter.ttf` — file font (kiểm tra license kèm theo)
- `Assets/UI Assets/Fonts/Jupiter/Rajdhani-Light.ttf` — họ phông Rajdhani (kiểm tra license)
- `Assets/UI Assets/Fonts/Jupiter/Rajdhani-Bold.ttf` — họ phông Rajdhani (kiểm tra license)

### Phát hiện license tự động

- `Assets/UI Assets/Fonts/Jupiter/LICENSE.txt` nội dung: "The Jupiter font is created by Isurus Labs and is in the public domain." ⇒ License: Public Domain (Isurus Labs). Ghi credit: "Isurus Labs - Public Domain".

*Lưu ý:* Các tệp Rajdhani có thể là bản quyền mở (Google Fonts - SIL Open Font License) — bạn nên kiểm tra metadata hoặc nguồn tải (nếu thuộc Google Fonts, thường là SIL OFL).

## Video

- `Assets/Game assets/Videos/IntroVideo.mp4` — video intro nằm trong dự án (nếu lấy từ nguồn ngoài cần kiểm tra quyền sử dụng)

## Các bước tiếp theo (cần làm)


1. Với mỗi mục trong danh sách, nếu `.meta` có `licenseType: Store` — mở Unity, vào Package Manager hoặc Asset Store để xem chi tiết package và lưu thông tin author/license.
2. Với tài nguyên có file `LICENSE.txt` (ví dụ NASA background, Jupiter font) mình đã ghi kết quả ở trên; các mục khác vẫn cần kiểm tra thủ công.
3. Ghi rõ license bên cạnh từng asset trong tệp này khi xác định được (ví dụ: `Public Domain (NASA)`, `SIL OFL`, `CC-BY 4.0`, `Royalty-free`, `Paid - Asset Store (tên tác giả)`). Nếu tài nguyên do bạn tự tạo, ghi `Created by: Phùng Võ Quốc Hiển (Lacia)`.

Nếu bạn muốn, mình có thể tiếp tục tự động quét `.meta` để liệt kê tất cả các file có `licenseType: Store` và tóm tắt đường dẫn đến từng file ở cuối tệp này.

Nếu bạn muốn, mình có thể tự động tìm trong repository các tệp metadata (ví dụ `manifest.json`, `package.json`) để hỗ trợ xác định nguồn tài nguyên.
