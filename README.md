# SubspaceHunter-SAO

SubspaceHunter-SAO is an open-source Unity XR action game framework inspired by SAO-style interaction and combat. The repository is being prepared in stages so the code can be shared safely while large assets and third-party content are reviewed.

## Repository status

This public repository currently focuses on the Unity project configuration and shareable source code. The full local project contains many large binary assets and third-party or copyrighted resources that need license review before redistribution.

See [docs/OPEN_SOURCE_ASSETS.md](docs/OPEN_SOURCE_ASSETS.md) for the asset policy and Git LFS notes.

## Unity version

- Unity Editor: `2021.3.45f1`
- Main platform target: Android / Quest-style XR
- XR packages: Oculus XR, OpenXR, XR Management

## Included

- `Packages/`
- `ProjectSettings/`
- Shareable scripts under `Assets/SubspaceHunter/Script`
- Shareable scene helper scripts under `Assets/SubspaceHunter/Scenes/Script`
- Public demo scene files under `Assets/PublicDemo/PublicScenes` via Git LFS
- Project documentation

## Not included yet

- Paid Asset Store packages
- Large textures, models, videos, audio, baked data, and generated Unity cache files
- Copyrighted or license-unclear character and environment assets

## Opening the project

This repository is not yet a complete playable checkout. The public demo scenes are included, but many referenced models, prefabs, sounds, fonts, SDKs, and effects are intentionally omitted until their redistribution rights are confirmed. To run the original project, restore the required asset folders from a licensed local copy, then open it with Unity `2021.3.45f1`.

## Notes for contributors

- Do not commit `Library/`, `Temp/`, `Logs/`, `UserSettings/`, `.csproj`, or `.sln` files.
- Use Git LFS for large binary assets when they are approved for redistribution.
- Keep Unity `.meta` files with any committed asset.
- Do not commit API keys, service credentials, keystores, or private database files.
