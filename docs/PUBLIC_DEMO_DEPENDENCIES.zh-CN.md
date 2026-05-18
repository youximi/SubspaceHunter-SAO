# PublicDemo 外部依赖审计

这份文档记录 `Assets/PublicDemo/PublicScenes/` 下场景引用到的外部资源根目录，用于判断哪些资源可以迁移进公开仓库，哪些应改为安装/导入说明，哪些因为版权、授权或体积原因不应直接公开。

本清单是工程审计，不是法律意见。未确认来源和再分发授权前，第三方资源、付费 Asset Store 资源、版权 IP 派生资源都应按受限资源处理。

## 扫描范围

- 扫描日期：2026-05-18
- 场景目录：`Assets/PublicDemo/PublicScenes/`
- 场景数量：11
- 场景文件总量：约 630 MB
- 场景内唯一 GUID 引用：621
- 可解析到 `Assets/PublicDemo` 之外的唯一资源：587
- 无法在当前项目 `.meta` 中解析的 GUID：34

## PublicDemo 场景文件

| 场景 | 体积 | GUID 引用次数 |
| --- | ---: | ---: |
| `AR_tourNew.unity` | 78.82 MB | 6108 |
| `SAO_75.unity` | 78.20 MB | 7625 |
| `花园改.unity` | 66.25 MB | 11711 |
| `地狱围栏.unity` | 60.21 MB | 4328 |
| `74层boss房.unity` | 60.10 MB | 4279 |
| `地狱平台.unity` | 57.54 MB | 4406 |
| `第一层boss房.unity` | 57.41 MB | 4449 |
| `VR_BattleRoom.unity` | 57.36 MB | 4337 |
| `雪地场景.unity` | 57.33 MB | 4256 |
| `AR.unity` | 57.26 MB | 4173 |
| `进入游戏.unity` | 0.06 MB | 138 |

## 处理分类

| 分类 | 含义 | 建议处理 |
| --- | --- | --- |
| A | 项目自有源码或小型配置，风险较低 | 可直接迁移进 Git，保留 `.meta` |
| B | 看起来像项目自有内容，但包含美术/音频/字体/场景等，需要来源确认 | 授权确认后迁移；大文件走 Git LFS |
| C | 官方 SDK 或带 license/readme 的第三方依赖 | 优先写导入说明，不直接提交完整包 |
| D | 付费包、版权 IP 派生、来源不明或明显商业素材 | 不直接公开；替换或仅记录依赖 |
| E | 体积过大，即使可公开也不适合普通 Git | 授权确认后用 Git LFS、Release 包或外部下载 |

## 外部依赖根目录

