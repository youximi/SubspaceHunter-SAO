# 公开资源清单

这份清单用于判断哪些资源适合发布到公开 GitHub 仓库。它不是法律意见。所有第三方、付费、版权 IP 派生或来源不明确的资源，都应先按受限资源处理，直到授权确认完成。

## 当前公开仓库内容

已经公开：

- `Packages/`
- `ProjectSettings/`
- `Assets/SubspaceHunter/Script/**/*.cs`
- `Assets/SubspaceHunter/Scenes/Script/**/*.cs`
- `Assets/PublicDemo/PublicScenes/*.unity`（通过 Git LFS）
- 对应的脚本 `.meta` 和文件夹 `.meta`
- 项目文档

尚未公开：

- 可独立运行的完整 Demo 场景
- Prefab
- 模型
- 贴图
- 音频
- 视频
- 付费 Asset Store 包
- `Assets` 下的 SDK 插件目录
- 数据库文件和烘焙/生成的二进制文件

## 分类标准

| 分类 | 含义 | GitHub 处理方式 |
| --- | --- | --- |
| A | 已公开或安全的源码/配置 | 保留在 Git |
| B | 可能可公开，但需要确认原创或宽松授权 | 审查后发布；二进制走 Git LFS |
| C | 第三方 SDK/包，有自己的授权或官方分发方式 | 优先写安装说明，不直接提交 |
| D | 付费 Asset Store、版权 IP、同人/拷贝媒体、来源不明确 | 不发布；替换或写导入说明 |
| E | 生成缓存、烘焙输出、本地临时文件、构建产物 | 忽略/排除 |

## 仓库规模概览

本地 `Assets/` 约 26 GB。主要大型目录：

| 路径 | 体积 | 文件数 | 分类 | 建议 |
| --- | ---: | ---: | --- | --- |
| `Assets/SAO` | 4692.88 MB | 5784 | 混合 | 保留脚本公开；美术/媒体分批审查 |
| `Assets/Knife` | 2316.05 MB | 1284 | D | 未确认可再分发前不要发布 |
| `Assets/Resources` | 2311.42 MB | 1991 | 混合/D | 不要整体发布；审查后替换或用 LFS |
| `Assets/Frank_Slash_Pack` | 1723.85 MB | 2372 | D | 未确认可再分发前不要发布 |
| `Assets/InsaneGunner` | 1491.96 MB | 1607 | D | 未确认可再分发前不要发布 |
| `Assets/Rifle_27A2_Pro` | 1347.25 MB | 1852 | D | 未确认可再分发前不要发布 |
| `Assets/PureNature` | 1040.08 MB | 1635 | D | 未确认可再分发前不要发布 |
| `Assets/Weapons Pro Pack` | 928.29 MB | 2638 | D | 未确认可再分发前不要发布 |
| `Assets/剑盾动作2` | 853.41 MB | 1447 | D | 确认来源和授权前不要发布 |
| `Assets/Oculus` | 809.12 MB | 5327 | C | 优先改为官方 Meta/Oculus SDK 安装说明 |
| `Assets/Editor` | 555.01 MB | 536 | 混合/C/D | 含 Bakery 二进制，不要整体发布 |
| `Assets/Rabbit312319_Enemy` | 534.90 MB | 1671 | D | 未确认可再分发前不要发布 |
| `Assets/SpearAndHalberdAnimset` | 476.72 MB | 76 | D | 未确认可再分发前不要发布 |
| `Assets/Allsky` | 468.52 MB | 507 | D | 未确认可再分发前不要发布 |
| `Assets/Perfect RPG MMO 3D Effect VFX Pack` | 419.19 MB | 2497 | D | 未确认可再分发前不要发布 |
| `Assets/Goblin_sword_shield_AnimSet` | 403.56 MB | 467 | D | 未确认可再分发前不要发布 |
| `Assets/YummyGames` | 390.49 MB | 1352 | D | 未确认可再分发前不要发布 |
| `Assets/GabrielAguiarProductions` | 387.92 MB | 1028 | D | 未确认可再分发前不要发布 |
| `Assets/Werewolf_Animset` | 373.99 MB | 445 | D | 未确认可再分发前不要发布 |
| `Assets/Character` | 357.49 MB | 689 | D | 来源/授权明确前不要发布 |
| `Assets/NatureManufacture Assets` | 325.97 MB | 66 | D | 未确认可再分发前不要发布 |
| `Assets/_MK` | 236.86 MB | 4542 | D/C | 审查 MK Toon 授权；优先写安装说明 |
| `Assets/JMO Assets` | 221.39 MB | 3912 | D | 未确认可再分发前不要发布 |
| `Assets/Real Recorded Guns & Bullet Sounds` | 150.65 MB | 1016 | D | 未确认可再分发前不要发布 |
| `Assets/Plugins` | 144.37 MB | 1628 | 混合/C/D | 按供应商拆分；优先写安装说明 |
| `Assets/Bakery` | 141.82 MB | 584 | D | 很可能是付费插件，不要发布 |
| `Assets/OrdosFX` | 140.69 MB | 923 | D | 未确认可再分发前不要发布 |
| `Assets/ARPG Effects` | 132.52 MB | 797 | D | 未确认可再分发前不要发布 |
| `Assets/SkinnedDecal` | 131.07 MB | 390 | D/C | 审查授权后再决定 |

