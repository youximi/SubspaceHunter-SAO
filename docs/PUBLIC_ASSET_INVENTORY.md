# Public Asset Inventory

This inventory is a working checklist for deciding what can be published in the public GitHub repository. It is not a legal opinion. Treat every third-party, paid, or IP-derived asset as restricted until its license is confirmed.

## Current Public Repository

Already published:

- `Packages/`
- `ProjectSettings/`
- `Assets/SubspaceHunter/Script/**/*.cs`
- `Assets/SubspaceHunter/Scenes/Script/**/*.cs`
- `Assets/PublicDemo/PublicScenes/*.unity` through Git LFS
- matching script and folder `.meta` files
- project documentation

Not yet published:

- self-contained runnable demo scenes
- prefabs
- models
- textures
- audio
- video
- paid Asset Store packages
- SDK plugin folders under `Assets`
- database files and baked/generated binary files

## Classification

| Class | Meaning | GitHub action |
| --- | --- | --- |
| A | Already public or safe source/config | Keep in Git |
| B | Possibly publishable if confirmed original or permissively licensed | Review, then Git LFS if binary |
| C | Third-party SDK/package with its own license or official distribution path | Prefer package/install instructions over committing |
| D | Paid Asset Store, copyrighted IP, fan art, copied media, or unclear source | Do not publish; replace or document import steps |
| E | Generated cache, bake output, local scratch, build artifacts | Ignore/exclude |

## Repository-Scale Summary

Local `Assets/` is about 26 GB. Largest top-level folders:

| Path | Size | Files | Class | Recommendation |
| --- | ---: | ---: | --- | --- |
| `Assets/SubspaceHunter` | mixed | mixed | Mixed | Keep scripts and PublicDemo scene references public; split art/media into review batches |
| `Assets/SAO` | legacy/moved | legacy/moved | Mixed | Script content has moved to `Assets/SubspaceHunter`; review any remaining local content before publishing |
| `Assets/Knife` | 2316.05 MB | 1284 | D | Do not publish unless license allows redistribution |
| `Assets/Resources` | 2311.42 MB | 1991 | Mixed/D | Do not publish as-is; replace or move reviewed assets to LFS |
| `Assets/Frank_Slash_Pack` | 1723.85 MB | 2372 | D | Do not publish unless license allows redistribution |
| `Assets/InsaneGunner` | 1491.96 MB | 1607 | D | Do not publish unless license allows redistribution |
| `Assets/Rifle_27A2_Pro` | 1347.25 MB | 1852 | D | Do not publish unless license allows redistribution |
| `Assets/PureNature` | 1040.08 MB | 1635 | D | Do not publish unless license allows redistribution |
| `Assets/Weapons Pro Pack` | 928.29 MB | 2638 | D | Do not publish unless license allows redistribution |
| `Assets/剑盾动作2` | 853.41 MB | 1447 | D | Do not publish unless license/source is confirmed |
| `Assets/Oculus` | 809.12 MB | 5327 | C | Prefer official Meta/Oculus SDK install instructions |
| `Assets/Editor` | 555.01 MB | 536 | Mixed/C/D | Contains Bakery binaries; do not publish as-is |
| `Assets/Rabbit312319_Enemy` | 534.90 MB | 1671 | D | Do not publish unless license allows redistribution |
| `Assets/SpearAndHalberdAnimset` | 476.72 MB | 76 | D | Do not publish unless license allows redistribution |
| `Assets/Allsky` | 468.52 MB | 507 | D | Do not publish unless license allows redistribution |
| `Assets/Perfect RPG MMO 3D Effect VFX Pack` | 419.19 MB | 2497 | D | Do not publish unless license allows redistribution |
| `Assets/Goblin_sword_shield_AnimSet` | 403.56 MB | 467 | D | Do not publish unless license allows redistribution |
| `Assets/YummyGames` | 390.49 MB | 1352 | D | Do not publish unless license allows redistribution |
| `Assets/GabrielAguiarProductions` | 387.92 MB | 1028 | D | Do not publish unless license allows redistribution |
| `Assets/Werewolf_Animset` | 373.99 MB | 445 | D | Do not publish unless license allows redistribution |
| `Assets/Character` | 357.49 MB | 689 | D | Do not publish until source/license is known |
| `Assets/NatureManufacture Assets` | 325.97 MB | 66 | D | Do not publish unless license allows redistribution |
| `Assets/_MK` | 236.86 MB | 4542 | D/C | Review MK Toon license; prefer package/source instructions |
| `Assets/JMO Assets` | 221.39 MB | 3912 | D | Do not publish unless license allows redistribution |
| `Assets/Real Recorded Guns & Bullet Sounds` | 150.65 MB | 1016 | D | Do not publish unless license allows redistribution |
| `Assets/Plugins` | 144.37 MB | 1628 | Mixed/C/D | Split by vendor; prefer install instructions |
| `Assets/Bakery` | 141.82 MB | 584 | D | Paid plugin likely; do not publish |
| `Assets/OrdosFX` | 140.69 MB | 923 | D | Do not publish unless license allows redistribution |
| `Assets/ARPG Effects` | 132.52 MB | 797 | D | Do not publish unless license allows redistribution |
| `Assets/SkinnedDecal` | 131.07 MB | 390 | D/C | Review license before publishing |

