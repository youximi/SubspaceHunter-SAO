# Open Source Asset Policy

This Unity project contains a large amount of third-party and binary content. Do not publish the repository before reviewing license rights for every asset folder.

## Current size profile

- `Assets/`: about 26 GB.
- Largest folders include `Assets/SubspaceHunter`, `Assets/Resources`, `Assets/Knife`, `Assets/Frank_Slash_Pack`, `Assets/InsaneGunner`, `Assets/Rifle_27A2_Pro`, and `Assets/Oculus`.
- Several individual files are above 100 MiB, including large textures, videos, fonts, DLLs, and imported models.

## GitHub strategy

Use this split:

1. Keep source code, project settings, package manifests, small configs, and open-source-safe prefabs/scenes in Git.
2. Put large binary assets in Git LFS when they are required to open or run the demo.
3. Do not commit paid Asset Store packages, copyrighted character/media assets, or redistributable files whose licenses are unclear.
4. For optional large demo content, publish separate downloadable archives in GitHub Releases or an external storage bucket.
5. Provide a small replacement asset set for open-source builds when original assets cannot be redistributed.

## Asset folders needing license review

Review these before making the repository public:

- `Assets/SAO`
- `Assets/SubspaceHunter`
- `Assets/Knife`
- `Assets/Frank_Slash_Pack`
- `Assets/InsaneGunner`
- `Assets/Rifle_27A2_Pro`
- `Assets/Weapons Pro Pack`
- `Assets/PureNature`
- `Assets/Oculus`
- `Assets/Rabbit312319_Enemy`
- `Assets/SpearAndHalberdAnimset`
- `Assets/Allsky`
- `Assets/GabrielAguiarProductions`
- `Assets/YummyGames`
- `Assets/3D Gamekit - Environment Pack`
- Any folder named after a commercial asset pack or copyrighted IP.

## Recommended public repository layout

Recommended:

```text
Assets/
  SubspaceHunter/Script/
  SubspaceHunter/Scenes/Script/
  PublicDemo/PublicScenes/
  Resources/Configs/
Packages/
ProjectSettings/
docs/
```

`Assets/PublicDemo/PublicScenes/` is included through Git LFS because the scene files are important project content. The scenes are not self-contained yet; their external asset dependencies are tracked in `docs/PUBLIC_DEMO_DEPENDENCIES.zh-CN.md`.

Optional or restricted assets should be replaced with placeholders, moved to a separate private archive, or provided through documented import steps.

## Before first GitHub push

1. Run `git lfs install`.
2. Confirm `.gitattributes` is committed before adding large files.
3. Check for files above 50 MiB with:

   ```powershell
   Get-ChildItem -Recurse -File | Where-Object { $_.Length -gt 50MB } | Sort-Object Length -Descending
   ```

4. Check for secrets:

   ```powershell
   rg -n "apiKey|API_KEY|secret|password|Authorization|sk-" Assets Packages ProjectSettings
   ```

5. Do a clean clone test on another path before publishing.
