# ASSETS CREDITS — Pending manual checks

This file lists asset meta entries that were automatically flagged with `licenseType: Store` and therefore require manual verification in the Unity Editor (Asset Store packages, imported store assets, or proprietary packs). Use Unity Editor → Project window → select the asset/package or Window → Package Manager → My Assets to find original author and license.

Detected categories / example paths (manual check recommended):

- Scenes: `Assets/All scenes/Level 1.unity`
- Game assets (Animation, Prefab, Sprite, Material, Music):
  - `Assets/Game assets/Animation/*`
  - `Assets/Game assets/Prefab/*`
  - `Assets/Game assets/Sprite/*`
  - `Assets/Game assets/Music/*` (e.g., `Tropical Moments.wav`)
- Custom Tileset packages (GradientSky shaders & scripts):
  - `Assets/Custom Tileset/Materials/GradientSky/**`
- Character assets: `Assets/Character file/*` (Knight textures, EPS, AI files)
- Various Materials / Shaders: `Assets/Game assets/Material/*`, `Assets/Game assets/Shader/*`

Count: ~60 meta entries were found with `licenseType: Store` during an automated scan.

Recommended workflow to verify each item:
1. Open Unity Editor with this project.
2. In Project window, select an asset listed above.
3. In Inspector, look for import/package information or a link to the Asset Store package.
4. If it is from the Asset Store, open Package Manager → My Assets → locate the package → read license/author page.
5. Record the author, package name, version, and license (Free / Paid / EULA) into `ASSETS_CREDITS.md`.

If you want, I can (A) produce a full file listing of every `.meta` path flagged (one-per-line) to make the manual verification easier, or (B) provide a short PowerShell script you can run locally to extract the list and save it to a file. Which do you prefer? (Reply A or B.)