## `Assets/SAO` 拆分

`Assets/SAO` 是主项目内容目录，但混有代码、场景、IP 风格资源、第三方资源和媒体。当前只将脚本目录视为可公开内容。

| 路径 | 体积 | 文件数 | 分类 | 建议 |
| --- | ---: | ---: | --- | --- |
| `Assets/SAO/Script` | 0.86 MB | 501 | A | 已公开 |
| `Assets/SAO/AR/Script` | 约 0.01 MB | 12 | A | 已公开 |
| `Assets/SAO/Model` | 1404.64 MB | 1300 | D | 不发布；替换为原创占位模型 |
| `Assets/SAO/AR` | 1015.48 MB | 348 | 混合/D | 暂不发布场景/媒体；另建最小 Demo 场景 |
| `Assets/SAO/Font` | 839.77 MB | 32 | D/B | 审查字体授权；SDF 文件很大 |
| `Assets/SAO/3rd` | 685.75 MB | 383 | C/D | 按第三方包拆分并审查授权 |
| `Assets/SAO/Sounds` | 301.26 MB | 1306 | D | 每个声音授权确认前不发布 |
| `Assets/SAO/Images` | 140.99 MB | 828 | D/B | UI 可能包含 SAO 派生素材；发布前审查 |
| `Assets/SAO/Sky` | 96.96 MB | 26 | D/B | 审查 HDRI/天空盒授权 |
| `Assets/SAO/Animator` | 71.31 MB | 582 | D/B | 审查动画来源；很多动画可能依赖受限模型 |
| `Assets/SAO/Effect` | 32.91 MB | 105 | D/B | 审查特效包/授权 |
| `Assets/SAO/LoadingScene` | 12.22 MB | 117 | D/B | 审查 UI 和依赖资源 |
| `Assets/SAO/Shader` | 0.03 MB | 11 | B | 检查 shader 来源后可考虑发布 |


## `Assets/Resources` 拆分

本地 `Resources` 目录过大，不适合公开 Unity 仓库，也不利于运行时内存和包体控制。不要整体发布。

| 路径 | 体积 | 文件数 | 分类 | 建议 |
| --- | ---: | ---: | --- | --- |
| `Assets/Resources/Configs` | 约 0 MB | 9 | A/B | 小型生成配置；确认无私有数据后可发布 |
| `Assets/Resources/SAO_Prefab` | 2184.60 MB | 1371 | D | 不发布；替换为占位 prefab 或外部资源包 |
| `Assets/Resources/花园` | 70.80 MB | 152 | D/B | 审查来源/授权；批准后走 LFS |
| `Assets/Resources/Skill_effect` | 47.79 MB | 306 | D/B | 审查来源/授权；批准后走 LFS |
| `Assets/Resources/XWeaponTrail` | 6.78 MB | 68 | D/C | 审查包授权 |
| `Assets/Resources/Cuttiing_advance` | 1.43 MB | 65 | B/D | 审查来源/授权 |
| `Assets/Resources/System_setting` | 0.01 MB | 3 | B | 检查是否包含私有设置 |

## 大文件观察清单

这些文件超过 GitHub 普通 Git 的 100 MB 限制，不能作为普通 Git 文件提交。如果授权允许再分发，也必须走 Git LFS 或外部发布包。