| 根目录 | 唯一资源数 | 触达场景数 | 目录体积 | 分类 | 初步判断 |
| --- | ---: | ---: | ---: | --- | --- |
| `Assets/Resources/SAO_Prefab` | 34 | 11 | 2184.60 MB | B/D/E | 关键 prefab 依赖，但包含 SAO 命名、角色/关卡资源和超大贴图；不应整体公开，需拆分自有 prefab 与受限素材。 |
| `Assets/SubspaceHunter/Model` | 94 | 10 | 1913.82 MB | B/D/E | 主模型依赖；包含 `SAO原版模型`、角色和大模型文件，版权风险高。只迁移确认原创的模型。 |
| `Assets/SubspaceHunter/Animation` | 15 | 11 | 1125.11 MB | B/C/D/E | 动画依赖；发现 readme/PDF，可能来自第三方动画包。确认授权前不要整体公开。 |
| `Assets/PureNature` | 8 | 1 | 1036.96 MB | D/E | 大型自然环境包，疑似第三方/商店资源；优先写导入说明。 |
| `Assets/Weapons Pro Pack` | 6 | 10 | 928.29 MB | D/E | 武器商业资源包特征明显；不直接公开。 |
| `Assets/SubspaceHunter/Font` | 5 | 11 | 839.77 MB | B/D/E | 字体 SDF 文件巨大，且字体授权需确认；建议为开源版重建小型 fallback 字体。 |
| `Assets/Oculus` | 146 | 11 | 809.12 MB | C/E | Meta/Oculus 官方 SDK 与示例资源；优先记录版本和安装步骤，不提交完整 SDK。 |
| `Assets/SubspaceHunter/3rd` | 1 | 1 | 685.75 MB | C/D/E | 第三方效果/过渡资源，含多个 96 MB 纹理资产；按第三方依赖处理。 |
| `Assets/Rabbit312319_Enemy` | 3 | 2 | 534.90 MB | D/E | 包含 Behavior Designer 文档，疑似付费/第三方敌人或行为树资源；不直接公开。 |
| `Assets/Perfect RPG MMO 3D Effect VFX Pack` | 37 | 10 | 419.19 MB | D/E | 商业 VFX 包特征明显；不直接公开。 |
| `Assets/SubspaceHunter/Scenes` | 35 | 11 | 378.94 MB | B/E | 项目场景/脚本相关资源；可拆出必要小资源，但场景和依赖需逐项确认。 |
| `Assets/SubspaceHunter/Sounds` | 30 | 11 | 363.66 MB | B/D/E | 音频授权风险较高；仅迁移确认原创或可再分发音频。 |
| `Assets/Character` | 8 | 11 | 357.49 MB | D/E | 角色资源来源不明确；确认授权前不要公开。 |
| `Assets/NatureManufacture Assets` | 2 | 1 | 325.97 MB | D/E | 第三方环境资源包；优先写导入说明。 |
| `Assets/JMO Assets` | 5 | 10 | 221.39 MB | C/D/E | Cartoon FX 等第三方资源，发现 readme/license；按供应商依赖处理。 |
| `Assets/Plugins` | 4 | 10 | 144.37 MB | C/D | 含 DOTween、FinalIK、PuppetMaster 等插件痕迹；付费插件不应公开，免费插件也应确认 license。 |
| `Assets/SubspaceHunter/Images` | 41 | 11 | 140.99 MB | B/D | UI 图像依赖；发现 SAO Utils Icon Set 和 UI 字体包痕迹，需逐项确认是否原创/可商用。 |
| `Assets/SkinnedDecal` | 1 | 10 | 131.07 MB | C/D/E | 第三方 decal 插件/资源特征；确认授权前不要公开。 |
| `Assets/Resources/花园` | 27 | 1 | 70.80 MB | B/D/E | 花园场景资源；需要确认模型/贴图来源，批准后走 LFS。 |
| `Assets/Vefects` | 1 | 1 | 51.08 MB | C/D/E | VFX 第三方包痕迹，发现 PDF 文档；不直接公开。 |
| `Assets/Resources/Skill_effect` | 5 | 10 | 47.79 MB | B/D | 技能特效依赖；确认来源后再迁移。 |
| `Assets/SubspaceHunter/Effect` | 3 | 2 | 32.91 MB | B/C/D | 项目特效和可能的第三方 sword bloom 资源；逐项审查。 |
| `Assets/SimpleLowPolyNature` | 2 | 1 | 24.03 MB | D | 第三方自然资源包特征；确认授权前不要公开。 |
| `Assets/Humanoid Static Poses` | 4 | 2 | 20.15 MB | C/D | 带 README/PDF 的第三方资源；按 license 审查后决定。 |
| `Assets/SubspaceHunter/Material` | 7 | 10 | 17.96 MB | B | 可能是项目材质；确认贴图来源后可作为迁移候选。 |
| `Assets/Suntail Village` | 8 | 2 | 14.57 MB | D | 第三方场景/村庄包特征；不直接公开。 |
| `Assets/FX2` | 3 | 1 | 11.51 MB | B/D | 特效资源来源不明；需审查。 |
| `Assets/Resources/XWeaponTrail` | 2 | 1 | 6.78 MB | C/D | 带 readme 的武器拖尾插件/资源；按第三方依赖处理。 |
| `Assets/CurvedUI` | 4 | 10 | 5.19 MB | C/D | 带 README PDF，可能为付费插件；优先写导入说明。 |
| `Assets/TextMesh Pro` | 1 | 11 | 3.61 MB | C | Unity/TMP 依赖；一般应通过 Unity Package 或官方资源导入，不手工提交完整包。 |
| `Assets/LukePeek` | 1 | 1 | 3.26 MB | C/D | Snow VFX 第三方资源；确认授权前不要公开。 |
| `Assets/DynamicBone` | 1 | 10 | 3.21 MB | D | 常见付费插件；不直接公开。 |
| `Assets/Resources/Cuttiing_advance` | 3 | 10 | 1.43 MB | B/D | 切割相关资源；确认来源后可考虑迁移。 |
| `Assets/SubspaceHunter/prefab` | 1 | 10 | 1.12 MB | B | 项目 prefab 候选；需要继续解析其二级依赖。 |
| `Assets/SubspaceHunter/Script` | 30 | 11 | 0.86 MB | A | 项目源码；适合公开，需按新路径提交迁移。 |
| `Assets/PassThoughTest` | 3 | 10 | 0.01 MB | B/C | passthrough 测试资源，可能依赖 Oculus；确认无私有内容后可迁移。 |
| `Assets/VoiceVistualizeTest` | 2 | 10 | 0.01 MB | B | 语音可视化测试资源；确认无密钥或私有数据后可迁移。 |
| `Assets/ARShadow` | 2 | 7 | 0.01 MB | B/C | AR 阴影资源；确认来源后可迁移。 |
| `Assets/Resources/System_setting` | 1 | 11 | 0.01 MB | B | 小型系统配置；确认无隐私/本地配置后可迁移。 |
| `Assets/Directional Light.prefab` | 1 | 1 | 0 MB | B | 小型 prefab；可检查后迁移。 |

## 可优先迁移候选

这些目录体积较小或属于项目源码/配置，但仍需保留 `.meta` 并检查是否含私有配置：

- `Assets/SubspaceHunter/Script`
- `Assets/SubspaceHunter/Scenes/Script`
- `Assets/SubspaceHunter/prefab`
- `Assets/SubspaceHunter/Material`
- `Assets/Resources/System_setting`
- `Assets/PassThoughTest`
- `Assets/VoiceVistualizeTest`
- `Assets/ARShadow`
- `Assets/Directional Light.prefab`