## `Assets/SubspaceHunter` Breakdown

`Assets/SubspaceHunter` is the reorganized main project content folder, but it is mixed code, scenes, fan/IP-inspired assets, third-party assets, and media. Treat only the script folders and approved PublicDemo scenes as public for now.

| Path | Size | Files | Class | Recommendation |
| --- | ---: | ---: | --- | --- |
| `Assets/SubspaceHunter/Script` | 0.86 MB | 501 | A | Already public after path migration |
| `Assets/SubspaceHunter/Scenes/Script` | about 0.01 MB | 12 | A | Already public after path migration |
| `Assets/PublicDemo/PublicScenes` | 630.54 MB | 23 | B/E | Included through Git LFS; dependencies still require review |
| `Assets/SubspaceHunter/Model` | 1913.82 MB | mixed | D/E | Do not publish broadly; replace or review model sources one by one |
| `Assets/SubspaceHunter/Font` | 839.77 MB | mixed | D/B/E | Review font licenses; SDF assets are very large |
| `Assets/SubspaceHunter/3rd` | 685.75 MB | mixed | C/D/E | Split by third-party package and license |
| `Assets/SubspaceHunter/Sounds` | 363.66 MB | mixed | D | Do not publish until every sound license is known |
| `Assets/SubspaceHunter/Images` | 140.99 MB | mixed | D/B | UI art may include SAO-derived assets; review before publishing |
| `Assets/SubspaceHunter/Effect` | 32.91 MB | mixed | D/B | Review effect pack/license |
| `Assets/SubspaceHunter/Material` | 17.96 MB | mixed | B | Review texture/source dependencies before publishing |

## `Assets/Resources` Breakdown

The local `Resources` folder is too large for a public Unity repository and too expensive for runtime memory/package size. Do not publish it as-is.

| Path | Size | Files | Class | Recommendation |
| --- | ---: | ---: | --- | --- |
| `Assets/Resources/Configs` | ~0 MB | 9 | A/B | Small generated config data; publish if no private data |
| `Assets/Resources/SAO_Prefab` | 2184.60 MB | 1371 | D | Do not publish; replace with placeholder prefabs or external asset pack |
| `Assets/Resources/花园` | 70.80 MB | 152 | D/B | Review source/license; use LFS if approved |
| `Assets/Resources/Skill_effect` | 47.79 MB | 306 | D/B | Review source/license; use LFS if approved |
| `Assets/Resources/XWeaponTrail` | 6.78 MB | 68 | D/C | Review package license |
| `Assets/Resources/Cuttiing_advance` | 1.43 MB | 65 | B/D | Review source/license |
| `Assets/Resources/System_setting` | 0.01 MB | 3 | B | Review for private settings |

## Large File Watchlist

These files exceed GitHub's normal 100 MB hard limit and must never be committed as normal Git objects. If approved for redistribution, they need Git LFS or external release archives.