| 文件 | 体积 | 分类 | 动作 |
| --- | ---: | --- | --- |
| `Assets/Resources/SAO_Prefab/.../76-1地板高清.png` | 324.48 MB | D | 替换，或授权确认后走 LFS |
| `Assets/Resources/SAO_Prefab/.../76-1地板高清_N.png` | 324.48 MB | D | 替换，或授权确认后走 LFS |
| `Assets/Editor/x64/Bakery/cudnn64_7.dll` | 322.53 MB | D/E | 不发布；只写插件安装步骤 |
| `Assets/SAO/Model/SAO原版模型/.../Aincrad031.obj` | 177.10 MB | D | 不发布 |
| `Assets/SAO/Font/*.asset` SDF 文件 | 每个约 128 MB | D/B | 审查字体授权；为公开版本重新生成较小 fallback |
| `Assets/Resources/SAO_Prefab/.../8K地面.png` | 117.77 MB | D | 替换，或授权确认后走 LFS |
| `Assets/茅场晶彦/Anime Day Equirect.png` | 109.26 MB | D | 来源/授权明确前不发布 |
| `Assets/Allsky/... Equirect.png` | 81-99 MB | D | 审查包授权 |
| `Assets/SAO/AR/*.unity` 主要场景 | 57-79 MB | D/B | 替换依赖前不发布 |

## 带授权文件的第三方包

这些目录包含 license/readme，应作为单独依赖决策处理，不要直接整包复制进公开仓库。

| 路径 | 依据 | 建议 |
| --- | --- | --- |
| `Assets/Oculus` | Oculus SDK license 和 notice 文件 | 优先写官方 SDK/包安装说明 |                           发布，直接放入github
| `Assets/UniGLTF` | `LICENSE.md`、`README.md` | 满足授权义务后可能可发布；优先考虑上游包/子模块 |              不发布，不写安装说明
| `Assets/VRM` | `LICENSE.md`、`README.md`、MToon license | 满足授权义务后可能可发布；优先考虑上游包/子模块 |   不发布，写安装说明
| `Assets/Plugins/Demigiant/DOTween` | 找到 readme | 审查 DOTween 授权；优先写安装说明 |                      不发布，写安装说明
| `Assets/MagicaCloth2` | 找到 readme | 审查授权；若为付费包则不要发布 |                                       发布，直接放入github
| `Assets/Bakery` 和 `Assets/Editor/x64/Bakery` | 插件二进制 | 不发布；记录所需插件和版本 |                    不发布，写安装说明
| `Assets/CurvedUI` | readme PDF | 审查授权；若为付费包则不要发布 |                                            发布，直接放入github
| `Assets/Plugins/RootMotion` | FinalIK/PuppetMaster readme | 若为付费包则不要发布 |                          不发布，写安装说明

## 密钥和服务配置观察清单

这些内容在重写前不要发布：

| 路径 | 问题 |
| --- | --- |
| `Assets/chatGPTAIGirlFriendSample` | 包含 OpenAI/Azure/Baidu key 字段和客户端直连 API 调用 |
| `Assets/SAO/Script/WangSiFu/Sqlite` | 示例中出现 password 字段；当前已公开代码未发现真实密钥 |
| `ProjectSettings/ProjectSettings.asset` 的 Android keystore 设置 | 有本地 keystore 路径；不要发布实际 keystore 文件 |

## 推荐的公开 Demo 计划

1. 保持当前“源码/配置仓库”为基础。
2. 新建 `Assets/PublicDemo/`，只放原创占位资源。
3. 搭一个最小场景，使用现有脚本，但避开受限 prefab、模型、音频和视频。
4. 只把这个 Demo 场景和占位资源加入 Git LFS。
5. 在 `docs/DEPENDENCIES.md` 中记录可选商业/第三方导入步骤。
6. 每一批资源发布前，补充简短授权说明。

## 下一批审查顺序

建议顺序：

1. `Assets/SAO/AI_config`、`Assets/Resources/Configs` 和其他小型纯配置目录。
2. `Assets/SAO/Shader` 以及脚本附近的小 shader。
3. 能确认原创的 UI 图标或自制材质。
4. 公开 Demo 的占位模型、贴图、音频。
5. 授权宽松的第三方包。

## 未明确批准前不要发布

- 任何 `SAO原版模型`、角色名相关资源、视频、音乐、截图，或来自版权 IP 的 UI。
- 任何付费 Asset Store 包目录。
- 任何 `.unitypackage` 安装包。
- 任何插件 DLL、bundle、dylib，除非授权明确允许公开再分发。
- 任何 API key、keystore、包含用户数据的数据库或服务凭据。