## 应改为导入说明的依赖

这些目录属于官方 SDK、插件或带独立 license/readme 的第三方资源。公开仓库中更稳妥的做法是记录版本和安装步骤，不提交完整目录：

- `Assets/Oculus`
- `Assets/TextMesh Pro`
- `Assets/Plugins/Demigiant/DOTween`
- `Assets/Plugins/RootMotion/FinalIK`
- `Assets/Plugins/RootMotion/PuppetMaster`
- `Assets/CurvedUI`
- `Assets/DynamicBone`
- `Assets/Resources/XWeaponTrail`
- `Assets/JMO Assets`
- `Assets/Humanoid Static Poses`
- `Assets/LukePeek`
- `Assets/Vefects`

## 高版权或授权风险目录

这些目录名字、内容或依赖形态显示出付费包、版权 IP 派生、角色模型/音频/场景素材等风险。除非逐项确认有再分发授权，否则不应放入公开仓库：

- `Assets/Resources/SAO_Prefab`
- `Assets/SubspaceHunter/Model`
- `Assets/SubspaceHunter/Animation`
- `Assets/SubspaceHunter/Sounds`
- `Assets/SubspaceHunter/Images`
- `Assets/SubspaceHunter/Font`
- `Assets/PureNature`
- `Assets/Weapons Pro Pack`
- `Assets/Rabbit312319_Enemy`
- `Assets/Perfect RPG MMO 3D Effect VFX Pack`
- `Assets/Character`
- `Assets/NatureManufacture Assets`
- `Assets/SimpleLowPolyNature`
- `Assets/Suntail Village`
- `Assets/SkinnedDecal`

## 大体积文件观察

这些文件单体超过 50 MB。即使授权允许，也不要用普通 Git 提交，需使用 Git LFS、GitHub Release 或外部资源包：

| 文件 | 体积 | 建议 |
| --- | ---: | --- |
| `Assets/Resources/SAO_Prefab/Prefab/WangSiFu/关卡/青眼恶魔/贴图以及材质/76-1地板高清.png` | 324.48 MB | 不直接公开；确认授权后压缩/降采样或 LFS。 |
| `Assets/Resources/SAO_Prefab/Prefab/WangSiFu/关卡/青眼恶魔/贴图以及材质/76-1地板高清_N.png` | 324.48 MB | 不直接公开；确认授权后压缩/降采样或 LFS。 |
| `Assets/SubspaceHunter/Model/SAO原版模型/SAO决战资源/场景/浮空城模型/Aincrad031.obj` | 177.10 MB | 版权 IP 风险高，不公开。 |
| `Assets/SubspaceHunter/Font/*.asset` | 单个约 128 MB | 字体授权确认后，为公开版重建小型 SDF。 |
| `Assets/Resources/SAO_Prefab/Prefab/WangSiFu/关卡/第一层boss/8K地面.png` | 117.77 MB | 确认授权后降采样或 LFS。 |
| `Assets/SubspaceHunter/Model/茅场晶彦/Anime Day Equirect.png` | 109.26 MB | 角色/IP 风险高，不公开。 |
| `Assets/SubspaceHunter/3rd/WorldSpaceTransitions/fading/textures/*.asset` | 多个 96 MB | 第三方依赖；按导入说明处理。 |
| `Assets/SubspaceHunter/Model/boss房/原形boss房/oooo.fbx` | 81.27 MB | 确认来源后再决定，批准后 LFS。 |
| `Assets/Oculus/LipSync/Plugins/MacOSX/OVRLipSync.bundle` | 69.87 MB | 官方 SDK 二进制；不手工提交，写安装说明。 |
| `Assets/NatureManufacture Assets/.../lava_rocks_01_MT_AO_E.tga` | 61.78 MB | 第三方资源；不直接公开。 |

## 当前结论

`PublicDemo` 这些场景应保留在本地，因为它们是重要内容；但它们现在不是一个可以直接公开的自包含 Demo。若要把它们作为开源仓库的一部分，建议分三步：

1. 先提交场景清单和依赖清单，不提交资源本体。
2. 将 `Assets/SubspaceHunter/Script` 等低风险源码路径按新目录提交，保证代码结构和场景引用的脚本 GUID 不丢失。
3. 对每个外部根目录建立迁移状态：`可公开`、`需购买/导入`、`需替换`、`仅私有保留`。只有确认可再分发的资源才进入 Git LFS 或 Release 包。

## 后续人工确认项

- 确认 `Assets/SubspaceHunter/Model` 中哪些模型是原创，哪些来自 SAO 或第三方包。
- 确认 `Assets/SubspaceHunter/Sounds` 中所有音频来源。
- 确认 `Assets/SubspaceHunter/Font` 使用字体的授权，并为公开版生成更小字体资产。
- 记录 Oculus、DOTween、FinalIK、PuppetMaster、CurvedUI、DynamicBone、TextMesh Pro 的安装来源和版本。
- 对 `Assets/Resources/SAO_Prefab` 做二级拆分，区分自有 prefab、版权素材、大贴图和可替换占位资源。