| File | Size | Class | Action |
| --- | ---: | --- | --- |
| `Assets/Resources/SAO_Prefab/.../76-1地板高清.png` | 324.48 MB | D | Replace or LFS after license review |
| `Assets/Resources/SAO_Prefab/.../76-1地板高清_N.png` | 324.48 MB | D | Replace or LFS after license review |
| `Assets/Editor/x64/Bakery/cudnn64_7.dll` | 322.53 MB | D/E | Do not publish; plugin install step only |
| `Assets/SAO/AR/Vedeio/刀剑视频.mp4` | 219.29 MB | D | Do not publish |
| `Assets/SAO/Model/SAO原版模型/.../Aincrad031.obj` | 177.10 MB | D | Do not publish |
| `Assets/SAO/Font/*.asset` SDF files | about 128 MB each | D/B | Review font license; regenerate smaller public fallback |
| `Assets/Resources/SAO_Prefab/.../8K地面.png` | 117.77 MB | D | Replace or LFS after license review |
| `Assets/茅场晶彦/Anime Day Equirect.png` | 109.26 MB | D | Do not publish until source/license is known |
| `Assets/Allsky/... Equirect.png` | 81-99 MB | D | Review package license |
| `Assets/SAO/AR/*.unity` major scenes | 57-79 MB | D/B | Do not publish until dependencies are replaced |

## Third-Party Packages With License Files

These folders contain license/readme files and should be handled as separate dependency decisions, not bulk-copied into the public repo:

| Path | Evidence | Recommendation |
| --- | --- | --- |
| `Assets/Oculus` | Oculus SDK license files and notices | Prefer official SDK/package installation instructions |
| `Assets/UniGLTF` | `LICENSE.md`, `README.md` | May be publishable if license obligations are met; prefer upstream package/submodule if possible |
| `Assets/VRM` | `LICENSE.md`, `README.md`, MToon license | May be publishable if license obligations are met; prefer upstream package/submodule if possible |
| `Assets/Plugins/Demigiant/DOTween` | readme found | Review DOTween license; prefer install instructions |
| `Assets/MagicaCloth2` | readme found | Review license; likely do not publish if paid |
| `Assets/Bakery` and `Assets/Editor/x64/Bakery` | plugin binaries | Do not publish; document required plugin/version |
| `Assets/CurvedUI` | readme PDF | Review license; likely do not publish if paid |
| `Assets/Plugins/RootMotion` | FinalIK/PuppetMaster readmes | Do not publish if paid |

## Secret and Service Config Watchlist

Do not publish these until they are rewritten to avoid client-side secrets:

| Path | Issue |
| --- | --- |
| `Assets/chatGPTAIGirlFriendSample` | OpenAI/Azure/Baidu key fields and direct client API calls |
| `Assets/SAO/Script/WangSiFu/Sqlite` | database examples mention password fields; no real secret found in currently published code |
| Android keystore settings in `ProjectSettings/ProjectSettings.asset` | local keystore path exists; do not publish actual keystore |

## Recommended Public Demo Plan

1. Keep current source/config repository as the base.
2. Create a new `Assets/PublicDemo/` folder with original placeholder assets only.
3. Build a minimal scene that uses existing scripts but avoids restricted prefabs, models, audio, and videos.
4. Add only that demo scene and its placeholder assets to Git LFS.
5. Document optional commercial/third-party imports in `docs/DEPENDENCIES.md`.
6. For each reviewed asset batch, add a short license note before publishing it.

## Next Review Batches

Suggested order:

1. `Assets/SAO/AI_config`, `Assets/Resources/Configs`, and other small config-only folders.
2. Small shaders under `Assets/SAO/Shader` and script-adjacent shaders.
3. Original UI icons or self-made materials, if you can confirm authorship.
4. Public demo placeholder models/textures/audio.
5. Optional third-party packages that have permissive licenses.

## Do Not Publish Without Explicit Approval

- Any `SAO原版模型`, character names, videos, music, screenshots, or UI copied from copyrighted IP.
- Any paid Asset Store package folder.
- Any `.unitypackage` installer files.
- Any plugin DLL/bundle/dylib unless the license explicitly allows public redistribution.
- Any API key, keystore, database containing user data, or service credential.
